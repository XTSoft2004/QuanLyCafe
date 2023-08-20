namespace QuanLyCafe.QLySanPham
{
    partial class AddLinkImage
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
            this.LinkImage = new DevExpress.XtraEditors.TextEdit();
            this.btnAddImage = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.LinkImage.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(112, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Link ảnh sản phẩm:";
            // 
            // LinkImage
            // 
            this.LinkImage.Location = new System.Drawing.Point(130, 22);
            this.LinkImage.Name = "LinkImage";
            this.LinkImage.Size = new System.Drawing.Size(330, 20);
            this.LinkImage.TabIndex = 0;
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(304, 54);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(156, 34);
            this.btnAddImage.TabIndex = 2;
            this.btnAddImage.Text = "Thêm ảnh sản phẩm";
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(130, 54);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(156, 34);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Hủy bỏ";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // AddLinkImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 100);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.LinkImage);
            this.Name = "AddLinkImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm link ảnh của sản phẩm";
            this.Load += new System.EventHandler(this.AddLinkImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LinkImage.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit LinkImage;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAddImage;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}