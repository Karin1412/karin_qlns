namespace QLNhanSu
{
    partial class frmNhapXuatNhanvienExcel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapXuatNhanvienExcel));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.datagrid_nhanvien_excel = new System.Windows.Forms.DataGridView();
            this.bt_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.bt_thucthi = new DevExpress.XtraEditors.SimpleButton();
            this.cmb_bophan = new System.Windows.Forms.ComboBox();
            this.cmb_luachon = new System.Windows.Forms.ComboBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.XuatNvExcel_group = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_nhanvien_excel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XuatNvExcel_group)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.datagrid_nhanvien_excel);
            this.layoutControl1.Controls.Add(this.bt_thoat);
            this.layoutControl1.Controls.Add(this.bt_thucthi);
            this.layoutControl1.Controls.Add(this.cmb_bophan);
            this.layoutControl1.Controls.Add(this.cmb_luachon);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(479, 135, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(932, 752);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // datagrid_nhanvien_excel
            // 
            this.datagrid_nhanvien_excel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_nhanvien_excel.Location = new System.Drawing.Point(12, 161);
            this.datagrid_nhanvien_excel.Margin = new System.Windows.Forms.Padding(4);
            this.datagrid_nhanvien_excel.Name = "datagrid_nhanvien_excel";
            this.datagrid_nhanvien_excel.RowHeadersWidth = 51;
            this.datagrid_nhanvien_excel.Size = new System.Drawing.Size(908, 579);
            this.datagrid_nhanvien_excel.TabIndex = 10;
            // 
            // bt_thoat
            // 
            this.bt_thoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_thoat.ImageOptions.Image")));
            this.bt_thoat.Location = new System.Drawing.Point(462, 130);
            this.bt_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(458, 27);
            this.bt_thoat.StyleController = this.layoutControl1;
            this.bt_thoat.TabIndex = 6;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click_1);
            // 
            // bt_thucthi
            // 
            this.bt_thucthi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_thucthi.ImageOptions.Image")));
            this.bt_thucthi.Location = new System.Drawing.Point(12, 130);
            this.bt_thucthi.Margin = new System.Windows.Forms.Padding(4);
            this.bt_thucthi.Name = "bt_thucthi";
            this.bt_thucthi.Size = new System.Drawing.Size(446, 27);
            this.bt_thucthi.StyleController = this.layoutControl1;
            this.bt_thucthi.TabIndex = 5;
            this.bt_thucthi.Text = "Thực thi";
            this.bt_thucthi.Click += new System.EventHandler(this.bt_thucthi_Click);
            // 
            // cmb_bophan
            // 
            this.cmb_bophan.AllowDrop = true;
            this.cmb_bophan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_bophan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_bophan.FormattingEnabled = true;
            this.cmb_bophan.Location = new System.Drawing.Point(24, 88);
            this.cmb_bophan.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_bophan.Name = "cmb_bophan";
            this.cmb_bophan.Size = new System.Drawing.Size(884, 25);
            this.cmb_bophan.TabIndex = 6;
            this.cmb_bophan.Visible = false;
            // 
            // cmb_luachon
            // 
            this.cmb_luachon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_luachon.FormattingEnabled = true;
            this.cmb_luachon.Items.AddRange(new object[] {
            "Xuất toàn bộ thông tin nhân viên",
            "Chỉ xuất theo bộ phận",
            "Chỉ xuất theo chức vụ"});
            this.cmb_luachon.Location = new System.Drawing.Point(156, 58);
            this.cmb_luachon.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_luachon.Name = "cmb_luachon";
            this.cmb_luachon.Size = new System.Drawing.Size(752, 25);
            this.cmb_luachon.TabIndex = 5;
            this.cmb_luachon.SelectedValueChanged += new System.EventHandler(this.cmb_luachon_SelectedValueChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.XuatNvExcel_group,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem7});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(932, 752);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // XuatNvExcel_group
            // 
            this.XuatNvExcel_group.AppearanceGroup.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XuatNvExcel_group.AppearanceGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.XuatNvExcel_group.AppearanceGroup.Options.UseFont = true;
            this.XuatNvExcel_group.AppearanceGroup.Options.UseForeColor = true;
            this.XuatNvExcel_group.AppearanceItemCaption.BorderColor = System.Drawing.Color.Yellow;
            this.XuatNvExcel_group.AppearanceItemCaption.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XuatNvExcel_group.AppearanceItemCaption.ForeColor = System.Drawing.Color.Crimson;
            this.XuatNvExcel_group.AppearanceItemCaption.Options.UseBorderColor = true;
            this.XuatNvExcel_group.AppearanceItemCaption.Options.UseFont = true;
            this.XuatNvExcel_group.AppearanceItemCaption.Options.UseForeColor = true;
            this.XuatNvExcel_group.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("XuatNvExcel_group.CaptionImageOptions.Image")));
            this.XuatNvExcel_group.CustomizationFormText = "Nhập nhân viên từ file excel";
            this.XuatNvExcel_group.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.XuatNvExcel_group.Location = new System.Drawing.Point(0, 0);
            this.XuatNvExcel_group.Name = "XuatNvExcel_group";
            this.XuatNvExcel_group.ShowTabPageCloseButton = true;
            this.XuatNvExcel_group.Size = new System.Drawing.Size(912, 118);
            this.XuatNvExcel_group.Text = "Xuất nhân viên từ file excel";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Black;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.cmb_luachon;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(888, 30);
            this.layoutControlItem2.Text = "Chọn cách nhập";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(120, 21);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cmb_bophan;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(888, 30);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            this.layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInCustomization;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.bt_thucthi;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 118);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(450, 31);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.bt_thoat;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(450, 118);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(462, 31);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.datagrid_nhanvien_excel;
            this.layoutControlItem7.CustomizationFormText = "layoutControlItem7";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 149);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(912, 583);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "layoutControlGroup2";
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 239);
            this.layoutControlGroup3.Name = "layoutControlGroup2";
            this.layoutControlGroup3.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup3.Size = new System.Drawing.Size(609, 146);
            // 
            // frmNhapXuatNhanvienExcel
            // 
            this.AllowDrop = true;
            this.AllowMdiBar = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(932, 752);
            this.Controls.Add(this.layoutControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Constantia", 8.25F);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmNhapXuatNhanvienExcel.IconOptions.Icon")));
            this.IconOptions.Image = global::QLNhanSu.Properties.Resources.Logo_NEU;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhapXuatNhanvienExcel";
            this.Text = "Nhập và xuất thông tin nhân viên từ file excel";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_nhanvien_excel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XuatNvExcel_group)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraEditors.SimpleButton bt_thoat;
        private DevExpress.XtraEditors.SimpleButton bt_thucthi;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.DataGridView datagrid_nhanvien_excel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox cmb_bophan;
        private System.Windows.Forms.ComboBox cmb_luachon;
        private DevExpress.XtraLayout.LayoutControlGroup XuatNvExcel_group;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}