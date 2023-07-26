namespace QuanLyCafe.OrderSanPham.Form_Helper
{
    partial class fAddTopping
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.HuyBoTopping = new DevExpress.XtraEditors.SimpleButton();
            this.ThemTopping = new DevExpress.XtraEditors.SimpleButton();
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.danhMucToppingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.ToppingBinding = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTopping1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameTopping1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaTopping1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDeleteTopping = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DeleteTopping = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.ListTopping = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTopping = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameTopping = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaTopping = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAddTopping = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AddTopping = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucToppingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToppingBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteTopping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListTopping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddTopping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.groupControl1);
            this.layoutControl1.Controls.Add(this.searchLookUpEdit1);
            this.layoutControl1.Controls.Add(this.gridControl2);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(980, 476);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.HuyBoTopping);
            this.groupControl1.Controls.Add(this.ThemTopping);
            this.groupControl1.Location = new System.Drawing.Point(388, 347);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(580, 117);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Chọn";
            // 
            // HuyBoTopping
            // 
            this.HuyBoTopping.Location = new System.Drawing.Point(207, 45);
            this.HuyBoTopping.Name = "HuyBoTopping";
            this.HuyBoTopping.Size = new System.Drawing.Size(169, 47);
            this.HuyBoTopping.TabIndex = 1;
            this.HuyBoTopping.Text = "Hủy bỏ";
            this.HuyBoTopping.Click += new System.EventHandler(this.HuyBoTopping_Click);
            // 
            // ThemTopping
            // 
            this.ThemTopping.Location = new System.Drawing.Point(391, 45);
            this.ThemTopping.Name = "ThemTopping";
            this.ThemTopping.Size = new System.Drawing.Size(169, 47);
            this.ThemTopping.TabIndex = 0;
            this.ThemTopping.Text = "Thêm 0 Topping";
            this.ThemTopping.Click += new System.EventHandler(this.ThemTopping_Click);
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.Location = new System.Drawing.Point(75, 12);
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.DataSource = this.danhMucToppingBindingSource;
            this.searchLookUpEdit1.Properties.DisplayMember = "NameDanhMuc";
            this.searchLookUpEdit1.Properties.NullText = "Chọn danh mục";
            this.searchLookUpEdit1.Properties.PopupView = this.searchLookUpEdit1View;
            this.searchLookUpEdit1.Properties.ValueMember = "IdDanhMucTopping";
            this.searchLookUpEdit1.Size = new System.Drawing.Size(309, 20);
            this.searchLookUpEdit1.StyleController = this.layoutControl1;
            this.searchLookUpEdit1.TabIndex = 6;
            // 
            // danhMucToppingBindingSource
            // 
            this.danhMucToppingBindingSource.DataSource = typeof(QuanLyCafe.DanhMucTopping);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.ToppingBinding;
            this.gridControl2.Location = new System.Drawing.Point(388, 12);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.DeleteTopping});
            this.gridControl2.Size = new System.Drawing.Size(580, 331);
            this.gridControl2.TabIndex = 5;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // ToppingBinding
            // 
            this.ToppingBinding.DataSource = typeof(QuanLyCafe.Topping);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTopping1,
            this.colNameTopping1,
            this.colGiaTopping1,
            this.btnDeleteTopping});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdTopping1
            // 
            this.colIdTopping1.FieldName = "IdTopping";
            this.colIdTopping1.Name = "colIdTopping1";
            this.colIdTopping1.Visible = true;
            this.colIdTopping1.VisibleIndex = 0;
            this.colIdTopping1.Width = 59;
            // 
            // colNameTopping1
            // 
            this.colNameTopping1.FieldName = "NameTopping";
            this.colNameTopping1.Name = "colNameTopping1";
            this.colNameTopping1.Visible = true;
            this.colNameTopping1.VisibleIndex = 1;
            this.colNameTopping1.Width = 367;
            // 
            // colGiaTopping1
            // 
            this.colGiaTopping1.DisplayFormat.FormatString = "N3";
            this.colGiaTopping1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colGiaTopping1.FieldName = "GiaTopping";
            this.colGiaTopping1.Name = "colGiaTopping1";
            this.colGiaTopping1.Visible = true;
            this.colGiaTopping1.VisibleIndex = 2;
            this.colGiaTopping1.Width = 129;
            // 
            // btnDeleteTopping
            // 
            this.btnDeleteTopping.Caption = "Xóa";
            this.btnDeleteTopping.ColumnEdit = this.DeleteTopping;
            this.btnDeleteTopping.FieldName = "btnDeleteTopping";
            this.btnDeleteTopping.Name = "btnDeleteTopping";
            this.btnDeleteTopping.Visible = true;
            this.btnDeleteTopping.VisibleIndex = 3;
            // 
            // DeleteTopping
            // 
            this.DeleteTopping.AutoHeight = false;
            this.DeleteTopping.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.DeleteTopping.Name = "DeleteTopping";
            this.DeleteTopping.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.DeleteTopping.Click += new System.EventHandler(this.DeleteTopping_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.ListTopping;
            this.gridControl1.Location = new System.Drawing.Point(12, 36);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.AddTopping});
            this.gridControl1.Size = new System.Drawing.Size(372, 428);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // ListTopping
            // 
            this.ListTopping.DataSource = typeof(QuanLyCafe.Topping);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTopping,
            this.colNameTopping,
            this.colGiaTopping,
            this.btnAddTopping});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdTopping
            // 
            this.colIdTopping.FieldName = "IdTopping";
            this.colIdTopping.Name = "colIdTopping";
            this.colIdTopping.Visible = true;
            this.colIdTopping.VisibleIndex = 0;
            this.colIdTopping.Width = 45;
            // 
            // colNameTopping
            // 
            this.colNameTopping.FieldName = "NameTopping";
            this.colNameTopping.Name = "colNameTopping";
            this.colNameTopping.Visible = true;
            this.colNameTopping.VisibleIndex = 1;
            this.colNameTopping.Width = 132;
            // 
            // colGiaTopping
            // 
            this.colGiaTopping.DisplayFormat.FormatString = "N3";
            this.colGiaTopping.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colGiaTopping.FieldName = "GiaTopping";
            this.colGiaTopping.Name = "colGiaTopping";
            this.colGiaTopping.Visible = true;
            this.colGiaTopping.VisibleIndex = 2;
            this.colGiaTopping.Width = 90;
            // 
            // btnAddTopping
            // 
            this.btnAddTopping.Caption = "Thêm";
            this.btnAddTopping.ColumnEdit = this.AddTopping;
            this.btnAddTopping.FieldName = "btnAddTopping";
            this.btnAddTopping.Name = "btnAddTopping";
            this.btnAddTopping.Visible = true;
            this.btnAddTopping.VisibleIndex = 3;
            this.btnAddTopping.Width = 80;
            // 
            // AddTopping
            // 
            this.AddTopping.AutoHeight = false;
            this.AddTopping.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.AddTopping.Name = "AddTopping";
            this.AddTopping.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.AddTopping.Click += new System.EventHandler(this.AddTopping_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(980, 476);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(376, 432);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl2;
            this.layoutControlItem2.Location = new System.Drawing.Point(376, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(584, 335);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.searchLookUpEdit1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(376, 24);
            this.layoutControlItem3.Text = "Danh mục:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.groupControl1;
            this.layoutControlItem4.Location = new System.Drawing.Point(376, 335);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(584, 121);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // fAddTopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 476);
            this.Controls.Add(this.layoutControl1);
            this.Name = "fAddTopping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm topping vào sản phầm";
            this.Load += new System.EventHandler(this.fAddTopping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucToppingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToppingBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteTopping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListTopping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddTopping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
        private System.Windows.Forms.BindingSource danhMucToppingBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private System.Windows.Forms.BindingSource ToppingBinding;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTopping1;
        private DevExpress.XtraGrid.Columns.GridColumn colNameTopping1;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaTopping1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource ListTopping;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTopping;
        private DevExpress.XtraGrid.Columns.GridColumn colNameTopping;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaTopping;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn btnAddTopping;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit AddTopping;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton HuyBoTopping;
        private DevExpress.XtraEditors.SimpleButton ThemTopping;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn btnDeleteTopping;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit DeleteTopping;
    }
}