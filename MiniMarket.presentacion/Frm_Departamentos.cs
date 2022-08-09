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
    public partial class Frm_Departamentos : Form
    {
        public Frm_Departamentos()
        {
            InitializeComponent();
        }
        #region "Variables"
        int Estadoguarda = 0; //Sin ninguna accion
        int Codigo_de = 0;
        #endregion

        #region "Mis metodos"
        private void Formato_de()
        {
            Dgv_principal.Columns[0].Width = 100;
            Dgv_principal.Columns[0].HeaderText = "CODIGO_DE";
            Dgv_principal.Columns[1].Width = 300;
            Dgv_principal.Columns[1].HeaderText = "DEPARTAMENTO";
        }

        private void Listado_de( string cTexto)
        {
            try
            {
                Dgv_principal.DataSource = N_Departamentos.Listado_de(cTexto);
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
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["codigo_de"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                this.Codigo_de = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_de"].Value);
                Txt_descripcion_de.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_de"].Value);
            }
        }

        #endregion

        private void Frm_Departamentos_Load(object sender, EventArgs e)
        {
            this.Listado_de("%");
            this.Formato_de();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if(Txt_descripcion_de.Text == string.Empty)//Valida los datos que se estan enviando
            {
                MessageBox.Show("Falta ingresar datos requerido (*)", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Se procederia a registrar la informacion
            {
                string Rpta = "";
                E_Departamentos oDe = new E_Departamentos();
                oDe.Codigo_de = this.Codigo_de;
                oDe.Descripcion_de = Txt_descripcion_de.Text.Trim();
                Rpta = N_Departamentos.Guardar_de(Estadoguarda, oDe);
                if (Rpta == "ok")
                {
                    this.Listado_de("%");
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Estadoguarda = 0;  //Sin ninguna accion
                    this.Estado_BotonesPrincipales(true);
                    this.Estado_Botonesprocesos(false);
                    this.Txt_descripcion_de.ReadOnly = true;
                    Txt_descripcion_de.Text = "";
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
            Txt_descripcion_de.Text = "";
            Txt_descripcion_de.ReadOnly = false;
            Tbp_principal.SelectedIndex = 1;
            Txt_descripcion_de.Focus();
        }
        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Estadoguarda   = 2; //Actualizar registro
            this.Estado_BotonesPrincipales(false);
            this.Estado_Botonesprocesos(true);
            Txt_descripcion_de.Text = "";
            this.Selecciona_Item();
            Txt_descripcion_de.ReadOnly = false;
            Tbp_principal.SelectedIndex = 1;
            Txt_descripcion_de.Focus();

        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 0; //Sin ninguna accion
            this.Codigo_de = 0;
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
            Txt_descripcion_de.Text = "";
            this.Codigo_de = 0;
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["codigo_de"].Value)))
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
                    this.Codigo_de = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_de"].Value);
                    Rpta = N_Departamentos.Eliminar_de(this.Codigo_de);
                    if (Rpta.Equals("ok"))
                    {
                        this.Listado_de("%");
                        this.Codigo_de = 0;
                        MessageBox.Show("Registro eliminado", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
            }

        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_de(Txt_buscar.Text.Trim());
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            Reportes.Frm_Rpt_Departamentos oRpt6 = new Reportes.Frm_Rpt_Departamentos();
            oRpt6.txt_p1.Text = Txt_buscar.Text;
            oRpt6.ShowDialog();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
