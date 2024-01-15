using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
namespace QLNhanSu
{
    public partial class frmBaocaoNV : DevExpress.XtraEditors.XtraForm
    {
        public frmBaocaoNV()
        {
            InitializeComponent();
        }


        private void frmBaocaoNV_Load(object sender, EventArgs e)
        {
            LoadThongtin();
        }
        private void LoadThongtin()
        {
            // load combobox bo phan
            cmbBophan.Items.Add("Tất cả");
            cmbBophan.SelectedItem = "Tất cả";
            List<DTO.Bophan> bophan = new List<Bophan>();
            bophan = BUS.BUS_Bophan.compoboxBophan();
            for (int i = 0; i < bophan.Count; i++)
            {
                cmbBophan.Items.Add(bophan[i].Tenbophan);
            }
            // load combobox chuc vu
            cmbChucvu.Items.Add("Tất cả");
            cmbChucvu.SelectedItem = "Tất cả";
            List<DTO.ChucVu> chucvu = new List<ChucVu>();
            chucvu = BUS.BUS_Chucvu.selectChucvu();
            for (int i = 0; i < chucvu.Count; i++)
            {
                cmbChucvu.Items.Add(chucvu[i].Tenchucvu);
            }
        }

        private void cmbBophan_SelectedValueChanged(object sender, EventArgs e)
        {

        }

#region report nhan vien
        
      

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
#endregion

        private void hopdong_radio_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}