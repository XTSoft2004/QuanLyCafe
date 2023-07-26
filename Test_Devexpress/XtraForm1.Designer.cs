namespace QuanLyCafe.QLySanPham
{
    partial class XtraForm1
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gv2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdTopping = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NameTopping = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaTopping = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DeleteTopping = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gv1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdDanhMucTopping = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NameDanhMuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteTopping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv1)).BeginInit();
            this.SuspendLayout();
            // 
            // gv2
            // 
            this.gv2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdTopping,
            this.NameTopping,
            this.GiaTopping,
            this.btnXoa});
            this.gv2.GridControl = this.gridControl1;
            this.gv2.Name = "gv2";
            // 
            // IdTopping
            // 
            this.IdTopping.Caption = "IdTopping";
            this.IdTopping.FieldName = "IdTopping";
            this.IdTopping.Name = "IdTopping";
            this.IdTopping.Visible = true;
            this.IdTopping.VisibleIndex = 0;
            // 
            // NameTopping
            // 
            this.NameTopping.Caption = "NameTopping";
            this.NameTopping.FieldName = "NameTopping";
            this.NameTopping.Name = "NameTopping";
            this.NameTopping.Visible = true;
            this.NameTopping.VisibleIndex = 1;
            // 
            // GiaTopping
            // 
            this.GiaTopping.Caption = "GiaTopping";
            this.GiaTopping.FieldName = "GiaTopping";
            this.GiaTopping.Name = "GiaTopping";
            this.GiaTopping.Visible = true;
            this.GiaTopping.VisibleIndex = 2;
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "btnXoa";
            this.btnXoa.ColumnEdit = this.DeleteTopping;
            this.btnXoa.FieldName = "btnXoa";
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Visible = true;
            this.btnXoa.VisibleIndex = 3;
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
            gridLevelNode1.LevelTemplate = this.gv2;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(173, 62);
            this.gridControl1.MainView = this.gv1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.DeleteTopping});
            this.gridControl1.Size = new System.Drawing.Size(539, 426);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv1,
            this.gv2});
            // 
            // gv1
            // 
            this.gv1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdDanhMucTopping,
            this.NameDanhMuc});
            this.gv1.GridControl = this.gridControl1;
            this.gv1.Name = "gv1";
            // 
            // IdDanhMucTopping
            // 
            this.IdDanhMucTopping.Caption = "IdDanhMucTopping";
            this.IdDanhMucTopping.FieldName = "IdDanhMucTopping";
            this.IdDanhMucTopping.Name = "IdDanhMucTopping";
            this.IdDanhMucTopping.Visible = true;
            this.IdDanhMucTopping.VisibleIndex = 0;
            // 
            // NameDanhMuc
            // 
            this.NameDanhMuc.Caption = "NameDanhMuc";
            this.NameDanhMuc.FieldName = "NameDanhMuc";
            this.NameDanhMuc.Name = "NameDanhMuc";
            this.NameDanhMuc.Visible = true;
            this.NameDanhMuc.VisibleIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(56, 508);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(403, 56);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(481, 508);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(403, 56);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "simpleButton2";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 592);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            this.Load += new System.EventHandler(this.XtraForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteTopping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gv1;
        private DevExpress.XtraGrid.Columns.GridColumn IdDanhMucTopping;
        private DevExpress.XtraGrid.Columns.GridColumn NameDanhMuc;
        private DevExpress.XtraGrid.Views.Grid.GridView gv2;
        private DevExpress.XtraGrid.Columns.GridColumn IdTopping;
        private DevExpress.XtraGrid.Columns.GridColumn NameTopping;
        private DevExpress.XtraGrid.Columns.GridColumn GiaTopping;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.Columns.GridColumn btnXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit DeleteTopping;
    }
}