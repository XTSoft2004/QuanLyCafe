namespace QuanLyCafe.OrderSanPham.Form_Helper
{
    partial class fNhanVien
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
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.modelQLNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThongtin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAddNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AddNhanVien = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelQLNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.layoutControl2);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(505, 490);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // modelQLNhanVienBindingSource
            // 
            this.modelQLNhanVienBindingSource.DataSource = typeof(QuanLyCafe.QLNhanVien._Model_QLNhanVien);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.gridControl1);
            this.layoutControl2.Location = new System.Drawing.Point(12, 12);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(481, 466);
            this.layoutControl2.TabIndex = 4;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.modelQLNhanVienBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.AddNhanVien});
            this.gridControl1.Size = new System.Drawing.Size(457, 442);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdNhanVien,
            this.colNameNhanVien,
            this.colNameChucVu,
            this.colThongtin,
            this.btnAddNhanVien});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdNhanVien
            // 
            this.colIdNhanVien.FieldName = "IdNhanVien";
            this.colIdNhanVien.Name = "colIdNhanVien";
            this.colIdNhanVien.Visible = true;
            this.colIdNhanVien.VisibleIndex = 0;
            this.colIdNhanVien.Width = 56;
            // 
            // colNameNhanVien
            // 
            this.colNameNhanVien.FieldName = "NameNhanVien";
            this.colNameNhanVien.Name = "colNameNhanVien";
            this.colNameNhanVien.Visible = true;
            this.colNameNhanVien.VisibleIndex = 1;
            this.colNameNhanVien.Width = 154;
            // 
            // colNameChucVu
            // 
            this.colNameChucVu.FieldName = "NameChucVu";
            this.colNameChucVu.Name = "colNameChucVu";
            this.colNameChucVu.Visible = true;
            this.colNameChucVu.VisibleIndex = 2;
            this.colNameChucVu.Width = 84;
            // 
            // colThongtin
            // 
            this.colThongtin.FieldName = "Thongtin";
            this.colThongtin.Name = "colThongtin";
            this.colThongtin.Visible = true;
            this.colThongtin.VisibleIndex = 3;
            this.colThongtin.Width = 138;
            // 
            // btnAddNhanVien
            // 
            this.btnAddNhanVien.Caption = "Thêm nhân viên";
            this.btnAddNhanVien.ColumnEdit = this.AddNhanVien;
            this.btnAddNhanVien.Name = "btnAddNhanVien";
            this.btnAddNhanVien.Visible = true;
            this.btnAddNhanVien.VisibleIndex = 4;
            // 
            // AddNhanVien
            // 
            this.AddNhanVien.AutoHeight = false;
            this.AddNhanVien.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.AddNhanVien.Name = "AddNhanVien";
            this.AddNhanVien.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.AddNhanVien.Click += new System.EventHandler(this.AddNhanVien_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(481, 466);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(461, 446);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(505, 490);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.layoutControl2;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(485, 470);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // fNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 490);
            this.Controls.Add(this.layoutControl1);
            this.Name = "fNhanVien";
            this.Text = "Thêm Nhân Viên";
            this.Load += new System.EventHandler(this.fNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modelQLNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource modelQLNhanVienBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colNameNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colNameChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn colThongtin;
        private DevExpress.XtraGrid.Columns.GridColumn btnAddNhanVien;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit AddNhanVien;
    }
}