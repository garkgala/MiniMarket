﻿
namespace MiniMarket.presentacion
{
    public partial class Frm_Distritos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Distritos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tbp_principal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Dgv_principal = new System.Windows.Forms.DataGridView();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.Txt_buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Pnl_listado_po = new System.Windows.Forms.Panel();
            this.Btn_retornar1 = new System.Windows.Forms.Button();
            this.Btn_buscar1 = new System.Windows.Forms.Button();
            this.Txt_buscar1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Dgv_provincias = new System.Windows.Forms.DataGridView();
            this.Btn_lupa1 = new System.Windows.Forms.Button();
            this.Txt_descripcion_po = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_retornar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Txt_descripcion_di = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_nuevo = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_reporte = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Tbp_principal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_principal)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.Pnl_listado_po.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_provincias)).BeginInit();
            this.SuspendLayout();
            // 
            // Tbp_principal
            // 
            this.Tbp_principal.Controls.Add(this.tabPage1);
            this.Tbp_principal.Controls.Add(this.tabPage2);
            this.Tbp_principal.Location = new System.Drawing.Point(12, 12);
            this.Tbp_principal.Name = "Tbp_principal";
            this.Tbp_principal.SelectedIndex = 0;
            this.Tbp_principal.Size = new System.Drawing.Size(740, 265);
            this.Tbp_principal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.Dgv_principal);
            this.tabPage1.Controls.Add(this.Btn_buscar);
            this.tabPage1.Controls.Add(this.Txt_buscar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(732, 239);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            // 
            // Dgv_principal
            // 
            this.Dgv_principal.AllowUserToAddRows = false;
            this.Dgv_principal.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(252)))), ((int)(((byte)(191)))));
            this.Dgv_principal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_principal.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Dgv_principal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_principal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_principal.ColumnHeadersHeight = 35;
            this.Dgv_principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_principal.EnableHeadersVisualStyles = false;
            this.Dgv_principal.Location = new System.Drawing.Point(20, 59);
            this.Dgv_principal.MultiSelect = false;
            this.Dgv_principal.Name = "Dgv_principal";
            this.Dgv_principal.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_principal.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_principal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_principal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Dgv_principal.Size = new System.Drawing.Size(652, 174);
            this.Dgv_principal.TabIndex = 7;
            this.Dgv_principal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_principal_CellDoubleClick);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_buscar.ForeColor = System.Drawing.Color.White;
            this.Btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_buscar.ImageKey = "Lupa.png";
            this.Btn_buscar.ImageList = this.imageList2;
            this.Btn_buscar.Location = new System.Drawing.Point(269, 14);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.Btn_buscar.TabIndex = 6;
            this.Btn_buscar.Text = "   Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = false;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Lupa.png");
            this.imageList2.Images.SetKeyName(1, "Retornar.png");
            this.imageList2.Images.SetKeyName(2, "Guardar.png");
            this.imageList2.Images.SetKeyName(3, "Cancelar.png");
            // 
            // Txt_buscar
            // 
            this.Txt_buscar.Location = new System.Drawing.Point(69, 16);
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.Size = new System.Drawing.Size(194, 20);
            this.Txt_buscar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.Pnl_listado_po);
            this.tabPage2.Controls.Add(this.Btn_lupa1);
            this.tabPage2.Controls.Add(this.Txt_descripcion_po);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.Btn_retornar);
            this.tabPage2.Controls.Add(this.Btn_guardar);
            this.tabPage2.Controls.Add(this.Btn_cancelar);
            this.tabPage2.Controls.Add(this.Txt_descripcion_di);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(732, 239);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            // 
            // Pnl_listado_po
            // 
            this.Pnl_listado_po.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(241)))), ((int)(((byte)(176)))));
            this.Pnl_listado_po.Controls.Add(this.Btn_retornar1);
            this.Pnl_listado_po.Controls.Add(this.Btn_buscar1);
            this.Pnl_listado_po.Controls.Add(this.Txt_buscar1);
            this.Pnl_listado_po.Controls.Add(this.label9);
            this.Pnl_listado_po.Controls.Add(this.label8);
            this.Pnl_listado_po.Controls.Add(this.Dgv_provincias);
            this.Pnl_listado_po.Location = new System.Drawing.Point(344, 39);
            this.Pnl_listado_po.Name = "Pnl_listado_po";
            this.Pnl_listado_po.Size = new System.Drawing.Size(382, 214);
            this.Pnl_listado_po.TabIndex = 18;
            this.Pnl_listado_po.Visible = false;
            // 
            // Btn_retornar1
            // 
            this.Btn_retornar1.ImageKey = "Retornar.png";
            this.Btn_retornar1.ImageList = this.imageList2;
            this.Btn_retornar1.Location = new System.Drawing.Point(245, 36);
            this.Btn_retornar1.Name = "Btn_retornar1";
            this.Btn_retornar1.Size = new System.Drawing.Size(35, 23);
            this.Btn_retornar1.TabIndex = 24;
            this.Btn_retornar1.UseVisualStyleBackColor = true;
            this.Btn_retornar1.Click += new System.EventHandler(this.Btn_retornar1_Click);
            // 
            // Btn_buscar1
            // 
            this.Btn_buscar1.ImageKey = "Lupa.png";
            this.Btn_buscar1.ImageList = this.imageList2;
            this.Btn_buscar1.Location = new System.Drawing.Point(204, 36);
            this.Btn_buscar1.Name = "Btn_buscar1";
            this.Btn_buscar1.Size = new System.Drawing.Size(35, 23);
            this.Btn_buscar1.TabIndex = 23;
            this.Btn_buscar1.UseVisualStyleBackColor = true;
            this.Btn_buscar1.Click += new System.EventHandler(this.Btn_buscar1_Click);
            // 
            // Txt_buscar1
            // 
            this.Txt_buscar1.Location = new System.Drawing.Point(62, 38);
            this.Txt_buscar1.Name = "Txt_buscar1";
            this.Txt_buscar1.Size = new System.Drawing.Size(136, 20);
            this.Txt_buscar1.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Buscar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(88, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "LISTADO DE PROVINCIAS";
            // 
            // Dgv_provincias
            // 
            this.Dgv_provincias.AllowUserToAddRows = false;
            this.Dgv_provincias.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(252)))), ((int)(((byte)(191)))));
            this.Dgv_provincias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_provincias.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Dgv_provincias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_provincias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_provincias.ColumnHeadersHeight = 35;
            this.Dgv_provincias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_provincias.EnableHeadersVisualStyles = false;
            this.Dgv_provincias.Location = new System.Drawing.Point(31, 74);
            this.Dgv_provincias.MultiSelect = false;
            this.Dgv_provincias.Name = "Dgv_provincias";
            this.Dgv_provincias.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_provincias.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv_provincias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_provincias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Dgv_provincias.Size = new System.Drawing.Size(310, 130);
            this.Dgv_provincias.TabIndex = 19;
            this.Dgv_provincias.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_departamentos_CellContentDoubleClick);
            // 
            // Btn_lupa1
            // 
            this.Btn_lupa1.ImageKey = "Lupa.png";
            this.Btn_lupa1.ImageList = this.imageList2;
            this.Btn_lupa1.Location = new System.Drawing.Point(326, 39);
            this.Btn_lupa1.Name = "Btn_lupa1";
            this.Btn_lupa1.Size = new System.Drawing.Size(26, 23);
            this.Btn_lupa1.TabIndex = 9;
            this.Btn_lupa1.UseVisualStyleBackColor = true;
            this.Btn_lupa1.Click += new System.EventHandler(this.Btn_lupa1_Click);
            // 
            // Txt_descripcion_po
            // 
            this.Txt_descripcion_po.Enabled = false;
            this.Txt_descripcion_po.Location = new System.Drawing.Point(105, 41);
            this.Txt_descripcion_po.MaxLength = 100;
            this.Txt_descripcion_po.Name = "Txt_descripcion_po";
            this.Txt_descripcion_po.Size = new System.Drawing.Size(215, 20);
            this.Txt_descripcion_po.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Provincia (*):";
            // 
            // Btn_retornar
            // 
            this.Btn_retornar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(241)))), ((int)(((byte)(176)))));
            this.Btn_retornar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_retornar.ForeColor = System.Drawing.Color.White;
            this.Btn_retornar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_retornar.ImageKey = "Retornar.png";
            this.Btn_retornar.ImageList = this.imageList2;
            this.Btn_retornar.Location = new System.Drawing.Point(277, 162);
            this.Btn_retornar.Name = "Btn_retornar";
            this.Btn_retornar.Size = new System.Drawing.Size(75, 23);
            this.Btn_retornar.TabIndex = 3;
            this.Btn_retornar.Text = "     Retornar";
            this.Btn_retornar.UseVisualStyleBackColor = false;
            this.Btn_retornar.Click += new System.EventHandler(this.Btn_retornar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_guardar.ForeColor = System.Drawing.Color.White;
            this.Btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_guardar.ImageKey = "Guardar.png";
            this.Btn_guardar.ImageList = this.imageList2;
            this.Btn_guardar.Location = new System.Drawing.Point(172, 162);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.Btn_guardar.TabIndex = 2;
            this.Btn_guardar.Text = "     Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Visible = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.Btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_cancelar.ImageKey = "Cancelar.png";
            this.Btn_cancelar.ImageList = this.imageList2;
            this.Btn_cancelar.Location = new System.Drawing.Point(72, 162);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_cancelar.TabIndex = 2;
            this.Btn_cancelar.Text = "     Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            this.Btn_cancelar.Visible = false;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Txt_descripcion_di
            // 
            this.Txt_descripcion_di.Location = new System.Drawing.Point(105, 77);
            this.Txt_descripcion_di.MaxLength = 100;
            this.Txt_descripcion_di.Name = "Txt_descripcion_di";
            this.Txt_descripcion_di.Size = new System.Drawing.Size(216, 20);
            this.Txt_descripcion_di.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Distrito (*):";
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(241)))), ((int)(((byte)(176)))));
            this.Btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_nuevo.ImageKey = "New_Logo.png";
            this.Btn_nuevo.ImageList = this.imageList1;
            this.Btn_nuevo.Location = new System.Drawing.Point(18, 289);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(75, 60);
            this.Btn_nuevo.TabIndex = 1;
            this.Btn_nuevo.Text = "Nuevo";
            this.Btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_nuevo.UseVisualStyleBackColor = false;
            this.Btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "New_Logo.png");
            this.imageList1.Images.SetKeyName(1, "Actualizar.png");
            this.imageList1.Images.SetKeyName(2, "Eliminar.png");
            this.imageList1.Images.SetKeyName(3, "Reporte.png");
            this.imageList1.Images.SetKeyName(4, "Salir.png");
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(241)))), ((int)(((byte)(176)))));
            this.Btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_actualizar.ImageKey = "Actualizar.png";
            this.Btn_actualizar.ImageList = this.imageList1;
            this.Btn_actualizar.Location = new System.Drawing.Point(99, 289);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(75, 60);
            this.Btn_actualizar.TabIndex = 1;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_actualizar.UseVisualStyleBackColor = false;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(241)))), ((int)(((byte)(176)))));
            this.Btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_eliminar.ImageKey = "Eliminar.png";
            this.Btn_eliminar.ImageList = this.imageList1;
            this.Btn_eliminar.Location = new System.Drawing.Point(180, 289);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(75, 60);
            this.Btn_eliminar.TabIndex = 1;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_reporte
            // 
            this.Btn_reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(241)))), ((int)(((byte)(176)))));
            this.Btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_reporte.ImageKey = "Reporte.png";
            this.Btn_reporte.ImageList = this.imageList1;
            this.Btn_reporte.Location = new System.Drawing.Point(261, 289);
            this.Btn_reporte.Name = "Btn_reporte";
            this.Btn_reporte.Size = new System.Drawing.Size(75, 60);
            this.Btn_reporte.TabIndex = 1;
            this.Btn_reporte.Text = "Reporte";
            this.Btn_reporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_reporte.UseVisualStyleBackColor = false;
            this.Btn_reporte.Click += new System.EventHandler(this.Btn_reporte_Click);
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(241)))), ((int)(((byte)(176)))));
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_salir.ImageKey = "Salir.png";
            this.Btn_salir.ImageList = this.imageList1;
            this.Btn_salir.Location = new System.Drawing.Point(342, 289);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(75, 60);
            this.Btn_salir.TabIndex = 1;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Frm_Distritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(195)))), ((int)(((byte)(142)))));
            this.ClientSize = new System.Drawing.Size(789, 396);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_reporte);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_nuevo);
            this.Controls.Add(this.Tbp_principal);
            this.Name = "Frm_Distritos";
            this.Text = "Distritos";
            this.Load += new System.EventHandler(this.Frm_Distritos_Load);
            this.Tbp_principal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_principal)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Pnl_listado_po.ResumeLayout(false);
            this.Pnl_listado_po.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_provincias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tbp_principal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_reporte;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.DataGridView Dgv_principal;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.TextBox Txt_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.TextBox Txt_descripcion_di;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_retornar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Btn_lupa1;
        private System.Windows.Forms.TextBox Txt_descripcion_po;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Pnl_listado_po;
        private System.Windows.Forms.Button Btn_retornar1;
        private System.Windows.Forms.Button Btn_buscar1;
        private System.Windows.Forms.TextBox Txt_buscar1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView Dgv_provincias;
        private System.Windows.Forms.ImageList imageList2;
    }
}