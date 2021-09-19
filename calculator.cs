using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((txtNum1.Text.Length == 0)||(txtNum2.Text.Length == 0))
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            float soThuNhat = float.Parse(txtNum1.Text);
            float soThuHai = float.Parse(txtNum2.Text);
            if (soThuHai == 0)
            {
              
                MessageBox.Show("Ban phai nhap so thu hai khac 0");
            }
            else
            {
                float chia = soThuNhat / soThuHai;
                kq.Text = chia.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtNum1.Text.Length == 0 )||(txtNum2.Text.Length == 0))
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            int soThuNhat = Convert.ToInt32(txtNum1.Text);
            int soThuHai = Convert.ToInt32(txtNum2.Text);
            int Kq = soThuNhat + soThuHai;
            kq.Text = Kq.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((txtNum1.Text.Length == 0) || (txtNum2.Text.Length == 0))
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int soThuNhat = Convert.ToInt32(txtNum1.Text);
            int soThuHai = Convert.ToInt32(txtNum2.Text);
            int Kq = soThuNhat - soThuHai;
            kq.Text = Kq.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void nhan_Click(object sender, EventArgs e)
        {
            if ((txtNum1.Text.Length == 0) || (txtNum2.Text.Length == 0))
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            int soThuNhat = Convert.ToInt32(txtNum1.Text);
            int soThuHai = Convert.ToInt32(txtNum2.Text);
            int Kq = soThuNhat * soThuHai;
            kq.Text = Kq.ToString();
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
      
        }
    }
}
