using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDiemSV.DAO;
using QuanLyDiemSV.DTO;

namespace QuanLyDiemSV.GUI.User_Control
{
    public partial class UC_HocPhan : UserControl
    {
        BindingSource hocphanList = new BindingSource();

        public UC_HocPhan()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            dtgvHocPhan.DataSource = hocphanList;
            LoadListHocPhan();
            LoadMaKhoaIntoComboBox(cbFindKhoa);
            LoadMaKhoaIntoComboBox(cbEditKhoa);
            AddHPBinding();
        }
        void LoadMaKhoaIntoComboBox(ComboBox cb)
        {
            cb.DataSource = KhoaDAO.Instance.GetListKhoa();
            cb.DisplayMember = "TenKhoa";
        }
        void LoadListHocPhan()
        {
            hocphanList.DataSource = HocPhanDAO.Instance.GetListHocPhan();
        }
        void AddHPBinding()
        {
            txbMaHP.DataBindings.Add(new Binding("Text", dtgvHocPhan.DataSource, "MaHocPhan", true, DataSourceUpdateMode.Never));
            txbTenHP.DataBindings.Add(new Binding("Text", dtgvHocPhan.DataSource, "TenHocPhan", true, DataSourceUpdateMode.Never));
            txbSoTinChi.DataBindings.Add(new Binding("Text", dtgvHocPhan.DataSource, "SoTinChi", true, DataSourceUpdateMode.Never));
            txbSoTiet.DataBindings.Add(new Binding("Text", dtgvHocPhan.DataSource, "SoTiet", true, DataSourceUpdateMode.Never));
            txbHinhThucThi.DataBindings.Add(new Binding("Text", dtgvHocPhan.DataSource, "HinhThucThi", true, DataSourceUpdateMode.Never));
        }

        private void txbMaHP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvHocPhan.SelectedCells.Count > 0)
                {

                    string makhoa = Convert.ToString(dtgvHocPhan.SelectedCells[0].OwningRow.Cells["MaKhoa"].Value);
                    Khoa khoa = KhoaDAO.Instance.GetKhoaByMaKhoa(makhoa);
                    cbEditKhoa.SelectedItem = khoa;
                    int index = -1;
                    int i = 0;
                    foreach (Khoa item in cbEditKhoa.Items)
                    {
                        if (item.MaKhoa == khoa.MaKhoa)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbEditKhoa.SelectedIndex = index;
                }
            }
            catch
            {

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            string mahocphan = txbMaHP.Text;
            string tenhocphan = txbTenHP.Text;
            int sotinchi = Int32.Parse(txbSoTinChi.Text);
            int sotiet = Int32.Parse(txbSoTiet.Text);
            string hinhthucthi = txbHinhThucThi.Text;
            string makhoa = (cbEditKhoa.SelectedItem as Khoa).MaKhoa;
           try
            {
                if (HocPhanDAO.Instance.InsertHocPhan(mahocphan, tenhocphan, sotinchi, sotiet, hinhthucthi, makhoa))
                {
                    MessageBox.Show("Thêm học phần thành công");
                    LoadListHocPhan();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm học phần");
                }
            }
            catch
            {

            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadListHocPhan();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mahocphan = txbMaHP.Text;
            string tenhocphan = txbTenHP.Text;
            int sotinchi = Int32.Parse(txbSoTinChi.Text);
            int sotiet = Int32.Parse(txbSoTiet.Text);
            string hinhthucthi = txbHinhThucThi.Text;
            string makhoa = (cbEditKhoa.SelectedItem as Khoa).MaKhoa;
            try
            {
                if (HocPhanDAO.Instance.UpdateHocPhan(tenhocphan, sotinchi, sotiet, hinhthucthi, makhoa, mahocphan))
                {
                    MessageBox.Show("Sửa học phần thành công");
                    LoadListHocPhan();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi sửa học phần");
                }
            }
            catch
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mahocphan = txbMaHP.Text;
            try
            {
                if (HocPhanDAO.Instance.DeleteHocPhan(mahocphan))
                {
                    MessageBox.Show("Xóa học phần thành công");
                    LoadListHocPhan();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa học phần");
                }
            }
            catch
            {

            }
        }

        List<HocPhan> SearchHPByTenHP(string tenhocphan, string makhoa)
        {
            List<HocPhan> listHocPhan = HocPhanDAO.Instance.SearchHPByTenHP(tenhocphan, makhoa);
            return listHocPhan;
        }

        List<HocPhan> SearchHPByTenKhoa(string makhoa)
        {
            List<HocPhan> listHocPhan = HocPhanDAO.Instance.SearchHPByTenKhoa(makhoa);
            return listHocPhan;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txbFindHP.Text == "")
            {
                hocphanList.DataSource = SearchHPByTenKhoa((cbFindKhoa.SelectedItem as Khoa).MaKhoa);

            }
            else
            {
                hocphanList.DataSource = SearchHPByTenHP(txbFindHP.Text, (cbFindKhoa.SelectedItem as Khoa).MaKhoa);
            }
        }
    }
}
