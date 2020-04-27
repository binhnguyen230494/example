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
    public partial class FrmLoadOption : Form
    {
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        ServiceReference1.Vote vote = new ServiceReference1.Vote();
        ServiceReference1.Option obj = new ServiceReference1.Option();
        public FrmLoadOption()
        {
            InitializeComponent();
            
        }
        
        private void BtnThoat_Click(object sender, EventArgs e)
        {
            FrmOption f = new FrmOption();
            this.Hide();
            f.Show();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            vote.idopt = CmbOption.Text;
            if(vote.idopt!="1")
            {
                MessageBox.Show("Không tồn tại câu hỏi");
                return;
            }
            else
            {
                DataSet ds = new DataSet();
                ds = client.DsOption();
                TxtCt.Text = ds.Tables[0].Rows[0][0].ToString();
                DataSet ans = new DataSet();
                ans = client.DsAns();
                CmbAns.DataSource = ans.Tables[0];
                CmbAns.DisplayMember = "Contents";
                CmbAns.ValueMember = "Code";
                DataSet dt = new DataSet();
                dt = client.DsCode();
                GridResult.DataSource = dt.Tables[0];
                GridResult.Columns[2].HeaderText = "Mã Vote";
                GridResult.Columns[0].HeaderText = "Tên người Vote";
                GridResult.Columns[1].HeaderText = "Câu trả lời";
                GridResult.Columns[3].HeaderText = "Thời Gian Vote";
            }
        }

        private void FrmLoadOption_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            int maxid = 0;
            for (int i = 0; i< CmbOption.Items.Count; i++)
            {
                if ( Convert.ToInt32(CmbOption.Items[i]) > maxid)
                {
                    maxid = Convert.ToInt32(CmbOption.Items[i]);
                }
            }
            maxid += 1;
            CmbOption.Items.Add(maxid);
            CmbOption.SelectedIndex = 0;
            TxtCt.Clear();
            TxtAns.Clear();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            ServiceReference1.Option obj = new ServiceReference1.Option();
            //CmbAns.Items.Add(TxtAns.Text);
            obj.idopt = CmbOption.Text;
            obj.deadlinetime = dateTimePicker1.Value;
            //obj.contents = TxtCt.Text;
            obj.contents = TxtAns.Text;
            if (obj.contents == TxtCt.Text)
            {

            }
            if (TxtAns.Text == "")
            {
                MessageBox.Show("Nhập thiếu thông tin", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
            if (client.ThemOption(obj)==true)
            {
                MessageBox.Show("Đã Thêm", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Id bị trùng", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (TxtAns.Text == "")
            {
                MessageBox.Show("Thiếu thông tin", "Thông báo");
                return;
            }
            if (MessageBox.Show("Bạn có chắc là sửa ?", "NOTE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                ServiceReference1.Option obj = new ServiceReference1.Option();
                obj.code = CmbAns.SelectedValue.ToString();
                obj.contents = TxtAns.Text;
                client.SuaOption(obj);
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (TxtAns.Text == "")
            {
                MessageBox.Show("Thiếu điều kiện", "Thông báo");
                return;
            }
            if (MessageBox.Show("Bạn có chắc là xóa câu trả lời ?", "NOTE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                ServiceReference1.Option obj = new ServiceReference1.Option();
                obj.code = CmbAns.SelectedValue.ToString();
                obj.contents = TxtAns.Text;
                client.XoaOption(obj);
                MessageBox.Show("Đã Xóa", "Thông báo");
            }
        }

        private void FrmLoadOption_Load(object sender, EventArgs e)
        {
            //DataSet ds = new DataSet();
            //ds = client.Dsopt();
            //CmbOption.DataSource = ds.Tables[0];
            //CmbOption.DisplayMember = "IdOpt";
            //CmbOption.ValueMember = "IdOpt";
        }

        private void CmbAns_SelectedValueChanged(object sender, EventArgs e)
        {
            TxtAns.Text = CmbAns.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void CmbAns_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
