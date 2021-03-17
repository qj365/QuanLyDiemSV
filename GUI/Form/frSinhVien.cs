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
using System.Data.SqlClient;

namespace QuanLyDiemSV
{
    public partial class frSinhVien : Form

    {
        public frSinhVien()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {
                string masv = txbMaSv.Text;
                string tensv = txbTenSv.Text;
                string gioitinh = bunifuTextBox1.Text;
                string ngaysinh = dpNgaySinh.Value.ToString("yyyy/MM/dd");
                string quequan = txbQueQuan.Text;
                string sdt = txbPhone.Text;
                string malopcn = txbMaLop.Text;
                string gpa = txbGpa.Text;



                if (SinhVienDAO.Instance.InsertSV(masv, tensv, gioitinh, ngaysinh, quequan, sdt, malopcn, gpa))
                {
                    MessageBox.Show("Thêm Sinh viên thành công!");

                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm sinh viên!");
                }
            }
            catch
            {
                MessageBox.Show("Sai hoặc trùng thông tin khi thêm!");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string tensv = txbTenSv.Text;
                string gioitinh = bunifuTextBox1.Text;
                string ngaysinh = dpNgaySinh.Value.ToString("yyyy/MM/dd");
                string quequan = txbQueQuan.Text;
                string sdt = txbPhone.Text;
                string malopcn = txbMaLop.Text;
                string gpa = txbGpa.Text;
                string masv = txbMaSv.Text;


                if (SinhVienDAO.Instance.UpdateSinhVien(tensv, gioitinh, ngaysinh, quequan, sdt, malopcn, gpa, masv))
                {
                    MessageBox.Show("Sửa sinh viên thành công!");

                }
                else
                {
                    MessageBox.Show("Có lỗi khi sửa sinh viên!");
                }

            }
            catch
            {
                MessageBox.Show("Sai hoặc trùng thông tin!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string masv = txbMaSv.Text;
                string tensv = txbTenSv.Text;
                string gioitinh = bunifuTextBox1.Text;
                string ngaysinh = dpNgaySinh.Text;
                string quequan = txbQueQuan.Text;
                string sdt = txbPhone.Text;
                string malop = txbMaLop.Text;
                string gpa = txbGpa.Text;



                if (SinhVienDAO.Instance.DeleteSinhVien(masv))
                {
                    MessageBox.Show("Xoá sinh viên thành công!");

                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa sinh viên!");
                }
            }
            catch
            {
                MessageBox.Show("Sai hoặc trùng thông tin !");
            }
        }
    }
}
