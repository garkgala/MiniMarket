
namespace MiniMarket.presentacion.Reportes
{
    partial class Frm_Rpt_Rubros
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
            this.Sp_Listado_ruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_MiniMarket = new MiniMarket.presentacion.Reportes.DataSet_MiniMarket();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Sp_Listado_ruTableAdapter = new MiniMarket.presentacion.Reportes.DataSet_MiniMarketTableAdapters.Sp_Listado_ruTableAdapter();
            this.txt_p3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_Listado_ruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_MiniMarket)).BeginInit();
            this.SuspendLayout();
            // 
            // Sp_Listado_ruBindingSource
            // 
            this.Sp_Listado_ruBindingSource.DataMember = "Sp_Listado_ru";
            this.Sp_Listado_ruBindingSource.DataSource = this.DataSet_MiniMarket;
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
            reportDataSource1.Value = this.Sp_Listado_ruBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MiniMarket.presentacion.Reportes.Rpt_Rubros.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Sp_Listado_ruTableAdapter
            // 
            this.Sp_Listado_ruTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p3
            // 
            this.txt_p3.Location = new System.Drawing.Point(12, 55);
            this.txt_p3.Name = "txt_p3";
            this.txt_p3.Size = new System.Drawing.Size(100, 20);
            this.txt_p3.TabIndex = 3;
            this.txt_p3.Visible = false;
            // 
            // Frm_Rpt_Rubros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_p3);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Rubros";
            this.Text = "Frm_Rpt_Rubros";
            this.Load += new System.EventHandler(this.Frm_Rpt_Rubros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sp_Listado_ruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_MiniMarket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Sp_Listado_ruBindingSource;
        private DataSet_MiniMarket DataSet_MiniMarket;
        private DataSet_MiniMarketTableAdapters.Sp_Listado_ruTableAdapter Sp_Listado_ruTableAdapter;
        public System.Windows.Forms.TextBox txt_p3;
    }
}