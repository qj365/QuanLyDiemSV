using QuanLyDiemSV.GUI.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemSV
{
    public partial class frDashboard : Form
    {
        public frDashboard()
        {   //quang pro
            InitializeComponent();
            timerClock.Start();
            UC_Khoa uck = new UC_Khoa();
            addControlToPanel(uck);
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblTime.Text = dt.ToString("HH:mm:ss");
            lblDate.Text = dt.ToString("dd/MM/yyyy");
        }
        private void addControlToPanel (Control c)
        {
            c.Dock = DockStyle.Fill;
            pnlControl.Controls.Clear();
            pnlControl.Controls.Add(c);
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            UC_Khoa uck = new UC_Khoa();
            addControlToPanel(uck);
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            UC_LopCN uclh = new UC_LopCN();
            addControlToPanel(uclh);
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            UC_GiaoVien ucgv = new UC_GiaoVien();
            addControlToPanel(ucgv);
        }
        private void btnHocPhan_Click(object sender, EventArgs e)
        {
            UC_HocPhan uchp = new UC_HocPhan();
            addControlToPanel(uchp);
        }
        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            UC_SinhVien ucsv = new UC_SinhVien();
            addControlToPanel(ucsv);
        }
        private void btnLopCN_Click(object sender, EventArgs e)
        {
            UC_LopCN uclcn = new UC_LopCN();
            addControlToPanel(uclcn);
        }

        private void btnLopHP_Click(object sender, EventArgs e)
        {
            UC_LopHP uclhp = new UC_LopHP();
            addControlToPanel(uclhp);
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            UC_DiemSV ucdsv = new UC_DiemSV();
            addControlToPanel(ucdsv);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {          
            this.Hide();
            frLogin fr = new frLogin();
            fr.ShowDialog();

        }      
    }
}
