
namespace MiniMarket.presentacion.Reportes
{
    partial class Frm_Rpt_Categorias
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
            this.DataSet_MiniMarket = new MiniMarket.presentacion.Reportes.DataSet_MiniMarket();
            this.Sp_Listado_caBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sp_Listado_caTableAdapter = new MiniMarket.presentacion.Reportes.DataSet_MiniMarketTableAdapters.Sp_Listado_caTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spListadocaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_MiniMarket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_Listado_caBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListadocaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataSet_MiniMarket
            // 
            this.DataSet_MiniMarket.DataSetName = "DataSet_MiniMarket";
            this.DataSet_MiniMarket.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Sp_Listado_caBindingSource
            // 
            this.Sp_Listado_caBindingSource.DataMember = "Sp_Listado_ca";
            this.Sp_Listado_caBindingSource.DataSource = this.DataSet_MiniMarket;
            // 
            // Sp_Listado_caTableAdapter
            // 
            this.Sp_Listado_caTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Sp_Listado_caBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MiniMarket.presentacion.Reportes.Rpt_Categorias.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(530, 314);
            this.reportViewer1.TabIndex = 0;
            // 
            // spListadocaBindingSource
            // 
            this.spListadocaBindingSource.DataMember = "Sp_Listado_ca";
            this.spListadocaBindingSource.DataSource = this.DataSet_MiniMarket;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(12, 37);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(100, 20);
            this.txt_p1.TabIndex = 1;
            this.txt_p1.Visible = false;
            // 
            // Frm_Rpt_Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 314);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Categorias";
            this.Text = "Reporte de categorias";
            this.Load += new System.EventHandler(this.Frm_Rpt_Categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_MiniMarket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_Listado_caBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListadocaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource Sp_Listado_caBindingSource;
        private DataSet_MiniMarket DataSet_MiniMarket;
        private DataSet_MiniMarketTableAdapters.Sp_Listado_caTableAdapter Sp_Listado_caTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spListadocaBindingSource;
        public System.Windows.Forms.TextBox txt_p1;
    }
}