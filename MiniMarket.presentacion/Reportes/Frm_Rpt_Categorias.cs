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
    public partial class Frm_Rpt_Categorias : Form
    {
        public Frm_Rpt_Categorias()
        {
            InitializeComponent();
        }

        private void Frm_Rpt_Categorias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet_MiniMarket.Sp_Listado_ca' Puede moverla o quitarla según sea necesario.
            this.Sp_Listado_caTableAdapter.Fill(this.DataSet_MiniMarket.Sp_Listado_ca, cTexto: txt_p1.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
