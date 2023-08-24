using DevExpress.Utils.Svg;
using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using QuanLyCafe.Helper;
using QuanLyCafe.OrderSanPham;
using QuanLyCafe.QLHoaDon;
using QuanLyCafe.QLNhanVien;
using QuanLyCafe.QuanLyBan;
using QuanLyCafe.TongQuan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static QuanLyCafe.Helper.Helper_ShowNoti;

namespace QuanLyCafe
{
    public partial class fMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public AccountLogin InfoLogin { get; set; }
        public fMain(AccountLogin infologin = null)
        {
            InitializeComponent();
            Noti_Single.HtmlElementMouseClick += (s, e) =>
            {
                if (e.ElementId == "okButton" || e.ElementId == "close-button")
                {
                    e.HtmlPopup.Close();
                }
            };
            InfoLogin = infologin;
        }
        private TongQuan.uc_TongQuat uc_HoaDon = new TongQuan.uc_TongQuat();
        private uc_QLSanPham uc_QLSanPham = new uc_QLSanPham();
        private uc_QLNhanVien uc_QLNhanVien = new uc_QLNhanVien();
        private uc_QuanLyBan uc_quanlyban = new uc_QuanLyBan();
        private TongQuan.uc_TongQuat uc_TongQuat = new TongQuan.uc_TongQuat();
        private ThongTinQuan.uc_ThongTinQuan uc_thongtinquan = new ThongTinQuan.uc_ThongTinQuan();
        private void fMain_Load(object sender, EventArgs e)
        {
            //SplashScreenManager.ShowForm(this, typeof(SplashScreenMain), true, true);
            ////SplashScreenManager.Default.SetWaitFormDescription("Đang chờ thanh toán ....");
            //Thread.Sleep(2000);

            //SplashScreenManager.CloseForm();

            Helper_Project.MainControlAdd = MainControlAdd;
            Helper_ShowNoti.svgImages = svgImageCollection1;

            Helper_ShowNoti.ShowThongBao("Chúc bạn một ngày tốt lành", "Làm việc thật tốt nhé <3", SvgImageIcon.Team_Work);

            XtrLogin xtrLogin = new XtrLogin();
            xtrLogin.ShowDialog();
            
            Helper_Project.ShowFormUC(uc_TongQuat);
        }

        private void ControlElementQLSanPham_Click(object sender, EventArgs e)
        {
            Helper_Project.ShowFormUC(uc_QLSanPham);
        }

        private void ControlElementQLNhanVien_Click(object sender, EventArgs e)
        {          
            Helper_Project.ShowFormUC(uc_QLNhanVien);
        }

        private void fluentDesignFormControl1_Click(object sender, EventArgs e)
        {

        }
        private void ControlElementQLBan_Click(object sender, EventArgs e)
        {
            Helper_Project.ShowFormUC(uc_quanlyban);
        }
        public void ShowNotification(string Message, string Title, SvgImageIcon svgImageIcon)
        {
            Helper_ShowNoti.AlertData alertData = new Helper_ShowNoti.AlertData(Message, Title, svgImageIcon);
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

        private void ControlElementQLHoaDon_Click(object sender, EventArgs e)
        {
            Helper_Project.ShowFormUC(uc_HoaDon);
        }

        private void ControlElementThongTinQuan_Click(object sender, EventArgs e)
        {
            Helper_Project.ShowFormUC(uc_thongtinquan);
        }

        private void ControlMenuQLAccount_Click(object sender, EventArgs e)
        {        
            Helper_Project.ShowFormUC(uc_TongQuat);
        }
    }
}
