using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace máy_tính
{
    public partial class bieudo : Form
    {
        bool enter_value = false;
        int solan;
        int solan1 = 0;
        int[] donvi = new int[10];
        int abc = 0;
        bool so1=true;
        Bitmap bitmap;
        OpenFileDialog open;
        public bieudo()
        {
            InitializeComponent();
            chart1.Series.Clear();
            textBox2.Text = "0";
            button7.Enabled = false;
            button7.Visible = false;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text != "0" && abc == 0&&so1 == true)
                {
                  solan = Convert.ToInt16(textBox2.Text);
                  abc +=1;
                }
                if(textBox2.Text == "0")
                {
                   abc = 0 ;
                }
            if (abc == 1 && solan1-1 < solan && so1 == true)
            {
                
                label2.Text = "Đơn vị " + (solan1+1).ToString();
                
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập giá trị đơn vị", "Chưa nhập giá trị đơn vị!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (solan1 != solan && textBox2.Text != "0" )
                {
                    donvi[solan1] = Convert.ToInt16(textBox2.Text);
                    
                    solan1 += 1;
                }
            }
            if (solan1 == solan )
            {
                button7.Enabled = true;
                button7.Visible = true;

            }

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox2.Text == "0") || (enter_value))
                textBox2.Text = "";
            enter_value = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textBox2.Text.Contains("."))
                {
                    textBox2.Text = textBox2.Text + num.Text;
                }
            }
            else
                textBox2.Text = textBox2.Text + num.Text;
            if (Convert.ToDouble(textBox2.Text)>10 && abc ==0)
            {
                    MessageBox.Show("Giá trị tối đa là 10,bạn đã nhập quá mức cho phép", "Dữ liệu nhập vào quá mức cho phép", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                if (textBox2.Text == "")
                {
                    textBox2.Text = "0"; // resert về số 0
                }
            }
        }

        private void CE_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1, 1); // xóa 1 số
            if(textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Width = 1061;
            if (textBox3.Text != "")
            {
                this.chart1.Series.Add(textBox3.Text).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            }
            else{
                this.chart1.Series.Add("Đơn vị").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            }
            if (textBox3.Text != "")
            {
                for (int i = 0; i <= solan - 1; i++)
                {
                    this.chart1.Series[textBox3.Text].Points.AddXY(textBox3.Text + (i + 1).ToString(), donvi[i]);
                }
            }
            else
            {
                for (int i = 1; i <= solan - 1; i++)
                {
                    this.chart1.Series["Đơn vị"].Points.AddXY((i + 1).ToString(), donvi[i]);
                    
                }
            }
            chart1.Titles.Add(textBox1.Text);
        }

        private void BiêuĐôHinhTronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Series[textBox3.Text].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }

        private void biêuĐôĐươngThăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Series[textBox3.Text].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void biêuĐôArenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Series[textBox3.Text].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
        }

        private void change(object sender, EventArgs e)
        {
            int n1;
            so1 = true;
            if (int.TryParse(this.textBox2.Text, out n1))
            {

            }
            else
            {
                MessageBox.Show("Dữ liệu bạn nhập vào chỉ có thể là số", "Dữ liệu nhập vào không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                so1 = false;
            }
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
    }

}
