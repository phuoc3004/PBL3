namespace QLCH.Controller
{
    partial class HomePageManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageManager));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.guna2GradientPanel4 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2CircleProgressBar3 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.guna2CircleProgressBar3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel4
            // 
            this.guna2GradientPanel4.BorderRadius = 10;
            this.guna2GradientPanel4.BorderThickness = 1;
            this.guna2GradientPanel4.Controls.Add(this.pictureBox4);
            this.guna2GradientPanel4.Controls.Add(this.label7);
            this.guna2GradientPanel4.Controls.Add(this.label8);
            this.guna2GradientPanel4.FillColor = System.Drawing.Color.Aqua;
            this.guna2GradientPanel4.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel4.Location = new System.Drawing.Point(1008, 63);
            this.guna2GradientPanel4.Name = "guna2GradientPanel4";
            this.guna2GradientPanel4.Size = new System.Drawing.Size(348, 135);
            this.guna2GradientPanel4.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(13, 36);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(83, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "10H 45M";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(83, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "AVG Reply time";
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(24, 542);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(840, 275);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // guna2CircleProgressBar3
            // 
            this.guna2CircleProgressBar3.Animated = true;
            this.guna2CircleProgressBar3.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleProgressBar3.Controls.Add(this.label5);
            this.guna2CircleProgressBar3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2CircleProgressBar3.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CircleProgressBar3.ForeColor = System.Drawing.Color.Tomato;
            this.guna2CircleProgressBar3.Location = new System.Drawing.Point(1100, 542);
            this.guna2CircleProgressBar3.Minimum = 0;
            this.guna2CircleProgressBar3.Name = "guna2CircleProgressBar3";
            this.guna2CircleProgressBar3.ProgressColor = System.Drawing.Color.Navy;
            this.guna2CircleProgressBar3.ProgressColor2 = System.Drawing.Color.Red;
            this.guna2CircleProgressBar3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar3.Size = new System.Drawing.Size(181, 181);
            this.guna2CircleProgressBar3.TabIndex = 7;
            this.guna2CircleProgressBar3.Text = "guna2CircleProgressBar3";
            this.guna2CircleProgressBar3.Value = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 43);
            this.label5.TabIndex = 0;
            this.label5.Text = "85%";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(36, 94);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(579, 455);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.guna2PictureBox1.TabIndex = 8;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(994, 503);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(8, 8);
            this.guna2CirclePictureBox1.TabIndex = 9;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Location = new System.Drawing.Point(1132, 760);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Doanh thu tăng";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.MediumOrchid;
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2Panel3.BorderRadius = 8;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.label10);
            this.guna2Panel3.Location = new System.Drawing.Point(1008, 437);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(348, 74);
            this.guna2Panel3.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(37, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(253, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Khách hàng là thượng đế";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Gold;
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2Panel2.BorderRadius = 8;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.label6);
            this.guna2Panel2.Location = new System.Drawing.Point(1008, 337);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(348, 74);
            this.guna2Panel2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(15, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cam kết sản phẩm chính hãng";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Tomato;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2Panel1.BorderRadius = 8;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.label9);
            this.guna2Panel1.Location = new System.Drawing.Point(1008, 238);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(348, 70);
            this.guna2Panel1.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(37, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Uy tín tạo nên thương hiệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(571, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 50);
            this.label1.TabIndex = 14;
            this.label1.Text = "Trang chủ quản lý";
            // 
            // HomePageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2CircleProgressBar3);
            this.Controls.Add(this.guna2GradientPanel4);
            this.Name = "HomePageManager";
            this.Size = new System.Drawing.Size(1413, 820);
            this.guna2GradientPanel4.ResumeLayout(false);
            this.guna2GradientPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.guna2CircleProgressBar3.ResumeLayout(false);
            this.guna2CircleProgressBar3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar3;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
    }
}
