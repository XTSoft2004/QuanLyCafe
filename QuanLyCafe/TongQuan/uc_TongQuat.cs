using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
//using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyCafe.TongQuan
{
    public partial class uc_TongQuat : DevExpress.XtraEditors.XtraUserControl
    {
        public uc_TongQuat()
        {
            InitializeComponent();
            HtmlAccountNhanVien.ElementMouseClick += (s, e) =>
            {
                if (e.ElementId == "logout")
                {
                    this.Hide();
                    XtrLogin xtrLogin = new XtrLogin();
                    xtrLogin.ShowDialog();
                    this.Show();
                }
            };
        }
        public static AccountLogin InfoLogin = new AccountLogin();
        QuanLyCafeEntities db_quanly = new QuanLyCafeEntities();
        private void LoadAccount()
        {
            string path = Application.StartupPath + "\\DATA\\Account.txt";
            if (File.Exists(path)) UsernameEdit.Text = File.ReadAllText(path);
        }
        private void uc_TongQuan_Load(object sender, EventArgs e)
        {
            LoadChartBarThongKe();
            LoadThongKeNow();
            LoadAccount();
            LoadLogRepositories();
            LoadTable();
            LoadThongKeSanPham();
            LoadThongKeSanPhamTop();
            HtmlAccountNhanVien.DataContext = InfoLogin;
        }
        private void LoadTable()
        {
            ChartTable.Series.Clear();

            Series DanhSachBan = new Series("Danh sách bàn", ViewType.Pie);
            var table = db_quanly.QLBans.ToList();

            int BanTrong = table.Where(p => p.TrangThaiBan == "Đang trống").ToList().Count();
            int BanDat = table.Where(p => p.TrangThaiBan == "Đang được đặt").ToList().Count();
            int BanHoatDong = table.Where(p => p.TrangThaiBan == "Đang hoạt động").ToList().Count();

            Helper_ChartControl.AddSeries(ref DanhSachBan, "Bàn trống", BanTrong, "{A}: {V} bàn");
            Helper_ChartControl.AddSeries(ref DanhSachBan, "Bàn được đặt", BanDat, "{A}: {V} bàn");
            Helper_ChartControl.AddSeries(ref DanhSachBan, "Bàn hoạt động", BanHoatDong, "{A}: {V} bàn");

            ChartTable.Series.Add(DanhSachBan);
            ChartTable.RefreshData();

            lbTotalTable.Text = $"Hiện tại đang có {table.Count} bàn";
        }
        private void LoadLogRepositories()
        {
            List<ShowLog> list = new List<ShowLog>();
            var listlog = db_quanly.LogRepositories
                .OrderByDescending(log => log.DateLog)
                .Take(20)
                .ToList();
            foreach(var item in listlog)
            {
                ShowLog log = new ShowLog()
                {
                    LogText = $"{item.TextLog}",
                    DateLog = item.DateLog.ToString(),
                };
                list.Add(log);
            }
            showLogBindingSource.DataSource = list;
        }
        private void LoadThongKeNow()
        {
            DateTime dateTime1 = DateTime.Now.Date;
            DateTime dateTime2 = DateTime.Now.AddHours(23).AddMinutes(59).AddSeconds(59);

            var item = db_quanly.HoaDons
                .Where(p => p.NgayMua >= dateTime1 && p.NgayMua <= dateTime2)
                .ToList();

            Helper_ThongKe helper_ThongKe = new Helper_ThongKe()
            {
                TienLoi = (item.Sum(p => p.TongTien) - item.Sum(p => p.TotalCost))?.ToString("N3") + " VNĐ",
                DoanhThu = item.Sum(p => p.TongTien).ToString("N3") + " VNĐ",
                SanPham = item.Sum(p => p.ChiTietHoaDons.Sum(n => n.SoLuong)).ToString() + " sản phẩm",
            };
            htmlContentControl1.DataContext = helper_ThongKe;
        }
        private void LoadThongKeSanPham()
        {
            ChartSanPham.Series.Clear();

            DateTime datetime1 = dateEdit1.DateTime.Date;
            DateTime datetime2 = dateEdit2.DateTime.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            var thongke = db_quanly.HoaDons.Where(h => h.NgayMua >= datetime1 && h.NgayMua <= datetime2).ToList();

            ViewType viewType = ViewType.Bar;
            Series Sang = new Series("Buổi sáng", viewType);
            Series Chieu = new Series("Buổi chiều", viewType);
            Series Toi = new Series("Buổi tối", viewType);
            while (true)
            {
                var date1 = datetime1; // Lấy ngày 00:00:00 AM

                var dateSang = datetime1.AddHours(6);
                var dateChieu = dateSang.AddHours(6);
                var dateToi = dateChieu.AddHours(6);
                var dateDem = dateToi.AddHours(6);

                var sang = db_quanly.HoaDons
                    .Where(p => p.NgayMua >= dateSang && p.NgayMua <= dateChieu)
                    .ToList();
                var chieu = db_quanly.HoaDons
                    .Where(p => p.NgayMua >= dateChieu && p.NgayMua <= dateToi)
                    .ToList();
                var toi = db_quanly.HoaDons
                    .Where(p => p.NgayMua >= dateToi && p.NgayMua <= dateDem)
                    .ToList();

                Helper_ChartControl.AddSeries(ref Sang, datetime1.Date.ToString(), sang.Sum(p => p.ChiTietHoaDons.Sum(n => n.SoLuong)), "{A}: {V} bàn");
                Helper_ChartControl.AddSeries(ref Chieu, datetime1.Date.ToString(), chieu.Sum(p => p.ChiTietHoaDons.Sum(n => n.SoLuong)), "{A}: {V} bàn");
                Helper_ChartControl.AddSeries(ref Toi, datetime1.Date.ToString(), toi.Sum(p => p.ChiTietHoaDons.Sum(n => n.SoLuong)), "{A}: {V} bàn");

                if (datetime1.Date >= datetime2.Date) break;
                datetime1 = datetime1.AddDays(1);
            }

            ChartSanPham.Series.Add(Sang);
            ChartSanPham.Series.Add(Chieu);
            ChartSanPham.Series.Add(Toi);

            AxisY axisY = ((XYDiagram)ChartSanPham.Diagram).AxisY;
            axisY.Label.TextPattern = "{V} sản phẩm";
            ChartSanPham.RefreshData();
        }
        private void LoadChartBarThongKe()
        {
            ChartThongKe.Series.Clear();

            DateTime datetime1 = dateEdit1.DateTime.Date;
            DateTime datetime2 = dateEdit2.DateTime.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            var thongke = db_quanly.HoaDons.Where(h => h.NgayMua >= datetime1 && h.NgayMua <= datetime2).ToList();

            ViewType viewType = ViewType.Bar;
            Series LoiNhuan = new Series("Lợi nhuận", ViewType.Bar);
            Series TongTien = new Series("Tổng tiền thu được", viewType);
            //Series TongSanPham = new Series("Tổng sản phẩm", viewType);

            #region Biến tính thống kê sản phẩm 
            decimal? Money_LoiNhuan = 0,Money_TongTien = 0;
            int TongSanPham = 0;
            #endregion

            while (true)
            {
                var date1 = datetime1; // Lấy ngày 00:00:00 AM
                var date2 = datetime1.AddDays(1); // Lấy ngày tiếp theo 00:00:00 AM

                var total = db_quanly.HoaDons
                    .Where(p => p.NgayMua >= date1 && p.NgayMua <= date2)
                    .ToList();

                Money_TongTien += total.Sum(p => p.TongTien);
                Money_LoiNhuan += total.Sum(p => p.TongTien) - total.Sum(p => p.TotalCost);
                TongSanPham += total.Sum(p => p.ChiTietHoaDons.Sum(n => n.SoLuong));

                Helper_ChartControl.AddSeries(ref TongTien, datetime1.Date.ToString(), total.Sum(p => p.TongTien), "{A}: {V:N3} VNĐ");
                Helper_ChartControl.AddSeries(ref LoiNhuan, datetime1.Date.ToString(), total.Sum(p => p.TongTien) - total.Sum(p => p.TotalCost), "{A}: {V:N3} VNĐ");

                if (datetime1.Date >= datetime2.Date) break;
                datetime1 = datetime1.AddDays(1);
            }

            ChartThongKe.Series.Add(LoiNhuan);
            ChartThongKe.Series.Add(TongTien);

            AxisY axisY = ((XYDiagram)ChartThongKe.Diagram).AxisY;
            axisY.Label.TextPattern = "{V:N3} VNĐ";
            ChartThongKe.RefreshData();

            #region thống kê sản phẩm theo ngày đặt
            Helper_ThongKe helper_ThongKe = new Helper_ThongKe()
            {
                TienLoi = Money_TongTien?.ToString("N3") + " VNĐ",
                DoanhThu = Money_LoiNhuan?.ToString("N3") + " VNĐ",
                SanPham = TongSanPham.ToString() + " sản phẩm",
            };
            htmlContentControl1.DataContext = helper_ThongKe;
            #endregion
        }
        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            lbTongQuat.Text = $"Tổng quát doanh thu từ ngày {dateEdit1.DateTime.Date.ToString("dd/MM/yyyy")} đến {dateEdit2.DateTime.Date.ToString("dd/MM/yyyy")}";
            LoadChartBarThongKe();
            //LoadThongKeNow();
            LoadAccount();
            LoadLogRepositories();
            LoadTable();
            LoadThongKeSanPham();
        }
        private void LoadThongKeSanPhamTop()
        {
            List<MenuTop> menuTops = new List<MenuTop>();
            var sanpham = db_quanly.SanPhams.ToList();

            foreach(var item in sanpham)
            {
                var SP = db_quanly.ChiTietHoaDons
                    .Where(p => p.IdSanPham == item.IdSanPham)
                    .ToList();

                MenuTop menu = new MenuTop()
                {
                    Image = item.Image,
                    NameSanPham = item.NameSanPham,
                    GiaSanPham = item.GiaSanPham.ToString("N3") + " VNĐ",
                    SoLuong = SP.Sum(p=> p.SoLuong),
                };

                menuTops.Add(menu);
            }

            menuTopBindingSource.DataSource = menuTops.OrderByDescending(p => p.SoLuong);
            //winExplorerView2.RefreshData();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = UsernameEdit.Text;
            string password = PasswordEdit.Text;

            var account = db_quanly.Accounts
                .Where(p => p.Username == username)
                .FirstOrDefault();
            if (account != null && account.Password == password)
            {
                string NameNhanVien = account.NhanVien.NameNhanVien;

                // Lưu username
                if (cbRemember.Checked)
                {
                    string path = Application.StartupPath + "\\DATA\\Account.txt";
                    if (File.Exists(path)) File.Delete(path);
                    File.WriteAllText(path, username);
                }

                XtraMessageBox.Show("Đăng nhập thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if(account != null && account.Password != password)
            {
                XtraMessageBox.Show("Password không đúng vui lòng kiểm tra lại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XtraMessageBox.Show("Username không tồn tại, vui lòng kiểm tra lại !!!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
