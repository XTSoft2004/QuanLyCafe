namespace QuanLyCafe
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.MainControlAdd = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.ControlQuanLy = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ControlMenuQLAccount = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ControlElementQLSanPham = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ControlElementQLBan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ControlElementQLNhanVien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ControlElementQLHoaDon = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ControlElementOrderSanPham = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.htmlTemplateCollection1 = new DevExpress.Utils.Html.HtmlTemplateCollection();
            this.ThongBao = new DevExpress.Utils.Html.HtmlTemplate();
            this.Noti_Single = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainControlAdd
            // 
            this.MainControlAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainControlAdd.Location = new System.Drawing.Point(260, 31);
            this.MainControlAdd.Name = "MainControlAdd";
            this.MainControlAdd.Size = new System.Drawing.Size(1331, 718);
            this.MainControlAdd.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ControlQuanLy,
            this.ControlElementOrderSanPham});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 718);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // ControlQuanLy
            // 
            this.ControlQuanLy.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.ControlMenuQLAccount,
            this.ControlElementQLSanPham,
            this.ControlElementQLBan,
            this.ControlElementQLNhanVien,
            this.ControlElementQLHoaDon});
            this.ControlQuanLy.Expanded = true;
            this.ControlQuanLy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ControlQuanLy.ImageOptions.SvgImage")));
            this.ControlQuanLy.Name = "ControlQuanLy";
            this.ControlQuanLy.Text = "Quản Lý";
            // 
            // ControlMenuQLAccount
            // 
            this.ControlMenuQLAccount.Expanded = true;
            this.ControlMenuQLAccount.ImageOptions.Image = global::QuanLyCafe.Properties.Resources.customer;
            this.ControlMenuQLAccount.Name = "ControlMenuQLAccount";
            this.ControlMenuQLAccount.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ControlMenuQLAccount.Text = "Quản Lý Account";
            // 
            // ControlElementQLSanPham
            // 
            this.ControlElementQLSanPham.ImageOptions.Image = global::QuanLyCafe.Properties.Resources.box;
            this.ControlElementQLSanPham.Name = "ControlElementQLSanPham";
            this.ControlElementQLSanPham.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ControlElementQLSanPham.Text = "Quản Lý Sản Phẩm";
            this.ControlElementQLSanPham.Click += new System.EventHandler(this.ControlElementQLSanPham_Click);
            // 
            // ControlElementQLBan
            // 
            this.ControlElementQLBan.ImageOptions.Image = global::QuanLyCafe.Properties.Resources.table;
            this.ControlElementQLBan.Name = "ControlElementQLBan";
            this.ControlElementQLBan.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ControlElementQLBan.Text = "Quản Lý Bàn";
            this.ControlElementQLBan.Click += new System.EventHandler(this.ControlElementQLBan_Click);
            // 
            // ControlElementQLNhanVien
            // 
            this.ControlElementQLNhanVien.ImageOptions.Image = global::QuanLyCafe.Properties.Resources.team;
            this.ControlElementQLNhanVien.Name = "ControlElementQLNhanVien";
            this.ControlElementQLNhanVien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ControlElementQLNhanVien.Text = "Quản Lý Nhân Viên";
            this.ControlElementQLNhanVien.Click += new System.EventHandler(this.ControlElementQLNhanVien_Click);
            // 
            // ControlElementQLHoaDon
            // 
            this.ControlElementQLHoaDon.ImageOptions.Image = global::QuanLyCafe.Properties.Resources.bill;
            this.ControlElementQLHoaDon.Name = "ControlElementQLHoaDon";
            this.ControlElementQLHoaDon.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ControlElementQLHoaDon.Text = "Quản Lý Hóa Đơn";
            this.ControlElementQLHoaDon.Click += new System.EventHandler(this.ControlElementQLHoaDon_Click);
            // 
            // ControlElementOrderSanPham
            // 
            this.ControlElementOrderSanPham.ImageOptions.Image = global::QuanLyCafe.Properties.Resources.order_sanpham;
            this.ControlElementOrderSanPham.Name = "ControlElementOrderSanPham";
            this.ControlElementOrderSanPham.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ControlElementOrderSanPham.Text = "Order sản phẩm";
            this.ControlElementOrderSanPham.Click += new System.EventHandler(this.ControlElementOrderSanPham_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1591, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.Click += new System.EventHandler(this.fluentDesignFormControl1_Click);
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            // 
            // htmlTemplateCollection1
            // 
            this.htmlTemplateCollection1.AddRange(new DevExpress.Utils.Html.HtmlTemplate[] {
            this.ThongBao});
            // 
            // ThongBao
            // 
            this.ThongBao.Name = "ThongBao";
            this.ThongBao.Styles = resources.GetString("ThongBao.Styles");
            this.ThongBao.Template = resources.GetString("ThongBao.Template");
            // 
            // Noti_Single
            // 
            this.Noti_Single.HtmlImages = this.svgImageCollection1;
            this.Noti_Single.HtmlTemplate.Styles = resources.GetString("Noti_Single.HtmlTemplate.Styles");
            this.Noti_Single.HtmlTemplate.Template = resources.GetString("Noti_Single.HtmlTemplate.Template");
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("Success", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Success"))));
            this.svgImageCollection1.Add("Error", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Error"))));
            this.svgImageCollection1.Add("Error_Fix", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Error_Fix"))));
            this.svgImageCollection1.Add("Warning", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Warning"))));
            this.svgImageCollection1.Add("Close", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Close"))));
            this.svgImageCollection1.Add("Add_Bookmark", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Add_Bookmark"))));
            this.svgImageCollection1.Add("Team_Work", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Team_Work"))));
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1591, 749);
            this.ControlContainer = this.MainControlAdd;
            this.Controls.Add(this.MainControlAdd);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "fMain";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fMain_FormClosed);
            this.Load += new System.EventHandler(this.fMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer MainControlAdd;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlQuanLy;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlMenuQLAccount;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlElementQLSanPham;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlElementQLBan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlElementQLNhanVien;
        private DevExpress.Utils.Html.HtmlTemplateCollection htmlTemplateCollection1;
        private DevExpress.Utils.Html.HtmlTemplate ThongBao;
        private DevExpress.XtraBars.Alerter.AlertControl Noti_Single;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlElementOrderSanPham;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ControlElementQLHoaDon;
    }
}

