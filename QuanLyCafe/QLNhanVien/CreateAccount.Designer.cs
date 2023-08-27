namespace QuanLyCafe.QLNhanVien
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnEditAccount = new DevExpress.XtraEditors.SimpleButton();
            this.cbAdmin = new DevExpress.XtraEditors.CheckEdit();
            this.btnSaveAccount = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.PasswordEdit = new DevExpress.XtraEditors.TextEdit();
            this.UsernameEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbAdmin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnEditAccount);
            this.layoutControl1.Controls.Add(this.cbAdmin);
            this.layoutControl1.Controls.Add(this.btnSaveAccount);
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.PasswordEdit);
            this.layoutControl1.Controls.Add(this.UsernameEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(351, 174);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEditAccount.ImageOptions.SvgImage")));
            this.btnEditAccount.Location = new System.Drawing.Point(12, 84);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(327, 36);
            this.btnEditAccount.StyleController = this.layoutControl1;
            this.btnEditAccount.TabIndex = 9;
            this.btnEditAccount.Text = "Chỉnh sửa account";
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // cbAdmin
            // 
            this.cbAdmin.Location = new System.Drawing.Point(12, 60);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Properties.Caption = "Admin ( có thể sửa đổi tất cả mọi thứ )";
            this.cbAdmin.Size = new System.Drawing.Size(327, 20);
            this.cbAdmin.StyleController = this.layoutControl1;
            this.cbAdmin.TabIndex = 8;
            // 
            // btnSaveAccount
            // 
            this.btnSaveAccount.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSaveAccount.ImageOptions.SvgImage")));
            this.btnSaveAccount.Location = new System.Drawing.Point(12, 124);
            this.btnSaveAccount.Name = "btnSaveAccount";
            this.btnSaveAccount.Size = new System.Drawing.Size(170, 38);
            this.btnSaveAccount.StyleController = this.layoutControl1;
            this.btnSaveAccount.TabIndex = 7;
            this.btnSaveAccount.Text = "Lưu Account";
            this.btnSaveAccount.Click += new System.EventHandler(this.btnSaveAccount_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Location = new System.Drawing.Point(186, 124);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 38);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PasswordEdit
            // 
            this.PasswordEdit.Location = new System.Drawing.Point(76, 36);
            this.PasswordEdit.Name = "PasswordEdit";
            this.PasswordEdit.Size = new System.Drawing.Size(263, 20);
            this.PasswordEdit.StyleController = this.layoutControl1;
            this.PasswordEdit.TabIndex = 5;
            // 
            // UsernameEdit
            // 
            this.UsernameEdit.Location = new System.Drawing.Point(76, 12);
            this.UsernameEdit.Name = "UsernameEdit";
            this.UsernameEdit.Size = new System.Drawing.Size(263, 20);
            this.UsernameEdit.StyleController = this.layoutControl1;
            this.UsernameEdit.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(351, 174);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.UsernameEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(331, 24);
            this.layoutControlItem1.Text = "Username:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(52, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.PasswordEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(331, 24);
            this.layoutControlItem2.Text = "Password:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(52, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnCancel;
            this.layoutControlItem3.Location = new System.Drawing.Point(174, 112);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(78, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(157, 42);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnSaveAccount;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 112);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(78, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(174, 42);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cbAdmin;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(331, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnEditAccount;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(331, 40);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 174);
            this.Controls.Add(this.layoutControl1);
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo tài khoản cho nhân viên";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbAdmin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnSaveAccount;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.TextEdit PasswordEdit;
        private DevExpress.XtraEditors.TextEdit UsernameEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.CheckEdit cbAdmin;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton btnEditAccount;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}