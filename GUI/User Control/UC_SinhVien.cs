using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemSV.GUI.User_Control
{
    public partial class UC_SinhVien : UserControl
    {
        public UC_SinhVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (frSinhVien frsv = new frSinhVien())
            {
                frsv.ShowDialog();
            }
        }
    }
}
