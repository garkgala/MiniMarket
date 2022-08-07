using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMarket.presentacion.Reportes
{
    public partial class Frm_Rpt_Rubros : Form
    {
        public Frm_Rpt_Rubros()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Rubros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet_MiniMarket.Sp_Listado_ru' Puede moverla o quitarla según sea necesario.
            this.Sp_Listado_ruTableAdapter.Fill(this.DataSet_MiniMarket.Sp_Listado_ru, cTexto: txt_p3.Text.Trim());

            this.reportViewer1.RefreshReport();
        }
    }
}
