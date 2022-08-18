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
    public partial class Frm_Provincias : Form
    {
        public Frm_Provincias()
        {
            InitializeComponent();
        }
        #region "Variables"
        int Estadoguarda = 0; //Sin ninguna accion
        int Codigo_po = 0;
        int Codigo_de = 0;
        #endregion

        #region "Mis metodos"
        private void Formato_po()
        {
            Dgv_principal.Columns[0].Width = 110;
            Dgv_principal.Columns[0].HeaderText = "CODIGO_PO";
            Dgv_principal.Columns[1].Width = 250;
            Dgv_principal.Columns[1].HeaderText = "PROVINCIA";
            Dgv_principal.Columns[2].Width = 250;
            Dgv_principal.Columns[2].HeaderText = "DEPARTAMENTO";
            Dgv_principal.Columns[3].Visible = false;
        }

        private void Listado_po( string cTexto)
        {
            try
            {
                Dgv_principal.DataSource = N_Provincias.Listado_po(cTexto);
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
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["codigo_po"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                this.Codigo_de = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_de"].Value);
                Txt_descripcion_de.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_de"].Value);

                this.Codigo_po = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_po"].Value);
                Txt_descripcion_po.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_po"].Value);
            }
        }

        private void Formato_de_po()
        {
            Dgv_departamentos.Columns[0].Width = 300;
            Dgv_departamentos.Columns[0].HeaderText = "DEPARTAMENTO";
            Dgv_departamentos.Columns[1].Visible = false;
        }

        private void Listado_de_po(string cTexto)
        {
            try
            {
                Dgv_departamentos.DataSource = N_Provincias.Listado_de_po(cTexto);
                this.Formato_de_po();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Selecciona_Item_de_po()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_departamentos.CurrentRow.Cells["codigo_de"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_de = Convert.ToInt32(Dgv_departamentos.CurrentRow.Cells["codigo_de"].Value);
                Txt_descripcion_de.Text = Convert.ToString(Dgv_departamentos.CurrentRow.Cells["descripcion_de"].Value);
            }
        }
        #endregion

        private void Frm_Provincias_Load(object sender, EventArgs e)
        {
            this.Listado_po("%");
            this.Listado_de_po("%");
            this.Formato_po();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if(Txt_descripcion_po.Text == string.Empty || Txt_descripcion_de.Text == string.Empty)//Valida los datos que se estan enviando
            {
                MessageBox.Show("Falta ingresar datos requerido (*)", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Se procederia a registrar la informacion
            {
                string Rpta = "";
                E_Provincias oPo = new E_Provincias();
                oPo.Codigo_po = this.Codigo_po;
                oPo.Codigo_de = this.Codigo_de;
                oPo.Descripcion_po = Txt_descripcion_po.Text.Trim();
                Rpta = N_Provincias.Guardar_po(Estadoguarda, oPo);
                if (Rpta == "ok")
                {
                    this.Listado_po("%");
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Estadoguarda = 0;  //Sin ninguna accion
                    this.Estado_BotonesPrincipales(true);
                    this.Estado_Botonesprocesos(false);
                    this.Txt_descripcion_po.ReadOnly = true;
                    Txt_descripcion_po.Text = "";
                    Txt_descripcion_de.Text = "";
                    Txt_buscar1.Text = "";
                    Tbp_principal.SelectedIndex = 0;
                    this.Codigo_de = 0;
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
            Txt_descripcion_po.Text = "";
            Txt_descripcion_po.ReadOnly = false;
            Tbp_principal.SelectedIndex = 1;
            Txt_descripcion_po.Focus();
        }
        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Estadoguarda   = 2; //Actualizar registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_Botonesprocesos(true);
            Txt_descripcion_po.Text = "";
            this.Selecciona_Item();
            Txt_descripcion_po.ReadOnly = false;
            Tbp_principal.SelectedIndex = 1;
            Txt_descripcion_po.Focus();

        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 0; //Sin ninguna accion
            this.Codigo_po = 0;
            Txt_descripcion_po.Text = "";
            Txt_descripcion_po.ReadOnly = true;
            Txt_descripcion_de.Text = "";
            Txt_descripcion_de.ReadOnly = true;
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
            Txt_descripcion_po.Text = "";
            this.Codigo_po = 0;
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["codigo_po"].Value)))
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
                    this.Codigo_po = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_po"].Value);
                    Rpta = N_Provincias.Eliminar_po(this.Codigo_po);
                    if (Rpta.Equals("ok"))
                    {
                        this.Listado_po("%");
                        this.Codigo_de = 0;
                        MessageBox.Show("Registro eliminado", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
            }

        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_po(Txt_buscar.Text.Trim());
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            Reportes.Frm_Rpt_Provincias oRpt7 = new Reportes.Frm_Rpt_Provincias();
            oRpt7.txt_p1.Text = Txt_buscar.Text;
            oRpt7.ShowDialog();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_lupa1_Click(object sender, EventArgs e)
        {
            Pnl_listado_de.Visible = true;
            Pnl_listado_de.Location = Btn_lupa1.Location;
        }

        private void Btn_retornar1_Click(object sender, EventArgs e)
        {
            Pnl_listado_de.Visible = false;
        }

        private void Dgv_departamentos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_Item_de_po();
            Pnl_listado_de.Visible = false;
            Txt_descripcion_po.Focus();
        }

        private void Btn_buscar1_Click(object sender, EventArgs e)
        {
            this.Listado_de_po(Txt_buscar1.Text);
        }

    }
}
