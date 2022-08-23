
namespace MiniMarket.presentacion.Reportes
{
    partial class Frm_rpt_productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Sp_Listado_prBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_MiniMarket = new MiniMarket.presentacion.Reportes.DataSet_MiniMarket();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Sp_Listado_prTableAdapter = new MiniMarket.presentacion.Reportes.DataSet_MiniMarketTableAdapters.Sp_Listado_prTableAdapter();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_Listado_prBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_MiniMarket)).BeginInit();
            this.SuspendLayout();
            // 
            // Sp_Listado_prBindingSource
            // 
            this.Sp_Listado_prBindingSource.DataMember = "Sp_Listado_pr";
            this.Sp_Listado_prBindingSource.DataSource = this.DataSet_MiniMarket;
            // 
            // DataSet_MiniMarket
            // 
            this.DataSet_MiniMarket.DataSetName = "DataSet_MiniMarket";
            this.DataSet_MiniMarket.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Sp_Listado_prBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MiniMarket.presentacion.Reportes.Rpt_Productos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1000, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Sp_Listado_prTableAdapter
            // 
            this.Sp_Listado_prTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(12, 63);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(100, 20);
            this.txt_p1.TabIndex = 4;
            this.txt_p1.Visible = false;
            // 
            // Frm_rpt_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_rpt_productos";
            this.Text = "Frm_rpt_productos";
            this.Load += new System.EventHandler(this.Frm_rpt_productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sp_Listado_prBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_MiniMarket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Sp_Listado_prBindingSource;
        private DataSet_MiniMarket DataSet_MiniMarket;
        private DataSet_MiniMarketTableAdapters.Sp_Listado_prTableAdapter Sp_Listado_prTableAdapter;
        public System.Windows.Forms.TextBox txt_p1;
    }
}