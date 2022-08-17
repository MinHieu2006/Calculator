namespace máy_tính
{
    partial class form_pt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_pt));
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Linear = new System.Windows.Forms.Button();
            this.bt_Quadratic = new System.Windows.Forms.Button();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.label_a = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.label_c = new System.Windows.Forms.Label();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.label_pt = new System.Windows.Forms.Label();
            this.txtBox_Equa = new System.Windows.Forms.TextBox();
            this.bt_Solve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(49, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giải Phương Trình";
            // 
            // bt_Linear
            // 
            this.bt_Linear.Location = new System.Drawing.Point(55, 92);
            this.bt_Linear.Name = "bt_Linear";
            this.bt_Linear.Size = new System.Drawing.Size(75, 23);
            this.bt_Linear.TabIndex = 1;
            this.bt_Linear.Text = "bậc 1";
            this.bt_Linear.UseVisualStyleBackColor = true;
            this.bt_Linear.Click += new System.EventHandler(this.bt_Linear_Click);
            // 
            // bt_Quadratic
            // 
            this.bt_Quadratic.Location = new System.Drawing.Point(205, 92);
            this.bt_Quadratic.Name = "bt_Quadratic";
            this.bt_Quadratic.Size = new System.Drawing.Size(75, 23);
            this.bt_Quadratic.TabIndex = 2;
            this.bt_Quadratic.Text = "bậc 2";
            this.bt_Quadratic.UseVisualStyleBackColor = true;
            this.bt_Quadratic.Click += new System.EventHandler(this.bt_Quadratic_Click);
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(103, 134);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(196, 20);
            this.txt_a.TabIndex = 3;
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Location = new System.Drawing.Point(26, 141);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(42, 13);
            this.label_a.TabIndex = 4;
            this.label_a.Text = "Nhập a";
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Location = new System.Drawing.Point(26, 180);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(42, 13);
            this.label_b.TabIndex = 6;
            this.label_b.Text = "Nhập b";
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(103, 173);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(196, 20);
            this.txt_b.TabIndex = 5;
            // 
            // label_c
            // 
            this.label_c.AutoSize = true;
            this.label_c.Location = new System.Drawing.Point(26, 215);
            this.label_c.Name = "label_c";
            this.label_c.Size = new System.Drawing.Size(42, 13);
            this.label_c.TabIndex = 8;
            this.label_c.Text = "Nhập c";
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(103, 208);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(196, 20);
            this.txt_c.TabIndex = 7;
            // 
            // label_pt
            // 
            this.label_pt.AutoSize = true;
            this.label_pt.Location = new System.Drawing.Point(26, 250);
            this.label_pt.Name = "label_pt";
            this.label_pt.Size = new System.Drawing.Size(71, 13);
            this.label_pt.TabIndex = 9;
            this.label_pt.Text = "Phương Trình";
            // 
            // txtBox_Equa
            // 
            this.txtBox_Equa.Location = new System.Drawing.Point(103, 247);
            this.txtBox_Equa.Name = "txtBox_Equa";
            this.txtBox_Equa.Size = new System.Drawing.Size(196, 20);
            this.txtBox_Equa.TabIndex = 10;
            // 
            // bt_Solve
            // 
            this.bt_Solve.Location = new System.Drawing.Point(29, 282);
            this.bt_Solve.Name = "bt_Solve";
            this.bt_Solve.Size = new System.Drawing.Size(270, 44);
            this.bt_Solve.TabIndex = 11;
            this.bt_Solve.Text = "Giải phương trình";
            this.bt_Solve.UseVisualStyleBackColor = true;
            this.bt_Solve.Click += new System.EventHandler(this.bt_Solve_Click);
            // 
            // form_pt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(329, 338);
            this.Controls.Add(this.bt_Solve);
            this.Controls.Add(this.txtBox_Equa);
            this.Controls.Add(this.label_pt);
            this.Controls.Add(this.label_c);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.bt_Quadratic);
            this.Controls.Add(this.bt_Linear);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_pt";
            this.Text = "Giải phương trình";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Linear;
        private System.Windows.Forms.Button bt_Quadratic;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.Label label_c;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.Label label_pt;
        private System.Windows.Forms.TextBox txtBox_Equa;
        private System.Windows.Forms.Button bt_Solve;
    }
}