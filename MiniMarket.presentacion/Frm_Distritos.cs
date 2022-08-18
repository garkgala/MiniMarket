using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniMarket.Negocio;
using MiniMarket.Entidades;

namespace MiniMarket.presentacion
{
    public partial class Frm_Distritos : Form
    {
        public Frm_Distritos()
        {
            InitializeComponent();
        }
        #region "Variables"
        int Estadoguarda = 0; //Sin ninguna accion
        int Codigo_di = 0;
        int Codigo_po = 0;
        #endregion

        #region "Mis metodos"
        private void Formato_di()
        {
            Dgv_principal.Columns[0].Width = 80;
            Dgv_principal.Columns[0].HeaderText = "CODIGO_DI";
            Dgv_principal.Columns[1].Width = 200;
            Dgv_principal.Columns[1].HeaderText = "DISTRITO";
            Dgv_principal.Columns[2].Width = 200;
            Dgv_principal.Columns[2].HeaderText = "PROVINCIA";
            Dgv_principal.Columns[3].Width = 200;
            Dgv_principal.Columns[3].HeaderText = "DEPARTAMENTO";
            Dgv_principal.Columns[4].Visible = false;
        }

        private void Listado_di( string cTexto)
        {
            try
            {
                Dgv_principal.DataSource = N_Distritos.Listado_di(cTexto);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Estado_BotonesPrincipales(bool lEstado)
        {
            this.Btn_nuevo.Enabled = lEstado;
            this.Btn_actualizar.Enabled = lEstado;
            this.Btn_eliminar.Enabled = lEstado;
            this.Btn_reporte.Enabled = lEstado;
            this.Btn_salir.Enabled = lEstado;
        }

        private void Estado_Botonesprocesos(bool lEstado)
        {
            this.Btn_cancelar.Visible = lEstado;
            this.Btn_guardar.Visible = lEstado;
            this.Btn_retornar.Visible = !lEstado;
        }
        private void Selecciona_Item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["codigo_di"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                this.Codigo_di = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_di"].Value);
                Txt_descripcion_di.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_di"].Value);

                this.Codigo_po = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_po"].Value);
                Txt_descripcion_po.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_po"].Value);
            }
        }

        private void Formato_po_di()
        {   
            Dgv_provincias.Columns[0].Width = 150;
            Dgv_provincias.Columns[0].HeaderText = "PROVINCIA";
            Dgv_provincias.Columns[1].Width = 150;
            Dgv_provincias.Columns[1].HeaderText = "DEPARTAMENTO";
            Dgv_provincias.Columns[2].Visible = false;
        }

        private void Listado_po_di(string cTexto)
        {
            try
            {
                Dgv_provincias.DataSource = N_Distritos.Listado_po_di(cTexto);
                this.Formato_po_di();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_Item_po_di()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_provincias.CurrentRow.Cells["codigo_po"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_po = Convert.ToInt32(Dgv_provincias.CurrentRow.Cells["codigo_po"].Value);
                Txt_descripcion_po.Text = Convert.ToString(Dgv_provincias.CurrentRow.Cells["descripcion_po"].Value);
            }
        }
        #endregion

        private void Frm_Distritos_Load(object sender, EventArgs e)
        {
            this.Listado_di("%");
            this.Listado_po_di("%");
            this.Formato_di();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if(Txt_descripcion_di.Text == string.Empty || Txt_descripcion_po.Text == string.Empty)//Valida los datos que se estan enviando
            {
                MessageBox.Show("Falta ingresar datos requerido (*)", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Se procederia a registrar la informacion
            {
                string Rpta = "";
                E_Distritos oDi = new E_Distritos();
                oDi.Codigo_po = this.Codigo_po;
                oDi.Codigo_di = this.Codigo_di;
                oDi.Descripcion_di = Txt_descripcion_di.Text.Trim();
                Rpta = N_Distritos.Guardar_di(Estadoguarda, oDi);
                if (Rpta == "ok")
                {
                    this.Listado_di("%");
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Estadoguarda = 0;  //Sin ninguna accion
                    this.Estado_BotonesPrincipales(true);
                    this.Estado_Botonesprocesos(false);
                    this.Txt_descripcion_di.ReadOnly = true;
                    Txt_descripcion_di.Text = "";
                    Txt_descripcion_po.Text = "";
                    Txt_buscar1.Text = "";
                    Tbp_principal.SelectedIndex = 0;
                    this.Codigo_di = 0;
                    this.Codigo_po = 0;
                }
                else
                {
                    MessageBox.Show(Rpta, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            Estadoguarda = 1; //Nuevo registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_Botonesprocesos(true);
            Txt_descripcion_di.Text = "";
            Txt_descripcion_di.ReadOnly = false;
            Tbp_principal.SelectedIndex = 1;
            Txt_descripcion_di.Focus();
        }
        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Estadoguarda   = 2; //Actualizar registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_Botonesprocesos(true);
            Txt_descripcion_di.Text = "";
            this.Selecciona_Item();
            Txt_descripcion_di.ReadOnly = false;
            Tbp_principal.SelectedIndex = 1;
            Txt_descripcion_di.Focus();

        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 0; //Sin ninguna accion
            this.Codigo_po = 0;
            Txt_descripcion_di.Text = "";
            Txt_descripcion_di.ReadOnly = true;
            Txt_descripcion_po.Text = "";
            Txt_descripcion_po.ReadOnly = true;
            this.Estado_BotonesPrincipales(true);
            this.Estado_Botonesprocesos(false);
            Tbp_principal.SelectedIndex = 0;
        }

        private void Dgv_principal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_Item();
            this.Estado_Botonesprocesos(false);
            Tbp_principal.SelectedIndex = 1;
        }

        private void Btn_retornar_Click(object sender, EventArgs e)
        {
            this.Estado_Botonesprocesos(false);
            Tbp_principal.SelectedIndex = 0;
            Txt_descripcion_di.Text = "";
            Txt_descripcion_po.Text = "";
            this.Codigo_di = 0;
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["codigo_di"].Value)))
            {
                MessageBox.Show("No se tiene informacion para eliminar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Esta seguro de eliminar el registro seleccionado?", "Aviso del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion==DialogResult.Yes)
                {
                    string Rpta = "";
                    this.Codigo_di = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_di"].Value);
                    Rpta = N_Distritos.Eliminar_di(this.Codigo_di);
                    if (Rpta.Equals("ok"))
                    {
                        this.Listado_di("%");
                        this.Codigo_di = 0;
                        MessageBox.Show("Registro eliminado", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
            }

        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_di(Txt_buscar.Text.Trim());
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            Reportes.Frm_Rpt_Distritos oRpt8 = new Reportes.Frm_Rpt_Distritos();
            oRpt8.txt_p1.Text = Txt_buscar.Text;
            oRpt8.ShowDialog();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_lupa1_Click(object sender, EventArgs e)
        {
            Pnl_listado_po.Visible = true;
            Pnl_listado_po.Location = Btn_lupa1.Location;
        }

        private void Btn_retornar1_Click(object sender, EventArgs e)
        {
            Pnl_listado_po.Visible = false;
        }

        private void Dgv_departamentos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_Item_po_di();
            Pnl_listado_po.Visible = false;
            Txt_descripcion_di.Focus();
        }

        private void Btn_buscar1_Click(object sender, EventArgs e)
        {
            this.Listado_po_di(Txt_buscar1.Text);
        }

    }
}
