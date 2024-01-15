namespace QLNhanSu
{
    partial class frmDoimatkhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoimatkhau));
            this.txt_passCu = new DevExpress.XtraEditors.TextEdit();
            this.bt_capNhat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lb_loi = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_passMoi = new DevExpress.XtraEditors.TextEdit();
            this.txt_xacNhan = new DevExpress.XtraEditors.TextEdit();
            this.bt_dong = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_passCu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_passMoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_xacNhan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_passCu
            // 
            this.txt_passCu.Location = new System.Drawing.Point(157, 79);
            this.txt_passCu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_passCu.Name = "txt_passCu";
            this.txt_passCu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passCu.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_passCu.Properties.Appearance.Options.UseFont = true;
            this.txt_passCu.Properties.Appearance.Options.UseForeColor = true;
            this.txt_passCu.Properties.MaxLength = 26;
            this.txt_passCu.Properties.PasswordChar = '*';
            this.txt_passCu.Properties.UseSystemPasswordChar = true;
            this.txt_passCu.Size = new System.Drawing.Size(138, 30);
            this.txt_passCu.TabIndex = 0;
            this.txt_passCu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_passCu_KeyDown);
            // 
            // bt_capNhat
            // 
            this.bt_capNhat.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.bt_capNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_capNhat.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt_capNhat.Appearance.Options.UseBackColor = true;
            this.bt_capNhat.Appearance.Options.UseFont = true;
            this.bt_capNhat.Appearance.Options.UseForeColor = true;
            this.bt_capNhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_capNhat.ImageOptions.Image")));
            this.bt_capNhat.Location = new System.Drawing.Point(34, 194);
            this.bt_capNhat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_capNhat.Name = "bt_capNhat";
            this.bt_capNhat.Padding = new System.Windows.Forms.Padding(2);
            this.bt_capNhat.Size = new System.Drawing.Size(127, 28);
            this.bt_capNhat.TabIndex = 3;
            this.bt_capNhat.Text = "Cập nhật";
            this.bt_capNhat.Click += new System.EventHandler(this.bt_capNhat_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(37, 82);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(108, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Mật khẩu hiện tại:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(59, 119);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 17);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Mật khẩu mới:";
            // 
            // lb_loi
            // 
            this.lb_loi.Appearance.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loi.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lb_loi.Appearance.Options.UseFont = true;
            this.lb_loi.Appearance.Options.UseForeColor = true;
            this.lb_loi.Location = new System.Drawing.Point(34, 53);
            this.lb_loi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_loi.Name = "lb_loi";
            this.lb_loi.Size = new System.Drawing.Size(0, 17);
            this.lb_loi.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(34, 156);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(114, 17);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Nhập lại mật khẩu:";
            // 
            // txt_passMoi
            // 
            this.txt_passMoi.Location = new System.Drawing.Point(157, 116);
            this.txt_passMoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_passMoi.Name = "txt_passMoi";
            this.txt_passMoi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passMoi.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_passMoi.Properties.Appearance.Options.UseFont = true;
            this.txt_passMoi.Properties.Appearance.Options.UseForeColor = true;
            this.txt_passMoi.Properties.MaxLength = 26;
            this.txt_passMoi.Properties.PasswordChar = '*';
            this.txt_passMoi.Properties.UseSystemPasswordChar = true;
            this.txt_passMoi.Size = new System.Drawing.Size(138, 30);
            this.txt_passMoi.TabIndex = 1;
            this.txt_passMoi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_passMoi_KeyDown);
            // 
            // txt_xacNhan
            // 
            this.txt_xacNhan.Location = new System.Drawing.Point(157, 153);
            this.txt_xacNhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_xacNhan.Name = "txt_xacNhan";
            this.txt_xacNhan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_xacNhan.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_xacNhan.Properties.Appearance.Options.UseFont = true;
            this.txt_xacNhan.Properties.Appearance.Options.UseForeColor = true;
            this.txt_xacNhan.Properties.MaxLength = 26;
            this.txt_xacNhan.Properties.PasswordChar = '*';
            this.txt_xacNhan.Properties.UseSystemPasswordChar = true;
            this.txt_xacNhan.Size = new System.Drawing.Size(138, 30);
            this.txt_xacNhan.TabIndex = 2;
            this.txt_xacNhan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_xacNhan_KeyDown);
            // 
            // bt_dong
            // 
            this.bt_dong.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.bt_dong.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dong.Appearance.ForeColor = System.Drawing.Color.Red;
            this.bt_dong.Appearance.Options.UseBackColor = true;
            this.bt_dong.Appearance.Options.UseFont = true;
            this.bt_dong.Appearance.Options.UseForeColor = true;
            this.bt_dong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_dong.ImageOptions.Image")));
            this.bt_dong.Location = new System.Drawing.Point(168, 194);
            this.bt_dong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_dong.Name = "bt_dong";
            this.bt_dong.Padding = new System.Windows.Forms.Padding(2);
            this.bt_dong.Size = new System.Drawing.Size(127, 28);
            this.bt_dong.TabIndex = 4;
            this.bt_dong.Text = "Đóng";
            this.bt_dong.Click += new System.EventHandler(this.bt_dong_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(78, 15);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(183, 29);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "ĐỔI MẬT KHẨU";
            // 
            // frmDoimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 238);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.bt_dong);
            this.Controls.Add(this.txt_xacNhan);
            this.Controls.Add(this.txt_passMoi);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.lb_loi);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.bt_capNhat);
            this.Controls.Add(this.txt_passCu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmDoimatkhau.IconOptions.Icon")));
            this.IconOptions.Image = global::QLNhanSu.Properties.Resources.Logo_NEU;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmDoimatkhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmDoimatkhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_passCu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_passMoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_xacNhan.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_passCu;
        private DevExpress.XtraEditors.SimpleButton bt_capNhat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lb_loi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_passMoi;
        private DevExpress.XtraEditors.TextEdit txt_xacNhan;
        private DevExpress.XtraEditors.SimpleButton bt_dong;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}