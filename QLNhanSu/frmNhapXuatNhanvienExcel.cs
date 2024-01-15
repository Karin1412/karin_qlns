using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Excel1 = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Data.OleDb;
using System.Reflection;
using System.Threading;

namespace QLNhanSu
{
    public partial class frmNhapXuatNhanvienExcel : DevExpress.XtraEditors.XtraForm
    {
        public frmNhapXuatNhanvienExcel()
        {
            InitializeComponent();
            cmb_luachon.SelectedItem = "Xuất toàn bộ thông tin nhân viên";
        }

        public void loadThongTinForm()
        {
            
        }

        public void LoadBophan()
        {
            List<DTO.Bophan> bp = new List<DTO.Bophan>();
            bp = BUS.BUS_Bophan.compoboxBophan();
            if (cmb_bophan.Items.Count > 0)
                cmb_bophan.Items.Clear();
            cmb_bophan.Items.Add("---Chọn tên bộ phận cần thực thi---");
            for (int i = 0; i < bp.Count; i++)
            {
                 cmb_bophan.Items.Add(bp[i].Tenbophan);
                 cmb_bophan.ValueMember = bp[i].Mabophan;
                 cmb_bophan.DisplayMember = bp[i].Mabophan;
            }
            cmb_bophan.SelectedItem = "---Chọn tên bộ phận cần thực thi---";
        }
        public void LoadChucvu()
        {
            List<DTO.ChucVu> cv = new List<DTO.ChucVu>();
            cv = BUS.BUS_Chucvu.selectChucvu();
            if (cmb_bophan.Items.Count > 0)
                cmb_bophan.Items.Clear();
            cmb_bophan.Items.Add("---Chọn tên chức vụ thực thi---");
            for (int i = 0; i < cv.Count; i++)
            {
                cmb_bophan.Items.Add(cv[i].Tenchucvu);
                cmb_bophan.DisplayMember = cv[i].Machucvu;
                cmb_bophan.ValueMember = cv[i].Machucvu;
            }
            cmb_bophan.SelectedItem = "---Chọn tên chức vụ thực thi---";
        }
        private void cmb_luachon_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_luachon.SelectedItem == "Xuất toàn bộ thông tin nhân viên")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInCustomization;
            }
            else if (cmb_luachon.SelectedItem == "Chỉ xuất theo bộ phận")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                LoadBophan();
            }
            else
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                LoadChucvu();
            }
        }
        private void bt_thucthi_Click(object sender, EventArgs e)
        {
            
                if (cmb_luachon.SelectedItem == "Xuất toàn bộ thông tin nhân viên")
                {
                    selectNhanvienExcle(0, "null");
                }
                else if (cmb_luachon.SelectedItem == "Chỉ xuất theo bộ phận")
                {
                    if (cmb_bophan.Text != "---Chọn tên bộ phận cần thực thi---")
                        selectNhanvienExcle(1, cmb_bophan.Text);
                    else
                        MessageBox.Show("Bạn chưa chọn bộ phận để thực thi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (cmb_bophan.Text != "---Chọn tên chức vụ thực thi---")
                        selectNhanvienExcle(2, cmb_bophan.Text);
                    else
                        MessageBox.Show("Bạn chưa chọn chức vụ để thực thi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            
        }
        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Xuat excel
        public void selectNhanvienExcle(int luachon,string k)
        {
            List<DTO.HoSoNhanVien> nv = new List<DTO.HoSoNhanVien>();
            nv = BUS.BUS_Nhanvien.selectNhanvienfull(luachon, k);
            saveFileDialog1.Filter = "excel files (*.xlsx)|*.xlsx | csv files (*.csv)|*.csv";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
               
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(1);
                    Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];
                    int j = 1;
                    foreach (DTO.HoSoNhanVien hsnv in nv)
                    {
                        
                        xlWorkSheet.Cells[1][j] = "'" + hsnv.Manv.ToString();
                        xlWorkSheet.Cells[2][j] = "'" + hsnv.Mathe.ToString();
                        xlWorkSheet.Cells[3][j] = hsnv.Holot.ToString();
                        xlWorkSheet.Cells[4][j] = hsnv.Ten.ToString();
                        xlWorkSheet.Cells[5][j] = "'" + hsnv.Ngaysinh.ToString();
                        xlWorkSheet.Cells[6][j] = "" + hsnv.Gioitinh.ToString();
                        xlWorkSheet.Cells[7][j] = hsnv.Quequan.ToString();
                        xlWorkSheet.Cells[8][j] = hsnv.Quoctich.ToString();
                        xlWorkSheet.Cells[9][j] = "'" + hsnv.Sdt.ToString();
                        xlWorkSheet.Cells[10][j] = hsnv.Bangcap.ToString();
                        xlWorkSheet.Cells[11][j] = "'" + hsnv.Bophan.ToString();
                        xlWorkSheet.Cells[12][j] = "'" + hsnv.Chucvu.ToString();
                        xlWorkSheet.Cells[13][j] = "'" + hsnv.Cmnd.ToString();
                        xlWorkSheet.Cells[14][j] = "'" + hsnv.Dantoc.ToString();
                        xlWorkSheet.Cells[15][j] = hsnv.Hktt.ToString();
                        xlWorkSheet.Cells[16][j] = "'" + hsnv.Tthonnhan.ToString();
                        xlWorkSheet.Cells[17][j] = "'" + hsnv.Atm.ToString();
                        xlWorkSheet.Cells[18][j] = "'" + hsnv.Ngaylamviec.ToString();
                        if (hsnv.Thoiviec == "0")
                            xlWorkSheet.Cells[19][j] = "Đã Thôi việc";
                        else
                            xlWorkSheet.Cells[20][j] = "";
                    
                        j++;
                    }
                    wb.SaveAs(saveFileDialog1.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing);
                    wb.Close(false, Type.Missing, Type.Missing);
                    app.Quit();
                    System.Diagnostics.Process.Start(saveFileDialog1.FileName);




            }

        }
        private void dropDownButton1_Click(object sender, EventArgs e)
        {
            
        }

        
        #endregion
        private void bt_thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
      

    }
}