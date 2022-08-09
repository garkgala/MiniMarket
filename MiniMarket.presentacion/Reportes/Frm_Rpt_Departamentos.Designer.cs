
namespace MiniMarket.presentacion.Reportes
{
    partial class Frm_Rpt_Departamentos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet_MiniMarket = new MiniMarket.presentacion.Reportes.DataSet_MiniMarket();
            this.Sp_Listado_deBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sp_Listado_deTableAdapter = new MiniMarket.presentacion.Reportes.DataSet_MiniMarketTableAdapters.Sp_Listado_deTableAdapter();
            this.txt_p1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_MiniMarket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_Listado_deBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Sp_Listado_deBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MiniMarket.presentacion.Reportes.Rpt_Departamentos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet_MiniMarket
            // 
            this.DataSet_MiniMarket.DataSetName = "DataSet_MiniMarket";
            this.DataSet_MiniMarket.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Sp_Listado_deBindingSource
            // 
            this.Sp_Listado_deBindingSource.DataMember = "Sp_Listado_de";
            this.Sp_Listado_deBindingSource.DataSource = this.DataSet_MiniMarket;
            // 
            // Sp_Listado_deTableAdapter
            // 
            this.Sp_Listado_deTableAdapter.ClearBeforeFill = true;
            // 
            // txt_p1
            // 
            this.txt_p1.Location = new System.Drawing.Point(25, 56);
            this.txt_p1.Name = "txt_p1";
            this.txt_p1.Size = new System.Drawing.Size(100, 20);
            this.txt_p1.TabIndex = 3;
            this.txt_p1.Visible = false;
            // 
            // Frm_Rpt_Departamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_p1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Rpt_Departamentos";
            this.Text = "Frm_Rpt_Departamentos";
            this.Load += new System.EventHandler(this.Frm_Rpt_Departamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_MiniMarket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_Listado_deBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Sp_Listado_deBindingSource;
        private DataSet_MiniMarket DataSet_MiniMarket;
        private DataSet_MiniMarketTableAdapters.Sp_Listado_deTableAdapter Sp_Listado_deTableAdapter;
        public System.Windows.Forms.TextBox txt_p1;
    }
}