﻿namespace diseño_proyectoallphone2
{
    partial class DashBoard
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Estadisticas = new System.Windows.Forms.Button();
            this.btn_MovimientosCaja = new System.Windows.Forms.Button();
            this.btn_GestionarStock = new System.Windows.Forms.Button();
            this.btn_CargarCliente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Contenedor = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Lbl_Dashboard = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Ventas = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel_Contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(191)))), ((int)(((byte)(236)))));
            this.panel1.Controls.Add(this.btn_Estadisticas);
            this.panel1.Controls.Add(this.btn_MovimientosCaja);
            this.panel1.Controls.Add(this.btn_GestionarStock);
            this.panel1.Controls.Add(this.btn_CargarCliente);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 450);
            this.panel1.TabIndex = 0;
            // 
            // btn_Estadisticas
            // 
            this.btn_Estadisticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Estadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Estadisticas.FlatAppearance.BorderSize = 0;
            this.btn_Estadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Estadisticas.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Estadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Estadisticas.Location = new System.Drawing.Point(0, 217);
            this.btn_Estadisticas.Name = "btn_Estadisticas";
            this.btn_Estadisticas.Size = new System.Drawing.Size(181, 40);
            this.btn_Estadisticas.TabIndex = 5;
            this.btn_Estadisticas.Text = "Estadisticas";
            this.btn_Estadisticas.UseVisualStyleBackColor = true;
            this.btn_Estadisticas.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_MovimientosCaja
            // 
            this.btn_MovimientosCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MovimientosCaja.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_MovimientosCaja.FlatAppearance.BorderSize = 0;
            this.btn_MovimientosCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MovimientosCaja.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MovimientosCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MovimientosCaja.Location = new System.Drawing.Point(0, 177);
            this.btn_MovimientosCaja.Name = "btn_MovimientosCaja";
            this.btn_MovimientosCaja.Size = new System.Drawing.Size(181, 40);
            this.btn_MovimientosCaja.TabIndex = 3;
            this.btn_MovimientosCaja.Text = "Movimientos Caja";
            this.btn_MovimientosCaja.UseVisualStyleBackColor = true;
            this.btn_MovimientosCaja.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_GestionarStock
            // 
            this.btn_GestionarStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GestionarStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_GestionarStock.FlatAppearance.BorderSize = 0;
            this.btn_GestionarStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GestionarStock.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GestionarStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GestionarStock.Location = new System.Drawing.Point(0, 137);
            this.btn_GestionarStock.Name = "btn_GestionarStock";
            this.btn_GestionarStock.Size = new System.Drawing.Size(181, 40);
            this.btn_GestionarStock.TabIndex = 2;
            this.btn_GestionarStock.Text = "Gestionar Stock";
            this.btn_GestionarStock.UseVisualStyleBackColor = true;
            this.btn_GestionarStock.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_CargarCliente
            // 
            this.btn_CargarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CargarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_CargarCliente.FlatAppearance.BorderSize = 0;
            this.btn_CargarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(114)))), ((int)(((byte)(141)))));
            this.btn_CargarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CargarCliente.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CargarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CargarCliente.Location = new System.Drawing.Point(0, 97);
            this.btn_CargarCliente.Name = "btn_CargarCliente";
            this.btn_CargarCliente.Size = new System.Drawing.Size(181, 40);
            this.btn_CargarCliente.TabIndex = 1;
            this.btn_CargarCliente.Text = "Cargar Cliente";
            this.btn_CargarCliente.UseVisualStyleBackColor = true;
            this.btn_CargarCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::diseño_proyectoallphone2.Properties.Resources.WhatsApp_Image_2024_10_04_at_21_03_11;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(191)))), ((int)(((byte)(236)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(181, 427);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(619, 23);
            this.panel3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(573, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "12:33";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(522, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "1-03-24";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desconectada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base de datos: ";
            // 
            // panel_Contenedor
            // 
            this.panel_Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.panel_Contenedor.Controls.Add(this.chart1);
            this.panel_Contenedor.Controls.Add(this.button6);
            this.panel_Contenedor.Controls.Add(this.button5);
            this.panel_Contenedor.Controls.Add(this.Lbl_Dashboard);
            this.panel_Contenedor.Controls.Add(this.label11);
            this.panel_Contenedor.Controls.Add(this.label10);
            this.panel_Contenedor.Controls.Add(this.label9);
            this.panel_Contenedor.Controls.Add(this.label8);
            this.panel_Contenedor.Controls.Add(this.label7);
            this.panel_Contenedor.Controls.Add(this.panel9);
            this.panel_Contenedor.Controls.Add(this.panel8);
            this.panel_Contenedor.Controls.Add(this.panel7);
            this.panel_Contenedor.Controls.Add(this.panel6);
            this.panel_Contenedor.Controls.Add(this.panel5);
            this.panel_Contenedor.Controls.Add(this.label6);
            this.panel_Contenedor.Controls.Add(this.lbl_Ventas);
            this.panel_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Contenedor.Location = new System.Drawing.Point(181, 0);
            this.panel_Contenedor.Name = "panel_Contenedor";
            this.panel_Contenedor.Size = new System.Drawing.Size(619, 450);
            this.panel_Contenedor.TabIndex = 3;
            this.panel_Contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            this.panel_Contenedor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(288, 97);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(85)))), ((int)(((byte)(141))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(146)))), ((int)(((byte)(213))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(201)))), ((int)(((byte)(239))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(218)))), ((int)(((byte)(216))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(234)))), ((int)(((byte)(233)))))};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "grafico_dashboard";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 276);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(525, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(47, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(569, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Lbl_Dashboard
            // 
            this.Lbl_Dashboard.AutoSize = true;
            this.Lbl_Dashboard.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Dashboard.Font = new System.Drawing.Font("Nirmala UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Dashboard.Location = new System.Drawing.Point(26, 0);
            this.Lbl_Dashboard.Name = "Lbl_Dashboard";
            this.Lbl_Dashboard.Size = new System.Drawing.Size(272, 54);
            this.Lbl_Dashboard.TabIndex = 12;
            this.Lbl_Dashboard.Text = "DASHBOARD";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(218)))), ((int)(((byte)(216)))));
            this.panel9.Location = new System.Drawing.Point(35, 269);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(14, 16);
            this.panel9.TabIndex = 5;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(234)))), ((int)(((byte)(233)))));
            this.panel8.Location = new System.Drawing.Point(35, 304);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(14, 16);
            this.panel8.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(146)))), ((int)(((byte)(213)))));
            this.panel7.Location = new System.Drawing.Point(35, 191);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(14, 16);
            this.panel7.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(201)))), ((int)(((byte)(239)))));
            this.panel6.Location = new System.Drawing.Point(35, 232);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(14, 16);
            this.panel6.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(83)))), ((int)(((byte)(138)))));
            this.panel5.Location = new System.Drawing.Point(35, 151);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(14, 16);
            this.panel5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total de ventas de este mes por producto";
            // 
            // lbl_Ventas
            // 
            this.lbl_Ventas.AutoSize = true;
            this.lbl_Ventas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ventas.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ventas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(146)))), ((int)(((byte)(213)))));
            this.lbl_Ventas.Location = new System.Drawing.Point(27, 58);
            this.lbl_Ventas.Name = "lbl_Ventas";
            this.lbl_Ventas.Size = new System.Drawing.Size(129, 47);
            this.lbl_Ventas.TabIndex = 2;
            this.lbl_Ventas.Text = "Ventas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Total de ventas de este mes por producto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Total de ventas de este mes por producto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(55, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(218, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Total de ventas de este mes por producto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(55, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(218, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Total de ventas de este mes por producto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(55, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(218, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Total de ventas de este mes por producto";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_Contenedor);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_Contenedor.ResumeLayout(false);
            this.panel_Contenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_Contenedor;
        private System.Windows.Forms.Button btn_CargarCliente;
        private System.Windows.Forms.Button btn_MovimientosCaja;
        private System.Windows.Forms.Button btn_GestionarStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Ventas;
        private System.Windows.Forms.Label Lbl_Dashboard;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btn_Estadisticas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

