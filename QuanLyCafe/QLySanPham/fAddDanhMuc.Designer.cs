namespace QuanLyCafe.QLySanPham
{
    partial class fAddDanhMuc
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.NameDanhMucEditText = new DevExpress.XtraEditors.TextEdit();
            this.btnAddDanhMuc = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.NameDanhMucEditText.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(39, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tên danh mục:";
            // 
            // NameDanhMucEditText
            // 
            this.NameDanhMucEditText.Location = new System.Drawing.Point(116, 12);
            this.NameDanhMucEditText.Name = "NameDanhMucEditText";
            this.NameDanhMucEditText.Size = new System.Drawing.Size(363, 20);
            this.NameDanhMucEditText.TabIndex = 0;
            // 
            // btnAddDanhMuc
            // 
            this.btnAddDanhMuc.Location = new System.Drawing.Point(116, 38);
            this.btnAddDanhMuc.Name = "btnAddDanhMuc";
            this.btnAddDanhMuc.Size = new System.Drawing.Size(190, 48);
            this.btnAddDanhMuc.TabIndex = 2;
            this.btnAddDanhMuc.Text = "Thêm danh mục";
            this.btnAddDanhMuc.Click += new System.EventHandler(this.btnAddDanhMuc_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(312, 38);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(167, 48);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fAddDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 108);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddDanhMuc);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.NameDanhMucEditText);
            this.Name = "fAddDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAddDanhMuc";
            ((System.ComponentModel.ISupportInitialize)(this.NameDanhMucEditText.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit NameDanhMucEditText;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAddDanhMuc;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}