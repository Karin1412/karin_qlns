using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using DTO;

namespace QLNhanSu
{
    public partial class frmBangcong : DevExpress.XtraEditors.XtraForm
    {

        public frmBangcong()
        {
            InitializeComponent();
        }
        #region load
        private void frmBangcong_Load(object sender, EventArgs e)
        {
            loadFrom();
        }
        public void loadFrom()
        {
            for(int i=1;i<=12;i++)
            {
                cmbThang.Items.Add(i.ToString());
            }
            cmbThang.SelectedItem= DateTime.Now.Month.ToString();
            for(int i=1990;i<=DateTime.Now.Year;i++)
            {
                cmbNam.Items.Add(i.ToString());
            }
            cmbNam.SelectedItem = DateTime.Now.Year.ToString();
        }
        #endregion
        #region xem
        private void  _xem()
        {
            gridBangcong.DataSource = BUS.BUS_Bangcong.selectBangcong(int.Parse(cmbThang.Text), int.Parse(cmbNam.Text));
            lbManv.DataBindings.Clear();
            lbManv.DataBindings.Add("Text",gridBangcong.DataSource,"manv");
        }
        private void btXem_Click(object sender, EventArgs e)
        {
            _xem();
        }
        #endregion
        #region them
        private void _them()
        {
            frmThemcong frm = new frmThemcong();
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            _them();
        }
        private void them_Click(object sender, EventArgs e)
        {
            _them();
        }
        #endregion
        #region xoa
        private void _xoa()
        {
            if (gridBangcong.MainView.RowCount > 0)
            {
                if (MessageBox.Show("Bạn có chắc xoá toàn bộ ngày công của nhân viên có mã là " + lbManv.Text + " trong tháng " + cmbThang.Text + "/" + cmbNam.Text + " hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (BUS_Bangcong._xoa(lbManv.Text, cmbThang.Text, cmbNam.Text) == "true")
                    {
                        MessageBox.Show("Xoá thành công toàn bộ ngày công của nhân viên " + lbManv.Text + " trong tháng " + cmbThang.Text + "/" + cmbNam.Text + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _xem();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi từ hệ thống, hãy liên hệ với bộ phận kỹ thuật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            _xoa();
        }
        private void xoa_Click(object sender, EventArgs e)
        {
            _xoa();
        }
        #endregion
        #region chitiet
        private void _chiTiet()
        {
            if (gridBangcong.MainView.RowCount > 0)
            {
                frmChitietBangcongNhanvien frm = new frmChitietBangcongNhanvien(lbManv.Text,cmbThang.Text,cmbNam.Text);
                frm.Show();
            }
        }
        private void btChitiet_Click(object sender, EventArgs e)
        {
            _chiTiet();
        }
        private void xemchitiet_Click(object sender, EventArgs e)
        {
            _chiTiet();
        }
        #endregion
        private void _restart()
        {
            _xem();
        }
        private void restart_Click(object sender, EventArgs e)
        {
            _restart();
        }
        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            List<Bangcong> bangcongs = BUS.BUS_Bangcong.selectBangcong(int.Parse(cmbThang.Text), int.Parse(cmbNam.Text));
            gridBangcong.DataSource = bangcongs;
            lbManv.DataBindings.Clear();
            lbManv.DataBindings.Add("Text", gridBangcong.DataSource, "manv");


            saveFileDialog1.Filter = "excel files (*.xlsx)|*.xlsx | csv files (*.csv)|*.csv";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(1);
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];
                int j = 1;
                xlWorkSheet.Cells[1][j] = "Mã nhân viên";
                xlWorkSheet.Cells[2][j] = "Tên nhân viên";
                xlWorkSheet.Cells[3][j] = "Tên bộ phận";
                xlWorkSheet.Cells[4][j] = "Ngày 1";
                xlWorkSheet.Cells[5][j] = "Ngày 2";
                xlWorkSheet.Cells[6][j] = "Ngày 3";
                xlWorkSheet.Cells[7][j] = "Ngày 4";
                xlWorkSheet.Cells[8][j] = "Ngày 5";
                xlWorkSheet.Cells[9][j] = "Ngày 6";
                xlWorkSheet.Cells[10][j] = "Ngày 7";
                xlWorkSheet.Cells[11][j] = "Ngày 8";
                xlWorkSheet.Cells[12][j] = "Ngày 9";
                xlWorkSheet.Cells[13][j] = "Ngày 10";
                xlWorkSheet.Cells[14][j] = "Ngày 11";
                xlWorkSheet.Cells[15][j] = "Ngày 12";
                xlWorkSheet.Cells[16][j] = "Ngày 13";
                xlWorkSheet.Cells[17][j] = "Ngày 14";
                xlWorkSheet.Cells[18][j] = "Ngày 15";
                xlWorkSheet.Cells[19][j] = "Ngày 16";
                xlWorkSheet.Cells[20][j] = "Ngày 17";
                xlWorkSheet.Cells[21][j] = "Ngày 18";
                xlWorkSheet.Cells[22][j] = "Ngày 19";
                xlWorkSheet.Cells[23][j] = "Ngày 20";
                xlWorkSheet.Cells[24][j] = "Ngày 21";
                xlWorkSheet.Cells[25][j] = "Ngày 22";
                xlWorkSheet.Cells[26][j] = "Ngày 23";
                xlWorkSheet.Cells[27][j] = "Ngày 24";
                xlWorkSheet.Cells[28][j] = "Ngày 25";
                xlWorkSheet.Cells[29][j] = "Ngày 26";
                xlWorkSheet.Cells[30][j] = "Ngày 27";
                xlWorkSheet.Cells[31][j] = "Ngày 28";
                xlWorkSheet.Cells[32][j] = "Ngày 29";
                xlWorkSheet.Cells[33][j] = "Ngày 30";
                xlWorkSheet.Cells[34][j] = "Ngày 31";
                xlWorkSheet.Cells[35][j] = "Số ngày thường ";
                xlWorkSheet.Cells[36][j] = "Số ngày nghỉ";
                 j = 2;
                foreach (DTO.Bangcong bc in bangcongs)
                {

                    xlWorkSheet.Cells[1][j] = bc.Manv;
                    xlWorkSheet.Cells[2][j] = bc.Tennv;
                    xlWorkSheet.Cells[3][j] = bc.Tenbophan ;
                    xlWorkSheet.Cells[4][j] = bc.Ngay1 ;
                    xlWorkSheet.Cells[5][j] =bc.Ngay2 ;
                    xlWorkSheet.Cells[6][j] =bc.Ngay3;
                    xlWorkSheet.Cells[7][j] =bc.Ngay4 ;
                    xlWorkSheet.Cells[8][j] =bc.Ngay5;
                    xlWorkSheet.Cells[9][j] =bc.Ngay6 ;
                    xlWorkSheet.Cells[10][j] =bc.Ngay7;
                    xlWorkSheet.Cells[11][j] =bc.Ngay8 ;
                    xlWorkSheet.Cells[12][j] =bc.Ngay9 ;
                    xlWorkSheet.Cells[13][j] =bc.Ngay10 ;
                    xlWorkSheet.Cells[14][j] =bc.Ngay11 ;
                    xlWorkSheet.Cells[15][j] =bc.Ngay12;
                    xlWorkSheet.Cells[16][j] =bc.Ngay13;
                    xlWorkSheet.Cells[17][j] =bc.Ngay14;
                    xlWorkSheet.Cells[18][j] =bc.Ngay15;
                    xlWorkSheet.Cells[19][j] =bc.Ngay16;
                    xlWorkSheet.Cells[20][j] =bc.Ngay17;
                    xlWorkSheet.Cells[21][j] =bc.Ngay18;
                    xlWorkSheet.Cells[22][j] =bc.Ngay19;
                    xlWorkSheet.Cells[23][j] =bc.Ngay20;
                    xlWorkSheet.Cells[24][j] =bc.Ngay21;
                    xlWorkSheet.Cells[25][j] =bc.Ngay22;
                    xlWorkSheet.Cells[26][j] =bc.Ngay23;
                    xlWorkSheet.Cells[27][j] =bc.Ngay24;
                    xlWorkSheet.Cells[28][j] =bc.Ngay25;
                    xlWorkSheet.Cells[29][j] =bc.Ngay26;
                    xlWorkSheet.Cells[30][j] =bc.Ngay27;
                    xlWorkSheet.Cells[31][j] =bc.Ngay28;
                    xlWorkSheet.Cells[32][j] =bc.Ngay29;
                    xlWorkSheet.Cells[33][j] =bc.Ngay30;
                    xlWorkSheet.Cells[34][j] =bc.Ngay31;
                    xlWorkSheet.Cells[35][j] =bc.Sl_ngaythuong;
                    xlWorkSheet.Cells[36][j] =bc.Sl_ngaycn;


                    j++;
                }
                wb.SaveAs(saveFileDialog1.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);
                wb.Close(false, Type.Missing, Type.Missing);
                app.Quit();
                System.Diagnostics.Process.Start(saveFileDialog1.FileName);



            }
        }
    }
}