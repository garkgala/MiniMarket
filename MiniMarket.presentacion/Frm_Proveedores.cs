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
    public partial class Frm_Proveedores : Form
    {
        public Frm_Proveedores()
        {
            InitializeComponent();
        }
        #region "Variables"
        int Estadoguarda = 0; //Sin ninguna accion
        int Codigo_pv = 0;
        int Codigo_tdpc = 0;
        int Codigo_sx = 0;
        int Codigo_ru = 0;
        int Codigo_di = 0;
        #endregion

        #region "Mis metodos"
        private void Formato_pv()
        {
            Dgv_principal.Columns[0].Width = 80;
            Dgv_principal.Columns[0].HeaderText = "CODIGO_PV";
            Dgv_principal.Columns[1].Width = 95;
            Dgv_principal.Columns[1].HeaderText = "TIPO DOC";
            Dgv_principal.Columns[2].Width = 110;
            Dgv_principal.Columns[2].HeaderText = "NRO DOC";
            Dgv_principal.Columns[3].Width = 250;
            Dgv_principal.Columns[3].HeaderText = "RAZON SOCIAL";
            Dgv_principal.Columns[4].Width = 130;
            Dgv_principal.Columns[4].HeaderText = "NOMBRES";
            Dgv_principal.Columns[5].Width = 130;
            Dgv_principal.Columns[5].HeaderText = "APELLIDOS";
            Dgv_principal.Columns[6].Width = 120;
            Dgv_principal.Columns[6].HeaderText = "RUBRO";
            Dgv_principal.Columns[7].Visible = false;
            Dgv_principal.Columns[8].Visible = false;
            Dgv_principal.Columns[9].Visible = false;
            Dgv_principal.Columns[10].Visible = false;
            Dgv_principal.Columns[11].Visible = false;
            Dgv_principal.Columns[12].Visible = false;
            Dgv_principal.Columns[13].Visible = false;
            Dgv_principal.Columns[14].Visible = false;
            Dgv_principal.Columns[15].Visible = false;
            Dgv_principal.Columns[16].Visible = false;
            Dgv_principal.Columns[17].Visible = false;
            Dgv_principal.Columns[18].Visible = false;
            Dgv_principal.Columns[19].Visible = false;
        }
        private void Selecciona_Item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["codigo_pv"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string distrito = "";
                this.Codigo_pv = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_pv"].Value);
                this.Codigo_tdpc = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["Codigo_tdpc"].Value); //EL PROCEDIMIENTO NO TRAE ESTE CODIGO OJO**********
                Txt_descripcion_tdpc.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_tdpc"].Value);
                Txt_nrodocumento_pv.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["nrodocumento_pv"].Value);
                Txt_razon_social_pv.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["razon_social_pv"].Value);
                Txt_nombres.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["nombres"].Value);
                Txt_apellidos.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["apellidos"].Value);
                this.Codigo_ru = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_ru"].Value);
                Txt_descripcion_ru.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_ru"].Value);
                Txt_email_pv.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["email_pv"].Value);
                Txt_telefono_pv.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["telefono_pv"].Value);
                Txt_movil_pv.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["movil_pv"].Value);
                this.Codigo_sx = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_sx"].Value);
                Txt_descripcion_sx.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_sx"].Value);
                Txt_direccion_pv.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["direccion_pv"].Value);
                this.Codigo_di = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_di"].Value);
                distrito = Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_di"].Value).Trim() + " | " +
                            Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_po"].Value).Trim() + " | " +
                            Convert.ToString(Dgv_principal.CurrentRow.Cells["descripcion_de"].Value).Trim();
                Txt_distrito.Text = distrito;
                Txt_observacion_pv.Text = Convert.ToString(Dgv_principal.CurrentRow.Cells["observacion_pv"].Value).Trim();
            }
        }

        private void Listado_pv( string cTexto)
        {
            try
            {
                Dgv_principal.DataSource = N_Proveedores.Listado_pv(cTexto);
                this.Formato_pv();
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
        private void Formato_tdpc()
        {
            Dgv_tdpc.Columns[0].Width = 225;
            Dgv_tdpc.Columns[0].HeaderText = "TIPO DOCUMENTO";
            Dgv_tdpc.Columns[1].Visible = false;
        }

        private void Listado_tdpc()
        {
            try
            {
                Dgv_tdpc.DataSource = N_Proveedores.Listado_tdpc();
                this.Formato_tdpc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Selecciona_Item_tdpc()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_tdpc.CurrentRow.Cells["codigo_tdpc"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_tdpc = Convert.ToInt32(Dgv_tdpc.CurrentRow.Cells["codigo_tdpc"].Value);
                Txt_descripcion_tdpc.Text = Convert.ToString(Dgv_tdpc.CurrentRow.Cells["descripcion_tdpc"].Value);
            }
        }

        private void Formato_sx()
        {
            Dgv_sexos.Columns[0].Width = 225;
            Dgv_sexos.Columns[0].HeaderText = "SEXO";
            Dgv_sexos.Columns[1].Visible = false;
        }

        private void Listado_sx()
        {
            try
            {
                Dgv_sexos.DataSource = N_Proveedores.Listado_sx();
                this.Formato_sx();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Selecciona_Item_sx()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_sexos.CurrentRow.Cells["codigo_sx"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_sx = Convert.ToInt32(Dgv_sexos.CurrentRow.Cells["codigo_sx"].Value);
                Txt_descripcion_sx.Text = Convert.ToString(Dgv_sexos.CurrentRow.Cells["descripcion_sx"].Value);
            }
        }

        private void Formato_ru()
        {
            Dgv_rubros.Columns[0].Width = 225;
            Dgv_rubros.Columns[0].HeaderText = "RUBROS";
            Dgv_rubros.Columns[1].Visible = false;
        }

        private void Listado_ru(string cTexto)
        {
            try
            {
                Dgv_rubros.DataSource = N_Proveedores.Listado_ru_pv(cTexto);
                this.Formato_ru();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Selecciona_Item_ru()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_rubros.CurrentRow.Cells["codigo_ru"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_ru = Convert.ToInt32(Dgv_rubros.CurrentRow.Cells["codigo_ru"].Value);
                Txt_descripcion_ru.Text = Convert.ToString(Dgv_rubros.CurrentRow.Cells["descripcion_ru"].Value);
            }
        }

        private void Formato_di()
        {
            Dgv_distritos.Columns[0].Width = 153;
            Dgv_distritos.Columns[0].HeaderText = "DISTRITO"; 
            Dgv_distritos.Columns[1].Width = 153;
            Dgv_distritos.Columns[1].HeaderText = "PROVINCIA";
            Dgv_distritos.Columns[2].Width = 153;
            Dgv_distritos.Columns[2].HeaderText = "DEPARTAMENTO";
            Dgv_distritos.Columns[3].Visible = false;
        }

        private void Listado_di(string cTexto)
        {
            try
            {
                Dgv_distritos.DataSource = N_Proveedores.Listado_di_pv(cTexto);
                this.Formato_di();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Selecciona_Item_di()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_distritos.CurrentRow.Cells["codigo_di"].Value)))
            {
                MessageBox.Show("No se tiene informacion para visualizar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Codigo_di = Convert.ToInt32(Dgv_distritos.CurrentRow.Cells["codigo_di"].Value);
                Txt_distrito.Text = Convert.ToString(Dgv_distritos.CurrentRow.Cells["descripcion_di"].Value) + " | " +
                                    Convert.ToString(Dgv_distritos.CurrentRow.Cells["descripcion_po"].Value) + " | " +
                                    Convert.ToString(Dgv_distritos.CurrentRow.Cells["descripcion_de"].Value);
            }
        }
        private void Estado_texto(bool lestado)
        {
            Txt_nrodocumento_pv.ReadOnly = !lestado;
            Txt_razon_social_pv.ReadOnly = !lestado;
            Txt_nombres.ReadOnly = !lestado;
            Txt_apellidos.ReadOnly = !lestado;
            Txt_email_pv.ReadOnly = !lestado;
            Txt_telefono_pv.ReadOnly = !lestado;
            Txt_movil_pv.ReadOnly = !lestado;
            Txt_direccion_pv.ReadOnly = !lestado;
            Txt_observacion_pv.ReadOnly = !lestado;
        }

        private void Limpiar_texto()
        {
            Txt_nrodocumento_pv.Text = "";
            Txt_razon_social_pv.Text = "";
            Txt_nombres.Text = "";
            Txt_apellidos.Text = "";
            Txt_email_pv.Text = "";
            Txt_telefono_pv.Text = "";
            Txt_movil_pv.Text = "";
            Txt_direccion_pv.Text = "";
            Txt_observacion_pv.Text = "";
        }

        #endregion

        private void Frm_Proveedores_Load(object sender, EventArgs e)
        {
            this.Listado_pv("%");
            this.Listado_tdpc();
            this.Listado_sx();
            this.Listado_ru("%");
            this.Listado_di("%");
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if( Txt_nrodocumento_pv.Text == string.Empty ||
                Txt_descripcion_tdpc.Text == string.Empty ||
                Txt_descripcion_sx.Text == string.Empty ||
                Txt_descripcion_ru.Text == string.Empty ||
                Txt_razon_social_pv.Text == string.Empty ||
                Txt_distrito.Text == string.Empty ||
                Txt_direccion_pv.Text == string.Empty)
            {
                MessageBox.Show("Falta ingresar datos requerido (*)", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Se procederia a registrar la informacion
            {
                string Rpta = "";
                E_Proveedores ePv = new E_Proveedores();
                ePv.Apellidos = Txt_apellidos.Text.Trim();
                ePv.Codigo_di = this.Codigo_di;
                ePv.Codigo_pv = this.Codigo_pv;
                ePv.Codigo_ru = this.Codigo_ru;
                ePv.Codigo_sx = this.Codigo_sx;
                ePv.Codigo_tdpc = this.Codigo_tdpc;
                ePv.Email = Txt_email_pv.Text.Trim();
                ePv.Movil = Txt_movil_pv.Text.Trim();
                ePv.Telefono = Txt_telefono_pv.Text.Trim();
                ePv.Razon_social_pv = Txt_razon_social_pv.Text.Trim();
                ePv.Observacion_pv = Txt_observacion_pv.Text.Trim();
                ePv.Nrodocumento_pv = Txt_nrodocumento_pv.Text.Trim();
                ePv.Nombres = Txt_nombres.Text.Trim();
                ePv.Direccion_pv = Txt_direccion_pv.Text.Trim();
                Rpta = N_Proveedores.Guardar_pv(Estadoguarda, ePv);
                if (Rpta.Equals("ok"))
                {
                    this.Listado_pv("%");
                    MessageBox.Show("Los datos han sido guardados correctamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Estadoguarda = 0;  //Sin ninguna accion
                    this.Estado_BotonesPrincipales(true);
                    this.Estado_Botonesprocesos(false);
                    this.Txt_nrodocumento_pv.ReadOnly = true;
                    Tbp_principal.SelectedIndex = 0;
                    this.Codigo_pv = 0;
                    this.Codigo_di = 0;
                    this.Codigo_ru = 0;
                    this.Codigo_sx = 0;
                    this.Codigo_tdpc = 0;
                    this.Estado_texto(false);
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
            this.Limpiar_texto();
            this.Estado_texto(true);
            Tbp_principal.SelectedIndex = 1;
            Txt_nrodocumento_pv.Focus();
        }
        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 2; //Actualizar registro
            this.Selecciona_Item();
            this.Estado_BotonesPrincipales(false);
            this.Estado_Botonesprocesos(true);
            this.Estado_texto(true);
            Tbp_principal.SelectedIndex = 1;
            Txt_nrodocumento_pv.Focus();

        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            Estadoguarda = 0; //Sin ninguna accion
            this.Codigo_pv = 0;
            this.Estado_texto(false);
            this.Limpiar_texto();
            this.Codigo_pv = 0;
            this.Codigo_di = 0;
            this.Codigo_ru = 0;
            this.Codigo_sx = 0;
            this.Codigo_tdpc = 0;
            this.Estado_BotonesPrincipales(true);
            this.Estado_Botonesprocesos(false);
            Tbp_principal.SelectedIndex = 0;
        }

        private void Btn_retornar_Click(object sender, EventArgs e)
        {
            this.Estado_Botonesprocesos(false);
            Tbp_principal.SelectedIndex = 0;            
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Dgv_principal.CurrentRow.Cells["codigo_pv"].Value)))
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
                    this.Codigo_pv = Convert.ToInt32(Dgv_principal.CurrentRow.Cells["codigo_pv"].Value);
                    Rpta = N_Proveedores.Eliminar_pv(this.Codigo_pv);
                    if (Rpta.Equals("ok"))
                    {
                        this.Listado_pv("%");
                        this.Codigo_pv = 0;
                        MessageBox.Show("Registro eliminado", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
            }

        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_pv(Txt_buscar.Text.Trim());
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            Reportes.Frm_rpt__Proveedores oRpt4 = new Reportes.Frm_rpt__Proveedores();
            oRpt4.txt_p3.Text = Txt_buscar.Text;
            oRpt4.ShowDialog();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_lupa1_Click(object sender, EventArgs e)
        {
            this.Pnl_listado_tdpc.Location = Btn_lupa1.Location;
            this.Pnl_listado_tdpc.Visible = true;
        }


        private void Btn_lupa2_Click(object sender, EventArgs e)
        {
            this.Pnl_listado_sx.Location = Btn_lupa1.Location;
            this.Pnl_listado_sx.Visible = true;
        }

        private void Btn_buscar2_Click(object sender, EventArgs e)
        {
            //this.Listado_um_pr(Txt_buscar2.Text);
        }

        private void Btn_retornar1_Click(object sender, EventArgs e)
        {
            Pnl_listado_tdpc.Visible = false;
        }

        private void Btn_retornar2_Click(object sender, EventArgs e)
        {
            Pnl_listado_sx.Visible = false;
        }


        private void Btn_Lupa3_Click(object sender, EventArgs e)
        {
            this.Pnl_listado_ru.Location = Btn_lupa1.Location;
            this.Pnl_listado_ru.Visible = true;
        }


        private void Btn_buscar3_Click(object sender, EventArgs e)
        {
            this.Listado_ru(Txt_buscar3.Text);
        }

        private void Btn_retornar3_Click(object sender, EventArgs e)
        {
            Pnl_listado_ru.Visible = false;
        }

        private void Dgv_tdpc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_Item_tdpc();
            Pnl_listado_tdpc.Visible = false;
            Txt_nrodocumento_pv.Focus();
        }

        private void Dgv_sexos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_Item_sx();
            Pnl_listado_sx.Visible = false;
        }

        private void Dgv_rubros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_Item_ru();
            Pnl_listado_ru.Visible = false;
        }


        private void Dgv_distritos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_Item_di();
            Pnl_listado_di.Visible = false;
        }

        private void Btn_buscar4_Click(object sender, EventArgs e)
        {
            this.Listado_di(Txt_buscar4.Text);
        }

        private void Btn_retornar4_Click(object sender, EventArgs e)
        {
            Pnl_listado_di.Visible = false;
        }

        private void Btn_lupa4_Click(object sender, EventArgs e)
        {
            this.Pnl_listado_di.Visible = true;
        }

        private void Dgv_principal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_Item();
            this.Estado_Botonesprocesos(false);
            Tbp_principal.SelectedIndex = 1;
        }
    }
}
