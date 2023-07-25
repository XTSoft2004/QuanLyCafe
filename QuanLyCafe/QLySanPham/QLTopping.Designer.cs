namespace QuanLyCafe.QLySanPham
{
    partial class QLTopping
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Delete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.modelDanhMucToppingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdDanhMuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameDanhMuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.NameToppingTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.listtoppingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IdToppingSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.GiaToppingSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.NameDanhMucComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForIdTopping = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNameTopping = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForGiaTopping = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForNameDanhMuc = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDanhMucToppingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NameToppingTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listtoppingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdToppingSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GiaToppingSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameDanhMucComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdTopping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNameTopping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGiaTopping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNameDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.btnXoa});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "IdTopping";
            this.gridColumn1.FieldName = "IdTopping";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "NameTopping";
            this.gridColumn2.FieldName = "NameTopping";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "GiaTopping";
            this.gridColumn3.FieldName = "GiaTopping";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.ColumnEdit = this.Delete;
            this.btnXoa.FieldName = "btnXoa";
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Visible = true;
            this.btnXoa.VisibleIndex = 2;
            // 
            // Delete
            // 
            this.Delete.AutoHeight = false;
            this.Delete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.Delete.Name = "Delete";
            this.Delete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.modelDanhMucToppingBindingSource;
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Delete});
            this.gridControl1.Size = new System.Drawing.Size(487, 466);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // modelDanhMucToppingBindingSource
            // 
            this.modelDanhMucToppingBindingSource.DataSource = typeof(QuanLyCafe.OrderSanPham._ModelDanhMucTopping);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdDanhMuc,
            this.colNameDanhMuc});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInPrintExport = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdDanhMuc
            // 
            this.colIdDanhMuc.FieldName = "IdDanhMuc";
            this.colIdDanhMuc.Name = "colIdDanhMuc";
            this.colIdDanhMuc.Visible = true;
            this.colIdDanhMuc.VisibleIndex = 1;
            this.colIdDanhMuc.Width = 79;
            // 
            // colNameDanhMuc
            // 
            this.colNameDanhMuc.FieldName = "NameDanhMuc";
            this.colNameDanhMuc.Name = "colNameDanhMuc";
            this.colNameDanhMuc.Visible = true;
            this.colNameDanhMuc.VisibleIndex = 2;
            this.colNameDanhMuc.Width = 383;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dataLayoutControl1);
            this.layoutControl1.Controls.Add(this.layoutControl2);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(535, 634);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.NameToppingTextEdit);
            this.dataLayoutControl1.Controls.Add(this.IdToppingSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.GiaToppingSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.NameDanhMucComboBoxEdit);
            this.dataLayoutControl1.DataSource = this.listtoppingBindingSource;
            this.dataLayoutControl1.Location = new System.Drawing.Point(12, 12);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup2;
            this.dataLayoutControl1.Size = new System.Drawing.Size(511, 116);
            this.dataLayoutControl1.TabIndex = 5;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // NameToppingTextEdit
            // 
            this.NameToppingTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.listtoppingBindingSource, "NameTopping", true));
            this.NameToppingTextEdit.Location = new System.Drawing.Point(101, 36);
            this.NameToppingTextEdit.Name = "NameToppingTextEdit";
            this.NameToppingTextEdit.Size = new System.Drawing.Size(398, 20);
            this.NameToppingTextEdit.StyleController = this.dataLayoutControl1;
            this.NameToppingTextEdit.TabIndex = 5;
            // 
            // listtoppingBindingSource
            // 
            this.listtoppingBindingSource.DataMember = "_list_topping";
            this.listtoppingBindingSource.DataSource = this.modelDanhMucToppingBindingSource;
            // 
            // IdToppingSpinEdit
            // 
            this.IdToppingSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.listtoppingBindingSource, "IdTopping", true));
            this.IdToppingSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.IdToppingSpinEdit.Location = new System.Drawing.Point(101, 12);
            this.IdToppingSpinEdit.Name = "IdToppingSpinEdit";
            this.IdToppingSpinEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.IdToppingSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IdToppingSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IdToppingSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.IdToppingSpinEdit.Properties.Mask.EditMask = "N0";
            this.IdToppingSpinEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.IdToppingSpinEdit.Size = new System.Drawing.Size(398, 20);
            this.IdToppingSpinEdit.StyleController = this.dataLayoutControl1;
            this.IdToppingSpinEdit.TabIndex = 7;
            // 
            // GiaToppingSpinEdit
            // 
            this.GiaToppingSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.listtoppingBindingSource, "GiaTopping", true));
            this.GiaToppingSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.GiaToppingSpinEdit.Location = new System.Drawing.Point(101, 60);
            this.GiaToppingSpinEdit.Name = "GiaToppingSpinEdit";
            this.GiaToppingSpinEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.GiaToppingSpinEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.GiaToppingSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GiaToppingSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.GiaToppingSpinEdit.Properties.Mask.EditMask = "G";
            this.GiaToppingSpinEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.GiaToppingSpinEdit.Size = new System.Drawing.Size(398, 20);
            this.GiaToppingSpinEdit.StyleController = this.dataLayoutControl1;
            this.GiaToppingSpinEdit.TabIndex = 8;
            // 
            // NameDanhMucComboBoxEdit
            // 
            this.NameDanhMucComboBoxEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.modelDanhMucToppingBindingSource, "NameDanhMuc", true));
            this.NameDanhMucComboBoxEdit.Location = new System.Drawing.Point(101, 84);
            this.NameDanhMucComboBoxEdit.Name = "NameDanhMucComboBoxEdit";
            this.NameDanhMucComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NameDanhMucComboBoxEdit.Size = new System.Drawing.Size(398, 20);
            this.NameDanhMucComboBoxEdit.StyleController = this.dataLayoutControl1;
            this.NameDanhMucComboBoxEdit.TabIndex = 9;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForIdTopping,
            this.ItemForNameTopping,
            this.ItemForGiaTopping,
            this.layoutControlGroup3});
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(511, 116);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // ItemForIdTopping
            // 
            this.ItemForIdTopping.Control = this.IdToppingSpinEdit;
            this.ItemForIdTopping.Location = new System.Drawing.Point(0, 0);
            this.ItemForIdTopping.Name = "ItemForIdTopping";
            this.ItemForIdTopping.Size = new System.Drawing.Size(491, 24);
            this.ItemForIdTopping.Text = "Id Topping";
            this.ItemForIdTopping.TextSize = new System.Drawing.Size(77, 13);
            // 
            // ItemForNameTopping
            // 
            this.ItemForNameTopping.Control = this.NameToppingTextEdit;
            this.ItemForNameTopping.Location = new System.Drawing.Point(0, 24);
            this.ItemForNameTopping.Name = "ItemForNameTopping";
            this.ItemForNameTopping.Size = new System.Drawing.Size(491, 24);
            this.ItemForNameTopping.Text = "Name Topping";
            this.ItemForNameTopping.TextSize = new System.Drawing.Size(77, 13);
            // 
            // ItemForGiaTopping
            // 
            this.ItemForGiaTopping.Control = this.GiaToppingSpinEdit;
            this.ItemForGiaTopping.Location = new System.Drawing.Point(0, 48);
            this.ItemForGiaTopping.Name = "ItemForGiaTopping";
            this.ItemForGiaTopping.Size = new System.Drawing.Size(491, 24);
            this.ItemForGiaTopping.Text = "Gia Topping";
            this.ItemForGiaTopping.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.AllowDrawBackground = false;
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForNameDanhMuc});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 72);
            this.layoutControlGroup3.Name = "autoGeneratedGroup0";
            this.layoutControlGroup3.Size = new System.Drawing.Size(491, 24);
            // 
            // ItemForNameDanhMuc
            // 
            this.ItemForNameDanhMuc.Control = this.NameDanhMucComboBoxEdit;
            this.ItemForNameDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.ItemForNameDanhMuc.Name = "ItemForNameDanhMuc";
            this.ItemForNameDanhMuc.Size = new System.Drawing.Size(491, 24);
            this.ItemForNameDanhMuc.Text = "Name Danh Muc";
            this.ItemForNameDanhMuc.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.gridControl1);
            this.layoutControl2.Location = new System.Drawing.Point(12, 132);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(511, 490);
            this.layoutControl2.TabIndex = 4;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(511, 490);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(491, 470);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(535, 634);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.layoutControl2;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(515, 494);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dataLayoutControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(515, 120);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // QLTopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 634);
            this.Controls.Add(this.layoutControl1);
            this.Name = "QLTopping";
            this.Text = "QLTopping";
            this.Load += new System.EventHandler(this.QLTopping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDanhMucToppingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NameToppingTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listtoppingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdToppingSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GiaToppingSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameDanhMucComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdTopping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNameTopping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGiaTopping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNameDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit NameToppingTextEdit;
        private System.Windows.Forms.BindingSource listtoppingBindingSource;
        private System.Windows.Forms.BindingSource modelDanhMucToppingBindingSource;
        private DevExpress.XtraEditors.SpinEdit IdToppingSpinEdit;
        private DevExpress.XtraEditors.SpinEdit GiaToppingSpinEdit;
        private DevExpress.XtraEditors.ComboBoxEdit NameDanhMucComboBoxEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdTopping;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNameTopping;
        private DevExpress.XtraLayout.LayoutControlItem ItemForGiaTopping;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNameDanhMuc;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDanhMuc;
        private DevExpress.XtraGrid.Columns.GridColumn colNameDanhMuc;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn btnXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Delete;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}