﻿using ClosedXML.Excel;
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
    public partial class frSaveExcel : Form
    {
        public frSaveExcel()
        {
            InitializeComponent();
        }

        private void frSaveExcel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.BANGDIEMCT' table. You can move, or remove it, as needed.
            this.bANGDIEMCTTableAdapter1.Fill(this.appData.BANGDIEMCT);
            // TODO: This line of code loads data into the 'diemSVData.BANGDIEMCT' table. You can move, or remove it, as needed.
            //this.bANGDIEMCTTableAdapter.Fill(this.diemSVData.BANGDIEMCT);

        }

        private void btnSaveToExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(this.appData.BANGDIEMCT.CopyToDataTable(), "BANGDIEMCT");
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("Bạn đã lưu điểm thành công sang Excel", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }
}
