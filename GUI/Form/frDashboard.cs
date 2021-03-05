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
            UC_LopHoc uclh = new UC_LopHoc();
            addControlToPanel(uclh);
        }

        private void btnMon_Click(object sender, EventArgs e)
        {

        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
