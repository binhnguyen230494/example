using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace FormBinhPhu
{
    public partial class FrmVote : Form
    {
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        ServiceReference1.Vote obj = new ServiceReference1.Vote();
        ServiceReference1.Option op = new ServiceReference1.Option();
        public FrmVote()
        {
            InitializeComponent();
            Load += FrmVote_Load;
            int a = Class1.Role;
            if (a == 1)
            {
                chart1.Visible = true;
                GridResult.Visible = true;
            }
            else if(a==0)
            {
                chart1.Visible = false;
                GridResult.Visible = false;
            }
            btxcapnhat.Visible = false;
        }
        Timer t;
        DateTime endTime = new DateTime(2019, 03, 15, 5, 30, 00);
        private void FrmVote_Load(object sender, EventArgs e)
        {
            label7.Visible = false;
            DataSet ds = new DataSet();
            ds = client.DsAns();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Contents";
            comboBox1.ValueMember = "Code";
            label7.Text = ds.Tables[0].Rows[0][2].ToString();
            
            //labelco.Text = ds.Tables[0].Rows[0][1].ToString();
            //labelko.Text = ds.Tables[0].Rows[1][1].ToString();
            //labelkbiet.Text = ds.Tables[0].Rows[2][1].ToString();
            DataSet dt = new DataSet();
            dt = client.DsContents();
            txtcauhoi.Text=dt.Tables[0].Rows[0][0].ToString();
            t = new Timer();
            t.Interval = 1000;
            t.Tick += t_Tick;
            DataSet dl = new DataSet();
            TimeSpan ts = endTime.Subtract(DateTime.Now);
            label4.Text = ts.ToString("dd' Ngày 'hh' Giờ 'mm' Phút 'ss' Giây'");
            t.Start();
            obj.idacc = Class1.IdAcc;
            DataSet db = new DataSet();
            db = client.DsCode();
            GridResult.DataSource = db.Tables[0];
            GridResult.Columns[2].HeaderText = "Mã Vote";
            GridResult.Columns[0].HeaderText = "Tên người Vote";
            GridResult.Columns[1].HeaderText = "Câu trả lời";
            GridResult.Columns[3].HeaderText = "Thời Gian Vote";
            DataSet di = new DataSet();
            di = client.Luotvote();
            chart1.DataSource = di.Tables[0];
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "So Luong";
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Mã Code";
            chart1.Series["Series1"].XValueMember = "Code";
            chart1.Series["Series1"].YValueMembers = "Code1";
        }
        void t_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = endTime.Subtract(DateTime.Now);
            label4.Text = ts.ToString("dd' Ngày 'hh' Giờ 'mm' Phút 'ss' Giây'");
            if (ts.TotalSeconds <= 0)
            {
                btxcapnhat.Enabled = false;
                BtnVote.Enabled = false;
                t.Stop();
                label4.Text = "Đã hết giờ vote!!";
                chart1.Visible = true;
                GridResult.Visible = true;
            }
        }
        private void BtnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnVote_Click(object sender, EventArgs e)
        {
            obj.idopt = label7.Text;
            obj.idacc = Class1.IdAcc; 
            //if  (client.Idacc(obj)==true)
            //{
            //    MessageBox.Show("id này đã bình chọn");
            //}
            
            if(client.Idacc(obj)==false)
            {
                obj.code = comboBox1.SelectedValue.ToString();
                client.ThemVote(obj);
                MessageBox.Show("Binh Chon Thanh Cong");
                FrmVote_Load(sender, e);
            }
            else
            {
                btxcapnhat_Click(sender, e);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {
        }
        private void btxcapnhat_Click(object sender, EventArgs e)
        {
            obj.idacc = Class1.IdAcc;
            if (client.CapnhatFlag(obj)==false)
            {
                obj.idacc = Class1.IdAcc;
                obj.code = comboBox1.SelectedValue.ToString();
                client.SuaVote(obj);
                MessageBox.Show("Cập nhật thành công");
                FrmVote_Load(sender, e);

            }
            else 
            {
                MessageBox.Show("Hết lượt cập nhật!!");
            }
        }
    }
}
