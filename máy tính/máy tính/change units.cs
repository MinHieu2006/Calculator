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
    public partial class change_units : Form
    {
        Double results = 0;
        Double ket_qua = 1;
        String operation = "";
        bool enter_value = false;
        Double result = 0;
        int avc = 0;
        string n;
        string n1;
        OpenFileDialog open;
        Bitmap bitmap;
        public change_units()
        {
            InitializeComponent();
            this.Width = 572;
            this.Height = 390;
        }
        //Xử lý thể tích
    

        // Xử lý chiều dài
        private void chiêuDaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear(); // Remover all items
            //Add items for combox1 (chiều dài)
            comboBox1.Items.Add("Milimet (mm)");
            comboBox1.Items.Add("Centimet (cm)");
            comboBox1.Items.Add("Decimet (dm)");
            comboBox1.Items.Add("Met (m)");
            comboBox1.Items.Add("Kilomet (km)");
            comboBox1.Items.Add("Inch (in)");
            comboBox1.Items.Add("Feet");
            comboBox1.Items.Add("Yard");
            comboBox1.Items.Add("Dặm");
            comboBox1.Items.Add("Hải lí");
            comboBox1.SelectedItem = "Milimet (mm)";
            //Add items for combox2 (chiều dài)
            comboBox2.Items.Clear(); // Remover all items
            comboBox2.Items.Add("Milimet (mm)");
            comboBox2.Items.Add("Centimet (cm)");
            comboBox2.Items.Add("Decimet (dm)");
            comboBox2.Items.Add("Met (m)");
            comboBox2.Items.Add("Kilomet (km)");
            comboBox2.Items.Add("Inch (in)");
            comboBox2.Items.Add("Feet");
            comboBox2.Items.Add("Yard");
            comboBox2.Items.Add("Dặm");
            comboBox2.Items.Add("Hải lí");
            comboBox2.SelectedItem = "Milimet (mm)";
            // Xử lý ko có nút âm
            dau_am.Enabled = false;
            dau_am.Visible = false;
        }
        //Xừ lý khối lượng
        private void trongLươngVaKhôiLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear(); // Remover all items
            //Add items for combox1 (chiều dài)
            comboBox1.Items.Add("Gam (g)");
            comboBox1.Items.Add("Decagam (dag)");
            comboBox1.Items.Add("Hectogam (hg)");
            comboBox1.Items.Add("Kilogam (kg)");
            comboBox1.Items.Add("Tấn (t)");
            comboBox1.Items.Add("Ounce");
            comboBox1.Items.Add("Pound");
            comboBox1.Items.Add("Hòn đá");
            comboBox1.SelectedItem = "Gam (g)";
            //Add items for combox2 (chiều dài)
            comboBox2.Items.Clear(); // Remover all items
            comboBox2.Items.Add("Gam (g)");
            comboBox2.Items.Add("Decagam (dag)");
            comboBox2.Items.Add("Hectogam (hg)");
            comboBox2.Items.Add("Kilogam (kg)");
            comboBox2.Items.Add("Tấn (t)");
            comboBox2.Items.Add("Ounce");
            comboBox2.Items.Add("Pound");
            comboBox2.Items.Add("Hòn đá");
            comboBox2.SelectedItem = "Gam (g)";
            // Xử lý ko có nút âm
            dau_am.Enabled = false;
            dau_am.Visible = false;
        }
        //Xử lý khối lượng
        private void nhiêtĐôToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear(); // Remover all items
            comboBox1.Items.Add("Độ C");
            comboBox1.Items.Add("Độ F");
            comboBox1.Items.Add("Độ K");
            comboBox2.Items.Clear(); // Remover all items
            comboBox2.Items.Add("Độ C");
            comboBox2.Items.Add("Độ F");
            comboBox2.Items.Add("Độ K");
            // Xử lý ko có nút âm
            dau_am.Enabled = true;
            dau_am.Visible = true;
        }
        //Xừ lý điện thế
        private void điênThêToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Add items for comboBox1
            comboBox1.Items.Clear(); // Remover all items
            comboBox1.Items.Add("Nanovolt (nV)");
            comboBox1.Items.Add("Microvolt (µV)");
            comboBox1.Items.Add("Millivolt (mV)");
            comboBox1.Items.Add("Volt (V)");
            comboBox1.Items.Add("Kilovolt (kV)");
            comboBox1.Items.Add("Megavolt (MV)");
            comboBox1.Items.Add("Gigavolt (GV)");
            comboBox1.SelectedItem = "Volt (V)";
            //Add items for comboBox2
            comboBox2.Items.Clear(); // Remover all items
            comboBox2.Items.Add("Nanovolt (nV)");
            comboBox2.Items.Add("Microvolt (µV)");
            comboBox2.Items.Add("Millivolt (mV)");
            comboBox2.Items.Add("Volt (V)");
            comboBox2.Items.Add("Kilovolt (kV)");
            comboBox2.Items.Add("Megavolt (MV)");
            comboBox2.Items.Add("Gigavolt (GV)");
            comboBox2.SelectedItem = "Volt (V)";
        }
        //Xử lý cường độ dòng điện
        private void cươngĐôDongĐiênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Add items for comboBox1
            comboBox1.Items.Clear(); // Remover all items
            comboBox1.Items.Add("Nanoampe (nA)");
            comboBox1.Items.Add("Microampe (µA)");
            comboBox1.Items.Add("Milliampe (mA)");
            comboBox1.Items.Add("Ampe (A)");
            comboBox1.Items.Add("Kiloampe (kA)");
            comboBox1.Items.Add("Megaampe (MA)");
            comboBox1.Items.Add("Gigaampe (GA)");
            comboBox1.SelectedItem = "Ampe (A)";
            //Add items for comboBox2
            comboBox2.Items.Clear(); // Remover all items
            comboBox2.Items.Add("Nanoampe (nA)");
            comboBox2.Items.Add("Microampe (µA)");
            comboBox2.Items.Add("Milliampe (mA)");
            comboBox2.Items.Add("Ampe (A)");
            comboBox2.Items.Add("Kiloampe (kA)");
            comboBox2.Items.Add("Megaampe (MA)");
            comboBox2.Items.Add("Gigaampe (GA)");
            comboBox2.SelectedItem = "Ampe (A)";
        }
        private void button_click(object sender, EventArgs e)
        {
            if ((label1.Text == "0") || (enter_value))
                label1.Text = "";
            enter_value = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!label1.Text.Contains("."))
                {
                    label1.Text = label1.Text + num.Text;
                }
            }
            else
                label1.Text = label1.Text + num.Text;
            // xử lý giới hạn
            if (label1.Text.Length > 10)
            {
                while (label1.Text.Length > 10)
                {
                    MessageBox.Show("Giá trị tối đa là 10 số,bạn đã nhập quá mức cho phép", "Dữ liệu nhập vào quá mức cho phép", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    label1.Text = label1.Text.Remove(label1.Text.Length - 1, 1); // xóa 1 số
                }
                if (label1.Text == "")
                {
                    label1.Text = "0"; // resert về số 0
                }
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            avc = 1;
            if (comboBox1.Text == "" || comboBox2.Text == "")
            {
                label1.Text = "0";
                label2.Text = "0";
                MessageBox.Show("Bạn chưa nhập đơn vị cần đổi", "Chưa nhập đơn vị cần đổi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (comboBox1.SelectedItem == "Milimet (mm)")
            {
                ket_qua = Convert.ToDouble(label1.Text) / 1000;
            }
            if (comboBox1.SelectedItem == "Centimet (cm)")
            {
                ket_qua = Convert.ToDouble(label1.Text) / 100;
            }
            if (comboBox1.SelectedItem == "Decimet (dm)")
            {
                ket_qua = Convert.ToDouble(label1.Text) / 10;
            }
            if (comboBox1.SelectedItem == "Kilomet (km)")
            {
                ket_qua = Convert.ToDouble(label1.Text) * 1000;
            }
            if (comboBox1.SelectedItem == "Inch (in)")
            {
                ket_qua = Convert.ToDouble(label1.Text) * 2.54 / 100;
            }
            if (comboBox1.SelectedItem == "Feet")
            {
                ket_qua = Convert.ToDouble(label1.Text) * 0.384;
            }
            if (comboBox1.SelectedItem == "Yard")
            {
                ket_qua = Convert.ToDouble(label1.Text) * 0.9144;
            }
            if (comboBox1.SelectedItem == "Dặm")
            {
                ket_qua = Convert.ToDouble(label1.Text) * 1609.344;
            }
            if (comboBox1.SelectedItem == "Hải lí")
            {
                ket_qua = Convert.ToDouble(label1.Text) * 1852;
            }

            // Xừ lý chuyển sang combobox 2 (chiều dài)
            if (comboBox2.SelectedItem == "Milimet (mm)")
            {
                ket_qua *= 1000;
            }
            if (comboBox2.SelectedItem == "Centimet (cm)")
            {
                ket_qua *= 100;
            }
            if (comboBox2.SelectedItem == "Decimet (dm)")
            {
                ket_qua *= 10;
            }
            if (comboBox2.SelectedItem == "Kilomet (km)")
            {
                ket_qua /= 1000;
            }
            if (comboBox2.SelectedItem == "Inch (in)")
            {
                ket_qua *= 39.37008;
            }
            if (comboBox2.SelectedItem == "Feet")
            {
                ket_qua *= 3.28084;
            }
            if (comboBox2.SelectedItem == "Yard")
            {
                ket_qua *= 1.093613;
            }
            if (comboBox2.SelectedItem == "Dặm")
            {
                ket_qua *= 0.000621;
            }
            if (comboBox1.SelectedItem == "Hải lí")
            {
                ket_qua *= 0.00054;
            }

            //Xừ lý chuyển sang combobox 1 (khối lượng)

            if (comboBox1.SelectedItem == "Gam (g)")
            {
                ket_qua = Convert.ToDouble(label1.Text) / 1000;
            }
            if (comboBox1.SelectedItem == "Decagam (dag)")
            {
                ket_qua = Convert.ToDouble(label1.Text) / 100;
            }
            if (comboBox1.SelectedItem == "Hectogam (hg)")
            {
                ket_qua = Convert.ToDouble(label1.Text) / 10;
            }
            if (comboBox1.SelectedItem == "Kilogam (kg)")
            {
                ket_qua = Convert.ToDouble(label1.Text);
            }
            if (comboBox1.SelectedItem == "Tấn (t)")
            {
                ket_qua = Convert.ToDouble(label1.Text) * 1000;
            }
            if (comboBox1.SelectedItem == "Pound")
            {
                ket_qua = Convert.ToDouble(label1.Text) * 0.453592;
            }
            if (comboBox1.SelectedItem == "Ounce")
            {
                ket_qua = Convert.ToDouble(label1.Text) * 0.02835;
            }
            if (comboBox1.SelectedItem == "Hòn đá")
            {
                ket_qua = Convert.ToDouble(label1.Text) * 6.350293;
            }
            // Xừ lý chuyển sang combobox 2 (khối lượng)

            if (comboBox2.SelectedItem == "Gam (g)")
            {
                ket_qua *= 1000;
            }
            if (comboBox2.SelectedItem == "Decagam (dag)")
            {
                ket_qua *= 100;
            }
            if (comboBox2.SelectedItem == "Hectogam (hg)")
            {
                ket_qua *= 10;
            }
            if (comboBox2.SelectedItem == "Kilogam (kg)")
            {
                ket_qua *= 1;
            }
            if (comboBox2.SelectedItem == "Tấn (t)")
            {
                ket_qua /= 1000;
            }
            if (comboBox2.SelectedItem == "Pound")
            {
                ket_qua *= 2.204623;
            }
            if (comboBox2.SelectedItem == "Ounce")
            {
                ket_qua *= 0.02835;
            }
            if (comboBox2.SelectedItem == "Hòn đá")
            {
                ket_qua *= 6.350293;
            }

            //Xừ lý chuyển sang comboBox 1 (Hiệu điện thế)
            if (comboBox1.SelectedItem == "Nanovolt (nV)")
            {
                ket_qua = Convert.ToDouble(label1.Text) / 1000000000;
            }
            if (comboBox1.SelectedItem == "Microvolt (µV)")
            {
                ket_qua = Convert.ToDouble(label1.Text) / 1000000;
            }
            if (comboBox1.SelectedItem == "Millivolt (mV)")
            {
                ket_qua = Convert.ToDouble(label1.Text) / 1000;
            }
            if (comboBox1.SelectedItem == "Volt (V)")
            {
                ket_qua = Convert.ToDouble(label1.Text) * 1;
            }
            if (comboBox1.SelectedItem == "Kilovolt (kV)")
            {
                ket_qua = Convert.ToDouble(label1.Text) * 1000;
            }
            if (comboBox1.SelectedItem == "Megavolt (MV)")
            {
                ket_qua = Convert.ToDouble(label1.Text) * 1000000;
            }
            if (comboBox1.SelectedItem == "Gigavolt (GV)")
            {
                ket_qua = Convert.ToDouble(label1.Text) * 1000000000;
            }
            //Xử lý chuyển sang comboBox 2 (Hiệu điện thế)
            if (comboBox2.SelectedItem == "Nanovolt (nV)")
            {
                ket_qua = Convert.ToDouble(label1.Text) * 1000000000;
            }
            if (comboBox2.SelectedItem == "Microvolt (µV)")
            {
                ket_qua = Convert.ToDouble(label1.Text) * 1000000;
            }
            if (comboBox2.SelectedItem == "Millivolt (mV)")
            {
                ket_qua = Convert.ToDouble(label1.Text) * 1000;
            }
            if (comboBox2.SelectedItem == "Volt (V)")
            {
                ket_qua = Convert.ToDouble(label1.Text) * 1;
            }
            if (comboBox2.SelectedItem == "Kilovolt (kV)")
            {
                ket_qua = Convert.ToDouble(label1.Text) / 1000;
            }
            if (comboBox2.SelectedItem == "Megavolt (MV)")
            {
                ket_qua = Convert.ToDouble(label1.Text) / 1000000;
            }
            if (comboBox2.SelectedItem == "Gigavolt (GV)")
            {
                ket_qua = Convert.ToDouble(label1.Text) / 1000000000;
            }

            //Xừ lý chuyển sang comboBox 1 (Hiệu điện thế)
            if (comboBox1.SelectedItem == "Nanoampe (nA)")
            {
                ket_qua = Convert.ToDouble(label1.Text) / 1000000000;
            }
            if (comboBox1.SelectedItem == "Microampe (µA)")
            {
                ket_qua = Convert.ToDouble(label1.Text) / 1000000;
            }
            if (comboBox1.SelectedItem == "Milliampe (mA)")
            {
                ket_qua = Convert.ToDouble(label1.Text) / 1000;
            }
            if (comboBox1.SelectedItem == "Ampe (A)")
            {
                ket_qua = Convert.ToDouble(label1.Text) * 1;
            }
            if (comboBox1.SelectedItem == "Kiloampe (kA)")
            {
                ket_qua = Convert.ToDouble(label1.Text) * 1000;
            }
            if (comboBox1.SelectedItem == "Megaampe (MA)")
            {
                ket_qua = Convert.ToDouble(label1.Text) * 1000000;
            }
            if (comboBox1.SelectedItem == "Gigaampe (GA)")
            {
                ket_qua = Convert.ToDouble(label1.Text) * 1000000000;
            }

            if (comboBox2.SelectedItem == "Nanoampe (nA)")
            {
                ket_qua = Convert.ToDouble(label1.Text) * 1000000000;
            }
            if (comboBox2.SelectedItem == "Microampe (µA)")
            {
                ket_qua = Convert.ToDouble(label1.Text) * 1000000;
            }
            if (comboBox2.SelectedItem == "Milliampe (mA)")
            {
                ket_qua = Convert.ToDouble(label1.Text) * 1000;
            }
            if (comboBox2.SelectedItem == "Ampe (A)")
            {
                ket_qua = Convert.ToDouble(label1.Text) * 1;
            }
            if (comboBox2.SelectedItem == "Kiloampe (kA)")
            {
                ket_qua = Convert.ToDouble(label1.Text) / 1000; 
            }
            if (comboBox2.SelectedItem == "Megaampe (MA)")
            {
                ket_qua = Convert.ToDouble(label1.Text) / 1000000;
            }
            if (comboBox1.SelectedItem == "Gigaampe (GA)")
            {
                ket_qua = Convert.ToDouble(label1.Text) / 1000000000;
            }
            if ((comboBox1.Text != "" || comboBox2.Text != "") && avc == 1)
            {
                label2.Text = System.Convert.ToString(ket_qua);
                //if(n != comboBox1.Text && n1 != comboBox2.Text)
                //{
                //   ket_qua = 1;
                //}
            }
            

        }
        private void combobox2_change(object sender, EventArgs e)
        {

        }
        private void combobox1_change(object sender, EventArgs e)
        {

        }
        private void CE_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "0";
            ket_qua = 1;
        }        
    
        private void dau_am_Click(object sender, EventArgs e)
        {

            string _temp = label1.Text;

            //Nếu đang là âm thì xóa
            if (_temp[0] == '-')
            {
                _temp = _temp.Remove(0, 1);
            }
            else //Đang ko có dấu thì thêm dấu âm
            {
                _temp = "-" + _temp;
            }

            label1.Text = _temp;
        }

        private void change_unit_press(object sender, KeyPressEventArgs e)
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
                    label1.Text += e.KeyChar;
                    break;

            }
        }

        private void cb1_cb2_change(object sender, EventArgs e)
        {
            bool a = true;
            if(label1.Text == "0" )
            {
                label2.Text = "0";
                a = false;
            }
            //Xử lý chuyển sang combobox 1 (chiều dài)
            if (a)
            {
               
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
