namespace QuanLy
{
    partial class fChucVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChucVu));
            this.Grid_ChucVu = new DevExpress.XtraGrid.GridControl();
            this.chucVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DeleteBtnChucVu = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.btnEditChucVu = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddChucVu = new DevExpress.XtraEditors.SimpleButton();
            this.NameChucVuTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.IdChucVuTextEdit = new DevExpress.XtraEditors.SpinEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForIdChucVu = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNameChucVu = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucVuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBtnChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NameChucVuTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdChucVuTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNameChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_ChucVu
            // 
            this.Grid_ChucVu.DataSource = this.chucVuBindingSource;
            this.Grid_ChucVu.Location = new System.Drawing.Point(12, 12);
            this.Grid_ChucVu.MainView = this.gridView1;
            this.Grid_ChucVu.Name = "Grid_ChucVu";
            this.Grid_ChucVu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.DeleteBtnChucVu});
            this.Grid_ChucVu.Size = new System.Drawing.Size(434, 228);
            this.Grid_ChucVu.TabIndex = 0;
            this.Grid_ChucVu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // chucVuBindingSource
            // 
            this.chucVuBindingSource.DataSource = typeof(QuanLyCafe.ChucVu);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdChucVu,
            this.colNameChucVu,
            this.colDelete});
            this.gridView1.GridControl = this.Grid_ChucVu;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdChucVu
            // 
            this.colIdChucVu.FieldName = "IdChucVu";
            this.colIdChucVu.Name = "colIdChucVu";
            this.colIdChucVu.Visible = true;
            this.colIdChucVu.VisibleIndex = 0;
            this.colIdChucVu.Width = 85;
            // 
            // colNameChucVu
            // 
            this.colNameChucVu.FieldName = "NameChucVu";
            this.colNameChucVu.Name = "colNameChucVu";
            this.colNameChucVu.Visible = true;
            this.colNameChucVu.VisibleIndex = 1;
            this.colNameChucVu.Width = 649;
            // 
            // colDelete
            // 
            this.colDelete.Caption = "Delete";
            this.colDelete.ColumnEdit = this.DeleteBtnChucVu;
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 2;
            // 
            // DeleteBtnChucVu
            // 
            this.DeleteBtnChucVu.AutoHeight = false;
            this.DeleteBtnChucVu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.DeleteBtnChucVu.Name = "DeleteBtnChucVu";
            this.DeleteBtnChucVu.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.DeleteBtnChucVu.Click += new System.EventHandler(this.DeleteBtnChucVu_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dataLayoutControl1);
            this.layoutControl1.Controls.Add(this.layoutControl2);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup2;
            this.layoutControl1.Size = new System.Drawing.Size(482, 380);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.btnEditChucVu);
            this.dataLayoutControl1.Controls.Add(this.btnAddChucVu);
            this.dataLayoutControl1.Controls.Add(this.NameChucVuTextEdit);
            this.dataLayoutControl1.Controls.Add(this.IdChucVuTextEdit);
            this.dataLayoutControl1.DataSource = this.chucVuBindingSource;
            this.dataLayoutControl1.Location = new System.Drawing.Point(12, 12);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(458, 100);
            this.dataLayoutControl1.TabIndex = 5;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // btnEditChucVu
            // 
            this.btnEditChucVu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEditChucVu.ImageOptions.SvgImage")));
            this.btnEditChucVu.Location = new System.Drawing.Point(249, 52);
            this.btnEditChucVu.Name = "btnEditChucVu";
            this.btnEditChucVu.Size = new System.Drawing.Size(197, 36);
            this.btnEditChucVu.StyleController = this.dataLayoutControl1;
            this.btnEditChucVu.TabIndex = 6;
            this.btnEditChucVu.Text = "Sửa tên chức vụ";
            this.btnEditChucVu.Click += new System.EventHandler(this.btnEditChucVu_Click);
            // 
            // btnAddChucVu
            // 
            this.btnAddChucVu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddChucVu.ImageOptions.SvgImage")));
            this.btnAddChucVu.Location = new System.Drawing.Point(249, 12);
            this.btnAddChucVu.Name = "btnAddChucVu";
            this.btnAddChucVu.Size = new System.Drawing.Size(197, 36);
            this.btnAddChucVu.StyleController = this.dataLayoutControl1;
            this.btnAddChucVu.TabIndex = 5;
            this.btnAddChucVu.Text = "Thêm Chức Vụ";
            this.btnAddChucVu.Click += new System.EventHandler(this.btnAddChucVu_Click);
            // 
            // NameChucVuTextEdit
            // 
            this.NameChucVuTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.chucVuBindingSource, "NameChucVu", true));
            this.NameChucVuTextEdit.Location = new System.Drawing.Point(93, 36);
            this.NameChucVuTextEdit.Name = "NameChucVuTextEdit";
            this.NameChucVuTextEdit.Size = new System.Drawing.Size(152, 20);
            this.NameChucVuTextEdit.StyleController = this.dataLayoutControl1;
            this.NameChucVuTextEdit.TabIndex = 5;
            // 
            // IdChucVuTextEdit
            // 
            this.IdChucVuTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.chucVuBindingSource, "IdChucVu", true));
            this.IdChucVuTextEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.IdChucVuTextEdit.Location = new System.Drawing.Point(93, 12);
            this.IdChucVuTextEdit.Name = "IdChucVuTextEdit";
            this.IdChucVuTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.IdChucVuTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IdChucVuTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IdChucVuTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.IdChucVuTextEdit.Properties.Mask.EditMask = "N0";
            this.IdChucVuTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.IdChucVuTextEdit.Size = new System.Drawing.Size(50, 20);
            this.IdChucVuTextEdit.StyleController = this.dataLayoutControl1;
            this.IdChucVuTextEdit.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(458, 100);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForIdChucVu,
            this.ItemForNameChucVu,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(438, 80);
            // 
            // ItemForIdChucVu
            // 
            this.ItemForIdChucVu.Control = this.IdChucVuTextEdit;
            this.ItemForIdChucVu.Location = new System.Drawing.Point(0, 0);
            this.ItemForIdChucVu.Name = "ItemForIdChucVu";
            this.ItemForIdChucVu.Size = new System.Drawing.Size(135, 24);
            this.ItemForIdChucVu.Text = "Id Chuc Vu";
            this.ItemForIdChucVu.TextSize = new System.Drawing.Size(69, 13);
            // 
            // ItemForNameChucVu
            // 
            this.ItemForNameChucVu.Control = this.NameChucVuTextEdit;
            this.ItemForNameChucVu.Location = new System.Drawing.Point(0, 24);
            this.ItemForNameChucVu.Name = "ItemForNameChucVu";
            this.ItemForNameChucVu.Size = new System.Drawing.Size(237, 56);
            this.ItemForNameChucVu.Text = "Name Chuc Vu";
            this.ItemForNameChucVu.TextSize = new System.Drawing.Size(69, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnAddChucVu;
            this.layoutControlItem2.Location = new System.Drawing.Point(237, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(201, 40);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnEditChucVu;
            this.layoutControlItem5.Location = new System.Drawing.Point(237, 40);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(201, 40);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(135, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(102, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.Grid_ChucVu);
            this.layoutControl2.Location = new System.Drawing.Point(12, 116);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup3;
            this.layoutControl2.Size = new System.Drawing.Size(458, 252);
            this.layoutControl2.TabIndex = 4;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4});
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(458, 252);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.Grid_ChucVu;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(438, 232);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem1});
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(482, 380);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.layoutControl2;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 104);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(462, 256);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dataLayoutControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(462, 104);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // fChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 380);
            this.Controls.Add(this.layoutControl1);
            this.Name = "fChucVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Chức Vụ";
            this.Load += new System.EventHandler(this.fChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucVuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBtnChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NameChucVuTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdChucVuTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNameChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl Grid_ChucVu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn colNameChucVu;
        private System.Windows.Forms.BindingSource chucVuBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit DeleteBtnChucVu;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnEditChucVu;
        private DevExpress.XtraEditors.SimpleButton btnAddChucVu;
        private DevExpress.XtraEditors.TextEdit NameChucVuTextEdit;
        private DevExpress.XtraEditors.SpinEdit IdChucVuTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdChucVu;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNameChucVu;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}