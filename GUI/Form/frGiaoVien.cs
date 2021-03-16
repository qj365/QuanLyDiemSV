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
using QuanLyDiemSV.DTO;


namespace QuanLyDiemSV
{
    public partial class frGiaoVien : Form
    {

        public frGiaoVien()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {


            LoadMaKhoaIntoComboBox(cbKhoa);
            
        }
        
        void LoadMaKhoaIntoComboBox(ComboBox cb)
        {
            cb.DataSource = KhoaDAO.Instance.GetListKhoa();
            cb.DisplayMember = "TenKhoa";
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }





        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
            string magv = txbMaGv.Text;
            string tengv = txbTenGv.Text;
            string gioitinh = txbGioiTinh.Text;
                string ngaysinh = dpNgaySinh.Value.ToString("yyyy/MM/dd");
            string diachi = txbDiaChi.Text;
            string sdt = txbPhone.Text;
            string matkhau = txbPass.Text;
            string makhoa = (cbKhoa.SelectedItem as Khoa).MaKhoa;



            if (GiaoVienDAO.Instance.InsertGV(magv, tengv, gioitinh, ngaysinh, diachi, sdt, matkhau, makhoa))
            {
                MessageBox.Show("Thêm giáo viên thành công!");

            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm giáo viên!");
            }
            }
            catch
            {
                MessageBox.Show("Sai hoặc trùng thông tin khi thêm!");
            }

        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            try
            {
            string magv = txbMaGv.Text;
            string tengv = txbTenGv.Text;
            string gioitinh = txbGioiTinh.Text;
            string ngaysinh = dpNgaySinh.Value.ToString("yyyy/MM/dd");
            string diachi = txbDiaChi.Text;
            string sdt = txbPhone.Text;
            string matkhau = txbPass.Text;
            string makhoa = (cbKhoa.SelectedItem as Khoa).MaKhoa;



            if (GiaoVienDAO.Instance.UpdateGiaoVien( tengv, gioitinh, ngaysinh, diachi, sdt, matkhau, makhoa,magv))
            {
                MessageBox.Show("Sửa thành công!");

            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa !");
            }
            }
            catch
            {
                MessageBox.Show("Sai hoặc trùng thông tin !");
            }
      

        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
            string magv = txbMaGv.Text;
            string tengv = txbTenGv.Text;
            string gioitinh = txbGioiTinh.Text;
                string ngaysinh = dpNgaySinh.Text;
            string diachi = txbDiaChi.Text;
            string sdt = txbPhone.Text;
            string matkhau = txbPass.Text;
            string makhoa = (cbKhoa.SelectedItem as Khoa).MaKhoa;



            if (GiaoVienDAO.Instance.DeleteGiaoVien(magv))
            {
                MessageBox.Show("Xóa giáo viên thành công!");

            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa giáo viên!");
            }
            }
            catch
            {
                MessageBox.Show("Sai hoặc trùng thông tin!");
            }

        }
    }
}
