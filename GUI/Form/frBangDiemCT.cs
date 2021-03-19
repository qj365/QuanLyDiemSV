using QuanLyDiemSV.DAO;
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
    public partial class frBangDiemCT : Form
    {
        public frBangDiemCT()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                string masv = txbMSV.Text;
                string malophp = txbMLHP.Text;
                double diemcc = (double)Convert.ToDouble(txbDCC.Text);
                double diemtx = (double)Convert.ToDouble(txbDTX.Text);
                double diemthi = (double)Convert.ToDouble(txbDT.Text);

                if (DiemSVDAO.Instance.InsertDiemSV(masv, malophp, diemcc, diemtx, diemthi))
                {
                    MessageBox.Show("Thêm điểm sinh viên thành công!");

                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm điểm sinh viên!");
                }
            }
            catch
            {
                MessageBox.Show("Sai hoặc trùng thông tin khi thêm!");
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            try
            {
                string masv = txbMSV.Text;
                string malophp = txbMLHP.Text;
                double diemcc = (double)Convert.ToDouble(txbDCC.Text);
                double diemtx = (double)Convert.ToDouble(txbDTX.Text);
                double diemthi = (double)Convert.ToDouble(txbDT.Text);

                if (DiemSVDAO.Instance.UpdateDiemSV( diemcc, diemtx, diemthi, malophp, masv))
                {
                    MessageBox.Show("Sủa điểm sinh viên thành công!");

                }
                else
                {
                    MessageBox.Show("Có lỗi khi sửa điểm sinh viên!");
                }
            }
            catch
            {
                MessageBox.Show("Sai thông tin khi sửa!");
            }
        }
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string masv = txbMSV.Text;

                if (DiemSVDAO.Instance.DeleteDiemSV(masv))
                {
                    MessageBox.Show("Xóa điểm sinh viên thành công!");

                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa điểm sinh viên!");
                }
            }
            catch
            {
                MessageBox.Show("Sai thông tin khi xóa!");
            }
        }


    }
}
