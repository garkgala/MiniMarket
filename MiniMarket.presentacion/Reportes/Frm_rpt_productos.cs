﻿using System;
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
    public partial class Frm_rpt_productos : Form
    {
        public Frm_rpt_productos()
        {
            InitializeComponent();
        }

        private void Frm_rpt_productos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet_MiniMarket.Sp_Listado_pr' Puede moverla o quitarla según sea necesario.
            this.Sp_Listado_prTableAdapter.Fill(this.DataSet_MiniMarket.Sp_Listado_pr, cTexto: txt_p1.Text.Trim());

            this.reportViewer1.RefreshReport();
        }
    }
}