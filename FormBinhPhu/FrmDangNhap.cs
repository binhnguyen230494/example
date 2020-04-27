using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBinhPhu
{
    public partial class FrmDangNhap : Form
    {
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        public FrmDangNhap()
        {
            InitializeComponent();
        }
        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            ServiceReference1.Account obj = new ServiceReference1.Account();
            obj.idacc = TxtDangNhap.Text;
            obj.pass = TxtMatKhau.Text;
            if (TxtDangNhap.Text == "" || TxtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng thêm thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (client.DangNhap(obj) == true)
            {
                {
                    if (client.Account(obj) == true)
                    {
                        Class1.IdAcc = TxtDangNhap.Text;
                        Class1.Role = 1;
                        MessageBox.Show("Chào Admin", "Account");
                        FrmOption f = new FrmOption();
                        this.Hide();
                        f.ShowDialog();
                    }
                    else
                    {
                        Class1.IdAcc = TxtDangNhap.Text;
                        Class1.Role = 0;
                        MessageBox.Show("Chào User", "Acount");
                        FrmOption f = new FrmOption();
                        this.Hide();
                        f.ShowDialog();
                    }
                }
            }

            else
            {
                MessageBox.Show("Thất bại", "Error");
                TxtDangNhap.Clear();
                TxtMatKhau.Clear();
                TxtDangNhap.Focus();
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
