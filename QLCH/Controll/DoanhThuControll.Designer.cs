namespace QLCH.Controll
{
    partial class DoanhThuControll
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rdToday = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdThisWeek = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdThisYear = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(471, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doanh thu cửa hàng";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.btnThongKe);
            this.guna2GroupBox1.Controls.Add(this.rdThisYear);
            this.guna2GroupBox1.Controls.Add(this.rdThisWeek);
            this.guna2GroupBox1.Controls.Add(this.rdToday);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(19, 66);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(596, 133);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.Text = "Thống kê doanh thu";
            // 
            // rdToday
            // 
            this.rdToday.AutoSize = true;
            this.rdToday.BackColor = System.Drawing.Color.Transparent;
            this.rdToday.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdToday.CheckedState.BorderThickness = 0;
            this.rdToday.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdToday.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdToday.CheckedState.InnerOffset = -4;
            this.rdToday.Location = new System.Drawing.Point(27, 76);
            this.rdToday.Name = "rdToday";
            this.rdToday.Size = new System.Drawing.Size(90, 24);
            this.rdToday.TabIndex = 0;
            this.rdToday.Text = "Hôm nay";
            this.rdToday.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdToday.UncheckedState.BorderThickness = 2;
            this.rdToday.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdToday.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdToday.UseVisualStyleBackColor = false;
            // 
            // rdThisWeek
            // 
            this.rdThisWeek.AutoSize = true;
            this.rdThisWeek.BackColor = System.Drawing.Color.Transparent;
            this.rdThisWeek.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdThisWeek.CheckedState.BorderThickness = 0;
            this.rdThisWeek.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdThisWeek.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdThisWeek.CheckedState.InnerOffset = -4;
            this.rdThisWeek.Location = new System.Drawing.Point(170, 76);
            this.rdThisWeek.Name = "rdThisWeek";
            this.rdThisWeek.Size = new System.Drawing.Size(89, 24);
            this.rdThisWeek.TabIndex = 1;
            this.rdThisWeek.Text = "Tuần nay";
            this.rdThisWeek.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdThisWeek.UncheckedState.BorderThickness = 2;
            this.rdThisWeek.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdThisWeek.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdThisWeek.UseVisualStyleBackColor = false;
            // 
            // rdThisYear
            // 
            this.rdThisYear.AutoSize = true;
            this.rdThisYear.BackColor = System.Drawing.Color.Transparent;
            this.rdThisYear.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdThisYear.CheckedState.BorderThickness = 0;
            this.rdThisYear.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdThisYear.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdThisYear.CheckedState.InnerOffset = -4;
            this.rdThisYear.Location = new System.Drawing.Point(301, 76);
            this.rdThisYear.Name = "rdThisYear";
            this.rdThisYear.Size = new System.Drawing.Size(89, 24);
            this.rdThisYear.TabIndex = 2;
            this.rdThisYear.Text = "Năm nay";
            this.rdThisYear.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdThisYear.UncheckedState.BorderThickness = 2;
            this.rdThisYear.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdThisYear.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdThisYear.UseVisualStyleBackColor = false;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BorderColor = System.Drawing.Color.White;
            this.btnThongKe.BorderRadius = 6;
            this.btnThongKe.BorderThickness = 1;
            this.btnThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongKe.FillColor = System.Drawing.Color.DarkOrange;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThongKe.ForeColor = System.Drawing.Color.Gray;
            this.btnThongKe.Location = new System.Drawing.Point(430, 65);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(147, 45);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thông kê";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(621, 66);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Legend = "Legend1";
            series1.Name = "DoanhThu";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(788, 280);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(19, 262);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(596, 445);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(621, 444);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(788, 263);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(835, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Top sản phẩm bán chạy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(126, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Top nhân viên đạt KPI";
            // 
            // DoanhThuControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.label1);
            this.Name = "DoanhThuControll";
            this.Size = new System.Drawing.Size(1427, 720);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button btnThongKe;
        private Guna.UI2.WinForms.Guna2RadioButton rdThisYear;
        private Guna.UI2.WinForms.Guna2RadioButton rdThisWeek;
        private Guna.UI2.WinForms.Guna2RadioButton rdToday;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
