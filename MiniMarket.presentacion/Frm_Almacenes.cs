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
    public partial class Frm_Almacenes : Form
    {
        public Frm_Almacenes()
        {
            InitializeComponent();
        }
        #region "Variables"
        int Estadoguarda = 0; //Sin ninguna accion
        int Codigo_al = 0;
        #endregion

        #region "Mis metodos"
        private void Formato_al()
        {
            Dgv_principal.Columns[0].Width = 100;
            Dgv_principal.Columns[0].HeaderText = "CODIGO_AL";
            Dgv_principal.Columns[1].Width = 300;
            Dgv_principal.Columns[1].HeaderText = "ALMACEN";
        }

        private void Listado_al( string cTexto)
        {
            try
            {
                Dgv_principal.DataSource = N_Almacenes.Listado_al(cTexto);
                this.Formato_al();
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
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["codigo_al"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                this.Codigo_al = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_al"].Value);
                Txt_descripcion_al.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_al"].Value);
            }
        }

        #endregion

        private void Frm_Almacenes_Load(object sender, EventArgs e)
        {
            this.Listado_al("%");
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if(Txt_descripcion_al.Text == string.Empty)//Valida los datos que se estan enviando
            {
                MessageBox.Show("Falta ingresar datos requerido (*)", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Se procederia a registrar la informacion
            {
                string Rpta = "";
                E_Almacenes oAl = new E_Almacenes();
                oAl.Codigo_al = this.Codigo_al;
                oAl.Descripcion_al = Txt_descripcion_al.Text.Trim();
                Rpta = N_Almacenes.Guardar_al(Estadoguarda, oAl);
                if (Rpta == "ok")
                {
                    this.Listado_al("%");
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Estadoguarda = 0;  //Sin ninguna accion
                    this.Estado_BotonesPrincipales(true);
                    this.Estado_Botonesprocesos(false);
                    this.Txt_descripcion_al.ReadOnly = true;
                    Txt_descripcion_al.Text = "";
                    Tbp_principal.SelectedIndex = 0;
                    this.Codigo_al = 0;
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
            Txt_descripcion_al.Text = "";
            Txt_descripcion_al.ReadOnly = false;
            Tbp_principal.SelectedIndex = 1;
            Txt_descripcion_al.Focus();
        }
        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
          Estadoguarda   = 2; //Actualizar registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_Botonesprocesos(true);
            Txt_descripcion_al.Text = "";
            this.Selecciona_Item();
            Txt_descripcion_al.ReadOnly = false;
            Tbp_principal.SelectedIndex = 1;
            Txt_descripcion_al.Focus();

        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 0; //Sin ninguna accion
            this.Codigo_al = 0;
            Txt_descripcion_al.Text = "";
            Txt_descripcion_al.ReadOnly = true;
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
            Txt_descripcion_al.Text = "";
            this.Codigo_al = 0;
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["codigo_al"].Value)))
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
                    this.Codigo_al = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_al"].Value);
                    Rpta = N_Almacenes.Eliminar_al(this.Codigo_al);
                    if (Rpta.Equals("ok"))
                    {
                        this.Listado_al("%");
                        this.Codigo_al = 0;
                        MessageBox.Show("Registro eliminado", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
            }

        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_al(Txt_buscar.Text.Trim());
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            Reportes.Frm_Rpt_Almacenes oRpt3 = new Reportes.Frm_Rpt_Almacenes();
            oRpt3.txt_p1.Text = Txt_buscar.Text;
            oRpt3.ShowDialog();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
