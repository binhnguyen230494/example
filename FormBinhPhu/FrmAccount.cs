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
    public partial class FrmOption : Form
    {
        public FrmOption()
        {
            InitializeComponent();
            int a = Class1.Role;
            if(a == 0)
            {
                FrmVote f = new FrmVote();
                this.Hide();
                f.ShowDialog();
            }
        }
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnOption_Click(object sender, EventArgs e)
        {
            FrmLoadOption f = new FrmLoadOption();
            this.Hide();
            f.ShowDialog();
        }

        private void BtnAccount_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = client.DsAcount();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            ServiceReference1.Account obj = new ServiceReference1.Account();
            obj.name = txtname.Text;
            obj.pass = txtpass.Text;
            if (txtrole.Text == "1")
            {
                obj.role = bool.Parse("true");
            }
            else
            {
                obj.role = bool.Parse("false");
            }
            obj.idacc = txtid.Text;
            if(txtname.Text==""||txtpass.Text==""||txtid.Text==""||txtrole.Text=="")
            {
                MessageBox.Show("Nhập Thiếu Thông Tin", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
            if(client.ThemAc(obj)== true)
            {
                MessageBox.Show("Đã Thêm", "Thông Báo", MessageBoxButtons.OK);
                BtnAccount_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Id bị trùng", "Thông Báo", MessageBoxButtons.OK);
            }


        }

       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtid.Text = dataGridView1.Rows[numrow].Cells[0].Value.ToString();
            txtname.Text = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
            txtrole.Text = dataGridView1.Rows[numrow].Cells[2].Value.ToString();
            txtpass.Text = dataGridView1.Rows[numrow].Cells[3].Value.ToString();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là sửa ?", "NOTE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                ServiceReference1.Account obj = new ServiceReference1.Account();
                obj.name = txtname.Text;
                obj.pass = txtpass.Text;
                if (txtrole.Text == "1")
                {
                    obj.role = bool.Parse("true");
                }
                else
                {
                    obj.role = bool.Parse("false");
                }
                obj.idacc = txtid.Text;
                client.SuaAc(obj);
                BtnAccount_Click(sender, e);

            }

        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là xóa ?", "NOTE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                ServiceReference1.Account obj = new ServiceReference1.Account();
                if (txtrole.Text == "0")
                {
                    obj.name = txtname.Text;
                    obj.pass = txtpass.Text;
                    if (txtrole.Text == "1")
                    {
                        obj.role = bool.Parse("true");
                    }
                    else
                    {
                        obj.role = bool.Parse("false");
                    }
                    obj.idacc = txtid.Text;
                    client.XoaAc(obj);
                    MessageBox.Show("Đã Xóa", "Thông báo");
                    BtnAccount_Click(sender, e);
                }
                else if(txtrole.Text=="1")
                {
                    MessageBox.Show("Khong The Xoa", "Thong Bao");
                }
            }
        }

        private void BtnVote_Click(object sender, EventArgs e)
        {
            FrmVote f = new FrmVote();
            this.Hide();
            f.ShowDialog();
        }

        private void FrmOption_Load(object sender, EventArgs e)
        {

        }
    }
}
