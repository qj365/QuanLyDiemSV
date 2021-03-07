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
    public partial class UC_DiemSV : UserControl
    {
        public UC_DiemSV()
        {
            InitializeComponent();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (frBangDiemCT bdct = new frBangDiemCT())
            {
                bdct.ShowDialog();
            }
        }
    }
}
