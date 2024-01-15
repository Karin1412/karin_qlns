namespace QLNhanSu
{
    partial class frmBaocaoNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaocaoNV));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bt_xem = new DevExpress.XtraEditors.SimpleButton();
            this.bt_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBophan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbChucvu = new System.Windows.Forms.ComboBox();
            this.hopdong_radio = new DevExpress.XtraEditors.RadioGroup();
            this.label3 = new System.Windows.Forms.Label();
            this.baohiem_radio = new DevExpress.XtraEditors.RadioGroup();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.hopdong_radio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baohiem_radio.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(131, 15);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(272, 32);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "BÁO CÁO NHÂN VIÊN";
            // 
            // bt_xem
            // 
            this.bt_xem.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.bt_xem.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xem.Appearance.ForeColor = System.Drawing.Color.White;
            this.bt_xem.Appearance.Options.UseBackColor = true;
            this.bt_xem.Appearance.Options.UseFont = true;
            this.bt_xem.Appearance.Options.UseForeColor = true;
            this.bt_xem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_xem.ImageOptions.Image")));
            this.bt_xem.Location = new System.Drawing.Point(154, 256);
            this.bt_xem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_xem.Name = "bt_xem";
            this.bt_xem.Padding = new System.Windows.Forms.Padding(2);
            this.bt_xem.Size = new System.Drawing.Size(104, 28);
            this.bt_xem.TabIndex = 5;
            this.bt_xem.Text = "Xem";
            // 
            // bt_thoat
            // 
            this.bt_thoat.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.bt_thoat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.Appearance.ForeColor = System.Drawing.Color.White;
            this.bt_thoat.Appearance.Options.UseBackColor = true;
            this.bt_thoat.Appearance.Options.UseFont = true;
            this.bt_thoat.Appearance.Options.UseForeColor = true;
            this.bt_thoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_thoat.ImageOptions.Image")));
            this.bt_thoat.Location = new System.Drawing.Point(266, 256);
            this.bt_thoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Padding = new System.Windows.Forms.Padding(2);
            this.bt_thoat.Size = new System.Drawing.Size(104, 28);
            this.bt_thoat.TabIndex = 6;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bộ phận:";
            // 
            // cmbBophan
            // 
            this.cmbBophan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBophan.FormattingEnabled = true;
            this.cmbBophan.Location = new System.Drawing.Point(112, 25);
            this.cmbBophan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbBophan.Name = "cmbBophan";
            this.cmbBophan.Size = new System.Drawing.Size(280, 24);
            this.cmbBophan.TabIndex = 0;
            this.cmbBophan.SelectedValueChanged += new System.EventHandler(this.cmbBophan_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chức vụ:";
            // 
            // cmbChucvu
            // 
            this.cmbChucvu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChucvu.FormattingEnabled = true;
            this.cmbChucvu.Location = new System.Drawing.Point(112, 63);
            this.cmbChucvu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbChucvu.Name = "cmbChucvu";
            this.cmbChucvu.Size = new System.Drawing.Size(280, 24);
            this.cmbChucvu.TabIndex = 1;
            // 
            // hopdong_radio
            // 
            this.hopdong_radio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hopdong_radio.Location = new System.Drawing.Point(112, 102);
            this.hopdong_radio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hopdong_radio.Name = "hopdong_radio";
            this.hopdong_radio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.hopdong_radio.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Đã có"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Chưa có"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Tất cả")});
            this.hopdong_radio.Size = new System.Drawing.Size(281, 33);
            this.hopdong_radio.TabIndex = 2;
            this.hopdong_radio.SelectedIndexChanged += new System.EventHandler(this.hopdong_radio_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hợp đồng:";
            // 
            // baohiem_radio
            // 
            this.baohiem_radio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.baohiem_radio.Location = new System.Drawing.Point(112, 143);
            this.baohiem_radio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.baohiem_radio.Name = "baohiem_radio";
            this.baohiem_radio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.baohiem_radio.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Đã đóng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Chưa đóng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Tất cả")});
            this.baohiem_radio.Size = new System.Drawing.Size(281, 33);
            this.baohiem_radio.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bảo hiểm:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.baohiem_radio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.hopdong_radio);
            this.groupBox1.Controls.Add(this.cmbChucvu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbBophan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(430, 197);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // frmBaocaoNV
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 300);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_xem);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmBaocaoNV.IconOptions.Icon")));
            this.IconOptions.Image = global::QLNhanSu.Properties.Resources.Logo_NEU;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmBaocaoNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo nhân viên";
            this.Load += new System.EventHandler(this.frmBaocaoNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hopdong_radio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baohiem_radio.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton bt_xem;
        private DevExpress.XtraEditors.SimpleButton bt_thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBophan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbChucvu;
        private DevExpress.XtraEditors.RadioGroup hopdong_radio;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.RadioGroup baohiem_radio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}