using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
namespace QLNhanSu
{
    public partial class frmBangluong : DevExpress.XtraEditors.XtraForm
    {
        public frmBangluong()
        {
            InitializeComponent();
        }
        #region load
        private void frmBangluong_Load(object sender, EventArgs e)
        {
            loadFrom();
        }
        public void loadFrom()
        {
            for (int i = 1; i <= 12; i++)
            {
                cmbThang.Items.Add(i.ToString());
            }
            cmbThang.SelectedItem = DateTime.Now.Month.ToString();
            for (int i = 1990; i <= DateTime.Now.Year; i++)
            {
                cmbNam.Items.Add(i.ToString());
            }
            cmbNam.SelectedItem = DateTime.Now.Year.ToString();
        }
       #endregion

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void xem()
        {
            gridBangluong.DataSource = BUS_Bangluong.selectBangluong(cmbThang.Text, cmbNam.Text);
            lbManv.DataBindings.Clear();
            lbManv.DataBindings.Add("Text", gridBangluong.DataSource, "Mã nhân viên");
        }
        private void btXem_Click(object sender, EventArgs e)
        {
            xem();
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            DataTable bangluongs = BUS_Bangluong.selectBangluong(cmbThang.Text, cmbNam.Text);
            gridBangluong.DataSource = bangluongs;
            lbManv.DataBindings.Clear();
            lbManv.DataBindings.Add("Text", gridBangluong.DataSource, "Mã nhân viên");

            saveFileDialog1.Filter = "excel files (*.xlsx)|*.xlsx | csv files (*.csv)|*.csv";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(1);
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];
                int j = 1;
                xlWorkSheet.Cells[1][j] = "Mã nhân viên";
                xlWorkSheet.Cells[2][j] = "Họ tên";
                xlWorkSheet.Cells[3][j] = "Tên bộ phận";
                xlWorkSheet.Cells[4][j] = "Tiền lương";
                xlWorkSheet.Cells[5][j] = "Tăng ca";
                xlWorkSheet.Cells[6][j] = "Phụ cấp";
                xlWorkSheet.Cells[7][j] = "Tạm ứng";
                xlWorkSheet.Cells[8][j] = "Khấu trừ";
                xlWorkSheet.Cells[9][j] = "Thuế";
                xlWorkSheet.Cells[10][j] = "Thực lãnh";

                j = 2;
                foreach (DataRow row in bangluongs.Rows)
                {

                    xlWorkSheet.Cells[1][j] = row[0].ToString();
                    xlWorkSheet.Cells[2][j] = row[1].ToString();
                    xlWorkSheet.Cells[3][j] = row[2].ToString();
                    xlWorkSheet.Cells[4][j] = row[3].ToString();
                    xlWorkSheet.Cells[5][j] = row[4].ToString();
                    xlWorkSheet.Cells[6][j] = row[5].ToString();
                    xlWorkSheet.Cells[7][j] = row[6].ToString();
                    xlWorkSheet.Cells[8][j] = row[7].ToString();
                    xlWorkSheet.Cells[9][j] = row[8].ToString();
                    xlWorkSheet.Cells[10][j] = row[9].ToString();


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