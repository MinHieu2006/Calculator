namespace máy_tính
{
    partial class bieudo
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bieudo));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chonLoaiBiêuĐôToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biêuĐôDangCôtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biêuĐôHinhTronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biêuĐôĐươngThăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biêuĐôArenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chinhSưaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmAnhNênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiêu đề: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(209, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập số lượng đơn vị";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(209, 160);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.change);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(203, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vẽ biểu đồ";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(641, 75);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Legend = "Legend1";
            series1.Name = "S";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(405, 368);
            this.chart1.TabIndex = 27;
            this.chart1.Text = "chart1";
            title1.Name = "S1";
            this.chart1.Titles.Add(title1);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(209, 119);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(166, 20);
            this.textBox3.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(12, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Tên đơn vị";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(390, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(390, 79);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 32;
            this.button4.Text = "OK";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(471, 79);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 33;
            this.button5.Text = "Chỉnh sửa";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(471, 119);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 34;
            this.button6.Text = "Chỉnh sửa";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(471, 157);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 35;
            this.button7.Text = "Vẽ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chonLoaiBiêuĐôToolStripMenuItem,
            this.chinhSưaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1045, 24);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chonLoaiBiêuĐôToolStripMenuItem
            // 
            this.chonLoaiBiêuĐôToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biêuĐôDangCôtToolStripMenuItem,
            this.biêuĐôHinhTronToolStripMenuItem,
            this.biêuĐôĐươngThăngToolStripMenuItem,
            this.biêuĐôArenaToolStripMenuItem});
            this.chonLoaiBiêuĐôToolStripMenuItem.Name = "chonLoaiBiêuĐôToolStripMenuItem";
            this.chonLoaiBiêuĐôToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.chonLoaiBiêuĐôToolStripMenuItem.Text = "Chọn loại biểu đồ";
            // 
            // biêuĐôDangCôtToolStripMenuItem
            // 
            this.biêuĐôDangCôtToolStripMenuItem.Name = "biêuĐôDangCôtToolStripMenuItem";
            this.biêuĐôDangCôtToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.biêuĐôDangCôtToolStripMenuItem.Text = "Biều đồ dạng cột";
            // 
            // biêuĐôHinhTronToolStripMenuItem
            // 
            this.biêuĐôHinhTronToolStripMenuItem.Name = "biêuĐôHinhTronToolStripMenuItem";
            this.biêuĐôHinhTronToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.biêuĐôHinhTronToolStripMenuItem.Text = "Biểu đồ hình tròn";
            this.biêuĐôHinhTronToolStripMenuItem.Click += new System.EventHandler(this.BiêuĐôHinhTronToolStripMenuItem_Click);
            // 
            // biêuĐôĐươngThăngToolStripMenuItem
            // 
            this.biêuĐôĐươngThăngToolStripMenuItem.Name = "biêuĐôĐươngThăngToolStripMenuItem";
            this.biêuĐôĐươngThăngToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.biêuĐôĐươngThăngToolStripMenuItem.Text = "Biều đồ đường thẳng";
            this.biêuĐôĐươngThăngToolStripMenuItem.Click += new System.EventHandler(this.biêuĐôĐươngThăngToolStripMenuItem_Click);
            // 
            // biêuĐôArenaToolStripMenuItem
            // 
            this.biêuĐôArenaToolStripMenuItem.Name = "biêuĐôArenaToolStripMenuItem";
            this.biêuĐôArenaToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.biêuĐôArenaToolStripMenuItem.Text = "Biểu đồ arena";
            this.biêuĐôArenaToolStripMenuItem.Click += new System.EventHandler(this.biêuĐôArenaToolStripMenuItem_Click);
            // 
            // chinhSưaToolStripMenuItem
            // 
            this.chinhSưaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmAnhNênToolStripMenuItem});
            this.chinhSưaToolStripMenuItem.Name = "chinhSưaToolStripMenuItem";
            this.chinhSưaToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.chinhSưaToolStripMenuItem.Text = "Chỉnh sửa";
            // 
            // thêmAnhNênToolStripMenuItem
            // 
            this.thêmAnhNênToolStripMenuItem.Name = "thêmAnhNênToolStripMenuItem";
            this.thêmAnhNênToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thêmAnhNênToolStripMenuItem.Text = "Thêm ảnh nền";
            this.thêmAnhNênToolStripMenuItem.Click += new System.EventHandler(this.thêmAnhNênToolStripMenuItem_Click);
            // 
            // bieudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1045, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "bieudo";
            this.Text = "Vẽ Biểu Đồ";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chonLoaiBiêuĐôToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biêuĐôDangCôtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biêuĐôHinhTronToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biêuĐôĐươngThăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biêuĐôArenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chinhSưaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmAnhNênToolStripMenuItem;
    }
}