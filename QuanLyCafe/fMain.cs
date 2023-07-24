using DevExpress.Utils.Svg;
using DevExpress.XtraBars;
using QuanLyCafe.OrderSanPham;
using QuanLyCafe.QLNhanVien;
using QuanLyCafe.QuanLyBan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class fMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public fMain()
        {
            InitializeComponent();
            Noti_Single.HtmlElementMouseClick += (s, e) =>
            {
                if (e.ElementId == "okButton")
                {
                    e.HtmlPopup.Close();
                }
            };
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            Helper_Project.MainControlAdd = MainControlAdd;
            Helper_Project.svgImages = svgImageCollection1;
            ShowNotification("Chào mừng bạn", "Chúc bạn một ngày tốt lành", "Làm việc thật tốt nhé <3", Helper_Project.svgImages["team_work"]);

            uc_QuanLyBan uc_quanlyban = new uc_QuanLyBan();
            Helper_Project.ShowFormUC(uc_quanlyban);
        }

        private void ControlElementQLSanPham_Click(object sender, EventArgs e)
        {
            uc_QLSanPham uc_QLSanPham = new uc_QLSanPham();
            Helper_Project.ShowFormUC(uc_QLSanPham);
        }

        private void ControlElementQLNhanVien_Click(object sender, EventArgs e)
        {
            uc_QLNhanVien uc_QLNhanVien = new uc_QLNhanVien();
            Helper_Project.ShowFormUC(uc_QLNhanVien);
        }

        private void fluentDesignFormControl1_Click(object sender, EventArgs e)
        {

        }
        private void ControlElementQLBan_Click(object sender, EventArgs e)
        {
            uc_QuanLyBan uc_quanlyban = new uc_QuanLyBan();
            Helper_Project.ShowFormUC(uc_quanlyban);
        }
        public void ShowNotification(string NewMessage, string Message, string Title, SvgImage MessageIcon)
        {
            Helper_Project.AlertData alertData = new Helper_Project.AlertData(NewMessage, Message, Title, MessageIcon);
            Noti_Single.Show(alertData, this);
        }

        private void ControlElementOrderSanPham_Click(object sender, EventArgs e)
        {
            //uc_OrderSanPham uc_OrderSanPham = new uc_OrderSanPham();
            //Helper_Project.ShowFormUC(uc_OrderSanPham);
        }

        private void fMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Helper_Project.CloseApp("QuanLyCafe");
        }
    }
}
