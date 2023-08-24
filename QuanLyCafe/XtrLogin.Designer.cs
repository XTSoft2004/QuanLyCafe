namespace QuanLyCafe
{
    partial class XtrLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtrLogin));
            this.UsernameEdit = new DevExpress.XtraEditors.TextEdit();
            this.PasswordEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.cbRemember = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRemember.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameEdit
            // 
            this.UsernameEdit.Location = new System.Drawing.Point(74, 152);
            this.UsernameEdit.Name = "UsernameEdit";
            this.UsernameEdit.Size = new System.Drawing.Size(210, 20);
            this.UsernameEdit.TabIndex = 0;
            // 
            // PasswordEdit
            // 
            this.PasswordEdit.Location = new System.Drawing.Point(74, 178);
            this.PasswordEdit.Name = "PasswordEdit";
            this.PasswordEdit.Size = new System.Drawing.Size(210, 20);
            this.PasswordEdit.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 155);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Username:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 181);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Password:";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(84, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(149, 132);
            this.pictureEdit1.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(16, 231);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(284, 48);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cbRemember
            // 
            this.cbRemember.Location = new System.Drawing.Point(18, 205);
            this.cbRemember.Name = "cbRemember";
            this.cbRemember.Properties.Caption = "Lưu thông tin username";
            this.cbRemember.Size = new System.Drawing.Size(142, 20);
            this.cbRemember.TabIndex = 6;
            // 
            // XtrLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 291);
            this.Controls.Add(this.cbRemember);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.PasswordEdit);
            this.Controls.Add(this.UsernameEdit);
            this.Name = "XtrLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao diện login";
            this.Load += new System.EventHandler(this.XtrLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsernameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRemember.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit UsernameEdit;
        private DevExpress.XtraEditors.TextEdit PasswordEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.CheckEdit cbRemember;
    }
}