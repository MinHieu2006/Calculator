using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace máy_tính
{
    public partial class Form1 : Form
    {
        Double results = 0;
        Double ket_qua = 1;
        String operation = "";
        bool enter_value = false;
        bool so = true;
        bool s = true;
        bool so1 = true;
        double m;
        string tr;
        string am;
        int n = 0;
        int n1 = 0;
        Bitmap bitmap;
        double Fibonacci(double n)
        {
            if (n == 1 || n == 2) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        public Form1()
        {
            InitializeComponent();
            Result.Enabled = false;
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            label1.Visible = false;
            label1.Enabled = false;
            label2.Visible = false;
            label2.Enabled = false;
            ok1.Enabled = false; ;
            ok1.Visible = false;
            ok2.Visible = false;
            ok2.Enabled = false;
            label3.Visible = false;
            label3.Enabled = false;
            button3.Visible = false;
            button3.Enabled = false;
            panel1.Visible = false;
        }
        OpenFileDialog open;
        private void standarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 321; // set form
            Result.Width = 281; //set result

        }

        private void sôKhoaHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 695; //mở rộng form
            Result.Width = 662; // mở rộng result
        }



        private void button_click(object sender, EventArgs e) // click number and .
        {
            if ((Result.Text == "0") || (enter_value))
                Result.Text = "";
            enter_value = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!Result.Text.Contains("."))
                {
                    Result.Text = Result.Text + num.Text;
                }
            }
            else
                Result.Text = Result.Text + num.Text;
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (Result.Text.Length > 0)
            {
                Result.Text = Result.Text.Remove(Result.Text.Length - 1, 1); // xóa 1 số
            }
            if (Result.Text == "")
            {
                Result.Text = "0"; // resert về số 0
            }
        }

        private void CE_Click(object sender, EventArgs e) // xóa hết
        {
            Result.Text = "0";
            lblshowup.Text = "";
        }

        private void pi_Click(object sender, EventArgs e) // click số pi
        {
            Result.Text = "3.14159265359";
        }

        private void Log_Click(object sender, EventArgs e)
        {
            Double ilog = Double.Parse(Result.Text);
            ilog = Math.Log10(ilog);
            lblshowup.Text = System.Convert.ToString("log" + "(" + Result.Text + ")");
            Result.Text = System.Convert.ToString(ilog);

        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            Double sq = Double.Parse(Result.Text);
            if (sq < 0)
            {
                Result.Text = "Số nhập ko hợp lệ";
            }
            if (sq >= 0)
            {
                sq = Math.Sqrt(sq);
                lblshowup.Text = System.Convert.ToString("sqrt" + "(" + Result.Text + ")");
                Result.Text = System.Convert.ToString(sq);
            }
        }

        private void Sinh_Click(object sender, EventArgs e)
        {
            Double Sinh = Double.Parse(Result.Text);
            Sinh = Math.Sinh(Sinh);
            lblshowup.Text = System.Convert.ToString("sinh" + "(" + Result.Text + ")");
            Result.Text = System.Convert.ToString(Sinh);
        }

        private void Sin_Click(object sender, EventArgs e)
        {
            Double Sin = Double.Parse(Result.Text);
            Sin = Math.Sin(Sin);
            lblshowup.Text = System.Convert.ToString("sin" + "(" + Result.Text + ")");
            Result.Text = System.Convert.ToString(Sin);
        }

        private void Cosh_Click(object sender, EventArgs e)
        {
            Double Cosh = Double.Parse(Result.Text);
            Cosh = Math.Cosh(Cosh);
            lblshowup.Text = System.Convert.ToString("cosh" + "(" + Result.Text + ")");
            Result.Text = System.Convert.ToString(Cosh);
        }

        private void Cos_Click(object sender, EventArgs e)
        {
            Double Cos = Double.Parse(Result.Text);
            Cos = Math.Cos(Cos);
            lblshowup.Text = System.Convert.ToString("cos" + "(" + Result.Text + ")");
            Result.Text = System.Convert.ToString(Cos);
        }

        private void Tanh_Click(object sender, EventArgs e)
        {
            Double tanh = Double.Parse(Result.Text);
            tanh = Math.Log10(tanh);
            lblshowup.Text = System.Convert.ToString("tanh" + "(" + Result.Text + ")");
            Result.Text = System.Convert.ToString(tanh);
        }

        private void Tan_Click(object sender, EventArgs e)
        {
            Double tan = Double.Parse(Result.Text);
            tan = Math.Tan(tan);
            lblshowup.Text = System.Convert.ToString("tan" + "(" + Result.Text + ")");
            Result.Text = System.Convert.ToString(tan);
        }

        private void Bin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(Result.Text);
            Result.Text = System.Convert.ToString(a, 2);
        }

        private void Hex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(Result.Text);
            Result.Text = System.Convert.ToString(a, 16);
        }

        private void Oct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(Result.Text);
            Result.Text = System.Convert.ToString(a, 8);
        }

        private void Dec_Click(object sender, EventArgs e)
        {
            int a = int.Parse(Result.Text);
            Result.Text = System.Convert.ToString(a);
        }

        private void binh_phuong_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(Result.Text) * Convert.ToDouble(Result.Text);
            Result.Text = System.Convert.ToString(a);
        }

        private void chia_x_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0) / Convert.ToDouble(Result.Text);
            Result.Text = System.Convert.ToString(a);
        }

        private void ln_x_Click(object sender, EventArgs e)
        {
            Double ilog = Double.Parse(Result.Text);
            ilog = Math.Log(ilog);
            lblshowup.Text = System.Convert.ToString("log" + "(" + Result.Text + ")");
            Result.Text = System.Convert.ToString(ilog);
        }

        private void phan_tram_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(Result.Text) / Convert.ToDouble(100);
            Result.Text = System.Convert.ToString(a);
        }

        private void tri_tuyet_doi_Click(object sender, EventArgs e)
        {
            Double abs = Double.Parse(Result.Text);
            abs = Math.Abs(abs);
            lblshowup.Text = System.Convert.ToString("abs" + "|" + Result.Text + "|");
            Result.Text = System.Convert.ToString(abs);
        }

        private void giaiPhươngTrinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_pt eqs = new form_pt();
            eqs.Show();
        }

        private void mu_Click(object sender, EventArgs e)
        {
            for (int abc = 1; abc <= Convert.ToInt32(Result.Text); abc++)
            {
                ket_qua = results * ket_qua;
            }
            Result.Text = System.Convert.ToString(ket_qua);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            lblshowup.Text = "";
            switch (operation)
            {
                case "+":
                    Result.Text = (results + Double.Parse(Result.Text)).ToString();
                    break;
                case "-":
                    Result.Text = (results - Double.Parse(Result.Text)).ToString();
                    break;
                case "*":
                    Result.Text = (results * Double.Parse(Result.Text)).ToString();
                    break;
                case "/":
                    if (Double.Parse(Result.Text) == 0)
                    {
                        Result.Text = "Số chia không thể nào bằng 0";
                    }
                    if (Double.Parse(Result.Text) != 0)
                    {
                        Result.Text = (results / Double.Parse(Result.Text)).ToString();
                    }
                    break;
                case "Mod":
                    Result.Text = (results % Double.Parse(Result.Text)).ToString();
                    break;
                case "Exp":
                    double i = Double.Parse(Result.Text);
                    double q;
                    q = (results);
                    Result.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;
                case "^":
                    ket_qua = results;
                    for (int abc = 2; abc <= Convert.ToDouble(Result.Text); abc++)
                    {
                        ket_qua = ket_qua * results;
                    }
                    Result.Text = ket_qua.ToString();
                    break;
                case "Ước chung lớn nhất":
                    Double a1 = results;
                    Double b1 = Convert.ToDouble(Result.Text);
                    while (a1 != b1)
                    {
                        if (a1 > b1)
                        {
                            a1 = a1 - b1;
                        }
                        if (b1 > a1)
                        {
                            b1 = b1 - a1;
                        }
                    }
                    Result.Text = a1.ToString();
                    break;
                case "Bội chung nhỏ nhất":
                    Double a2 = results;
                    Double b2 = Convert.ToDouble(Result.Text);
                    Double a3 = a2;
                    Double b3 = b2;
                    while (a2 != b2)
                    {
                        if (a2 > b2)
                        {
                            a2 = a2 - b2;
                        }
                        if (b2 > a2)
                        {
                            b2 = b2 - a2;
                        }
                    }
                    Result.Text = ((a3 * b3) / a2).ToString();
                    break;
                case "Phân tích ra thừa số nguyên tố":

                    break;
            }
        }

        private void Arithemetic_operator(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(Result.Text);
            Result.Text = "";
            lblshowup.Text = System.Convert.ToString(results) + " " + operation;
            if (operation == "Ước chung lớn nhất")
            {
                lblshowup.Text = "UCLN( " + System.Convert.ToString(results) + ", )";
            }
            if (operation == "Bội chung nhỏ nhất")
            {
                lblshowup.Text = "BCNN( " + System.Convert.ToString(results) + ", )";
            }
        }

        private void dau_am_Click(object sender, EventArgs e)
        {

            string _temp = Result.Text;

            //Nếu đang là âm thì xóa
            if (_temp[0] == '-')
            {
                _temp = _temp.Remove(0, 1);
            }
            else //Đang ko có dấu thì thêm dấu âm
            {
                _temp = "-" + _temp;
            }

            Result.Text = _temp;
        }

        private void đôiĐơnViToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_units eqt = new change_units();
            eqt.Show();
        }



        private void form1_press(object sender, KeyPressEventArgs e)
        {
            if (s)
            {
                switch (e.KeyChar)
                {
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        Result.Text += e.KeyChar;
                        break;
                }
            }
        }

        private void veBiêuĐôToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bieudo eq = new bieudo();
            eq.Show();
        }

        private void môtSôTinhNăngKhacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1100;
        }



        private void button3_Click(object sender, EventArgs e)
        {

            bool b = true;
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu", "Chưa nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                b = false;
            }
            if (Convert.ToDouble(textBox1.Text) == 0 || Convert.ToDouble(textBox2.Text) == 0)
            {
                MessageBox.Show("Dữ liệu bạn nhập vào phải khác 0", "Dữ liệu ko hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                b = false;
            }
            if (n == 2 || n == 3 || n == 4 || n == 1)
            {
                if (textBox1.Text != "" || textBox2.Text != "")
                {
                    b = true;
                }
                if (so == true && b == true)
                {
                    Int64 a12 = Convert.ToInt64(textBox1.Text);
                    Int64 c12 = Convert.ToInt64(textBox2.Text);
                    int a13 = 0;
                    int c13 = 0;
                    for (int i = 1; i < a12; i++)
                    {
                        if (a12 % i == 0)
                        {
                            a13 += i;
                        }
                    }
                    for (int g = 1; g < c12; g++)
                    {
                        if (c12 % g == 0)
                        {
                            c13 += g;
                        }
                    }
                    if (n == 2)
                    {
                        if (a13 == c12 && a12 == c13)
                        {
                            m = 3;
                        }
                        else m = 4;
                    }
                    if (n == 3)
                    {
                        if (a13 - 1 == c12 && c13 - 1 == a12)
                        {
                            m = 5;
                        }
                        else m = 6;
                    }
                    if (n == 4)
                    {
                        if (a13 == a12)
                        {
                            tr = "Số " + a13.ToString() + " là số hoàn hảo. ";
                            m = 7;
                        }
                        else
                        {
                            tr = "Số " + a13.ToString() + " không phải là số hoàn hảo.";
                        }
                        if (c13 == c12)
                        {
                            am = "Số " + a13.ToString() + " là số hoàn hảo. ";
                            m = 7;
                        }
                    }

                }


                if (m == 3)
                {
                    MessageBox.Show("Đây là cặp số thân thiết", "Kiểm tra 2 số có phải là cặp số thân thiết không ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (m == 4)
                {
                    MessageBox.Show("Đây không phải là cặp số thân thiết", "Kiểm tra 2 số có phải là cặp số thân thiết không ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (m == 5)
                {
                    MessageBox.Show("Đây  là cặp số hứa hôn", "Kiểm tra 2 số có phải là cặp số hứa hôn không ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (m == 6)
                {
                    MessageBox.Show("Đây không phải là cặp số hứa hôn", "Kiểm tra 2 số có phải là cặp số hứa hôn không ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (m == 7)
                {
                    MessageBox.Show(am + tr, "Kiểm tra số có phải là số hoản hảo không ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void textBox1_change(object sender, EventArgs e)
        {
            int n = 0;
            if (int.TryParse(this.textBox1.Text, out n))
            {
                so = true;
            }
            else
            {
                MessageBox.Show("Dữ liệu bạn nhập vào chỉ có thể là số", "Dữ liệu nhập vào không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                so = false;
            }

        }

        private void textBox2_change(object sender, EventArgs e)
        {
            int n = 0;
            if (int.TryParse(this.textBox2.Text, out n))
            {

            }
            else
            {
                MessageBox.Show("Dữ liệu bạn nhập vào chỉ có thể là số", "Dữ liệu nhập vào không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                so = false;
            }
        }

        private void ok1_Click(object sender, EventArgs e)
        {
            s = true;
            textBox1.Enabled = false;
        }

        private void ok2_Click(object sender, EventArgs e)
        {
            s = true;
            textBox2.Enabled = false;
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            label3.Text = "Kiểm tra có phải là cặp số thân thiết không";
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            label1.Visible = true;
            label1.Enabled = true;
            label2.Visible = true;
            label2.Enabled = true;
            ok1.Enabled = true;
            ok1.Visible = true;
            ok2.Visible = true;
            ok2.Enabled = true;
           
            panel6.Visible = true;
            label3.Visible = true;
            label3.Enabled = true;
            button3.Visible = true;
            button3.Enabled = true;
            n = 2;
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            label3.Text = "Kiểm tra có phải lầ cặp số hứa hôn không";
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            label1.Visible = true;
            label1.Enabled = true;
            label2.Visible = true;
            label2.Enabled = true;
            ok1.Enabled = true;
            ok1.Visible = true;
            ok2.Visible = true;
            ok2.Enabled = true;
            panel6.Visible = true;

            
            label3.Visible = true;
            label3.Enabled = true;
            button3.Visible = true;
            button3.Enabled = true;
            n = 3;
        }
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            label3.Text = "Kiểm tra có phải là số hoàn hảo không";
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox1.Enabled = true;
            textBox2.Visible = true;
            textBox2.Enabled = true;
            label1.Visible = true;
            label1.Enabled = true;
            label2.Visible = true;
            label2.Enabled = true;
            ok1.Enabled = true;
            ok1.Visible = true;
            ok2.Visible = true;
            ok2.Enabled = true;
            panel6.Visible = true;

            
            label3.Visible = true;
            label3.Enabled = true;
            button3.Visible = true;
            button3.Enabled = true;
            n = 4;
        }
        
        private void thêmAnhNênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                bitmap = new Bitmap(open.FileName);
                this.BackgroundImage = bitmap;
            }
        }

        private void fontChưToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (int.TryParse(this.textBox4.Text, out n))
            {

            }
            else
            {
                MessageBox.Show("Dữ liệu bạn nhập vào chỉ có thể là số", "Dữ liệu nhập vào không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                so1 = false;
            }
            int n1 = 0;
            if (int.TryParse(this.textBox5.Text, out n1))
            {

            }
            else
            {
                MessageBox.Show("Dữ liệu bạn nhập vào chỉ có thể là số", "Dữ liệu nhập vào không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                so1 = false;
            }
            if (so1 == true && n1 == 1)
            {
                double sum = Convert.ToDouble(textBox4.Text) * 0.5;
                sum *= Convert.ToDouble(textBox5.Text);
                MessageBox.Show("Diện tích tam giác là " + sum.ToString(), "Tính diện tích tam giác", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            so1 = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            int n = 0;
            if (int.TryParse(this.textBox6.Text, out n))
            {

            }
            else
            {
                MessageBox.Show("Dữ liệu bạn nhập vào chỉ có thể là số", "Dữ liệu nhập vào không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                so1 = false;

            }
            n = 0;
            if (int.TryParse(this.textBox7.Text, out n))
            {

            }
            else
            {
                MessageBox.Show("Dữ liệu bạn nhập vào chỉ có thể là số", "Dữ liệu nhập vào không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                so1 = false;
            }
            n = 0;
            if (int.TryParse(this.textBox8.Text, out n))
            {

            }
            else
            {
                MessageBox.Show("Dữ liệu bạn nhập vào chỉ có thể là số", "Dữ liệu nhập vào không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                so1 = false;
            }
            if (so1 == true && n1 == 1)
            {
                double a = Convert.ToDouble(textBox6.Text);
                double b = Convert.ToDouble(textBox7.Text);
                double c = Convert.ToDouble(textBox8.Text);
                double p = (a + b + c) / 2;
                double sum = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                MessageBox.Show("Diện tích tam giác là " + sum.ToString(), "Tính diện tích tam giác", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (so1 == true && n1 == 2)
            {
                double a = Convert.ToDouble(textBox6.Text);
                double b = Convert.ToDouble(textBox7.Text);
                double c = Convert.ToDouble(textBox8.Text);
                double sum = a + b + c;
                MessageBox.Show("Chu vi tam giác là " + sum.ToString(), "Tính chu vi tam giác", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (so1 == true && n1 == 3)
            {
                double a = Convert.ToDouble(textBox6.Text);
                double sum = a * a;
                MessageBox.Show("Diện tích hình vuông là " + sum.ToString(), "Tính diện tích hình vuông", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (so1 == true && n1 == 4)
            {
                double a = Convert.ToDouble(textBox6.Text);
                double sum = a * 4;
                MessageBox.Show("Chu vi hình vuông là " + sum.ToString(), "Tính chu vi hình vuông", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (so1 == true && n1 == 5)
            {
                double a = Convert.ToDouble(textBox6.Text);
                double b = Convert.ToDouble(textBox7.Text);
                double sum = a * b;
                MessageBox.Show("Diện tích hình chữ nhật là " + sum.ToString(), "Tính diện tích hình chữ nhật", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (so1 == true && n1 == 6)
            {

                double a = Convert.ToDouble(textBox6.Text);
                double b = Convert.ToDouble(textBox7.Text);
                double sum = (a + b) * 2;
                MessageBox.Show("Chu vi hình chữ nhật là " + sum.ToString(), "Tính chu vi hình chữ nhật", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            n1 = 0;
            so1 = true;
        }
        private void diênTichToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            panel1.Visible = true;
            label5.Text = "Cách 2";
            n1 = 1;
        }
        private void chuViToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            label5.Text = "Cách 1";
            n1 = 2;
        }

        private void diênTichToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            label5.Text = "Cách 1";
            n1 = 3;
            panel3.Visible = false;
        }

        private void chuViToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            label5.Text = "Cách 1";
            n1 = 4;
            panel3.Visible = false;
        }

        private void diênTichToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            label5.Text = "Cách 1";
            n1 = 5;
            panel3.Visible = false;
            label9.Visible = true;
            textBox7.Visible = true;
            label8.Text = "Chiều dài của chiều dài";
            label9.Text = "Chiều dài của chiều rộng";
        }

        private void chuViToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            label5.Text = "Cách 1";
            n1 = 6;
            panel3.Visible = false;
            label9.Visible = true;
            textBox7.Visible = true;
            label8.Text = "Chiều dài của cạnh dài";
            label9.Text = "Chiều dài của chiều rộng";
        }

        private void fiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = "Tìm số hạng thứ n trong dãy số Fibonaci";
            label1.Text = "Số hạng thứ n là ";
            
            
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox1.Enabled = true;
            textBox2.Visible = true;
            textBox2.Enabled = true;
            label1.Visible = true;
            label1.Enabled = true;
            label2.Visible = true;
            label2.Enabled = true;
            ok1.Enabled = true;
            ok1.Visible = true;
            ok2.Visible = true;
            ok2.Enabled = true;
            panel6.Visible = false;           
            label3.Visible = true;
            label3.Enabled = true;
            button3.Visible = false;
            button3.Enabled = false;
            
        }
        
        private void ok1_Click_1(object sender, EventArgs e)
        {
            so1 = true;
            if (int.TryParse(this.textBox1.Text, out n1))
            {

            }
            else
            {
                MessageBox.Show("Dữ liệu bạn nhập vào chỉ có thể là số", "Dữ liệu nhập vào không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                so1 = false;
            }
            if(so1 == true)
            {
                MessageBox.Show("Số hạng thứ "+Convert.ToDouble(textBox1.Text).ToString() + " của dãy số Fibonacci là "+Fibonacci(Convert.ToDouble(textBox1.Text)).ToString(), "Tìm số hạng thứ n", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
        

        private void change(object sender, EventArgs e)
        {

            so1 = true;
            if (int.TryParse(this.textBox1.Text, out n1))
            {

            }
            else
            {
                MessageBox.Show("Dữ liệu bạn nhập vào chỉ có thể là số", "Dữ liệu nhập vào không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                so1 = false;
            }
        }
    }
}
