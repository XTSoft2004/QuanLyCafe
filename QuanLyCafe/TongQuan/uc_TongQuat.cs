using DevExpress.CodeParser.Diagnostics;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
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
            //htmlContentControl2.

            LoadChartBarThongKe();
            LoadThongKeNow();
            LoadAccount();

            string str = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            List<ShowLog> list = new List<ShowLog>();
            for (int i = 0; i < 4; i++)
            {
                ShowLog log = new ShowLog()
                {
                    LogText = str,
                };
                list.Add(log);
            }
            showLogBindingSource.DataSource = list;
            //GridLog.DataSource = helperThongKeBindingSource;

            //winExplorerView1.RefreshData();
            //LoadChartBarThongKe();
            HtmlAccountNhanVien.DataContext = InfoLogin;
        }
        public class MoneyCoffe
        {
            public MoneyCoffe(decimal? totalCost, decimal? totalMoney)
            {
                TotalCost = totalCost;
                TotalMoney = totalMoney;
            }

            public decimal? TotalCost { get; set; }
            public decimal? TotalMoney { get; set; }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //DateTime datetime1 = dateEdit1.DateTime.Date;
            //DateTime datetime2 = dateEdit1.DateTime.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            //var thongke = db_quanly.HoaDons.Where(h => h.NgayMua >= datetime1 && h.NgayMua <= datetime2).ToList();

            //Series tiennhan


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
                SanPham = item.Count.ToString() + " sản phẩm",
            };
            htmlContentControl1.DataContext = helper_ThongKe;
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
            Series TongSanPham = new Series("Tổng sản phẩm", viewType);

            while (true)
            {

                var date1 = datetime1; // Lấy ngày 00:00:00 AM
                var date2 = datetime1.AddDays(1); // Lấy ngày tiếp theo 00:00:00 AM

                var total = db_quanly.HoaDons
                    .Where(p => p.NgayMua >= date1 && p.NgayMua <= date2)
                    .ToList();


                Helper_ChartControl.AddSeries(ref TongTien, datetime1.Date.ToString(), total.Sum(p => p.TongTien), "{A}: {V:N3} VNĐ");
                Helper_ChartControl.AddSeries(ref LoiNhuan, datetime1.Date.ToString(), total.Sum(p => p.TongTien) - total.Sum(p => p.TotalCost), "{A}: {V:N3} VNĐ");
                Helper_ChartControl.AddSeries(ref TongSanPham, datetime1.Date.ToString(), total.Count, "{A}: {V} sản phẩm");

                if (datetime1.Date >= datetime2.Date) break;
                datetime1 = datetime1.AddDays(1);
            }

            ChartThongKe.Series.Add(LoiNhuan);
            ChartThongKe.Series.Add(TongTien);
            ChartThongKe.Series.Add(TongSanPham);

            AxisY axisY = ((XYDiagram)ChartThongKe.Diagram).AxisY;
            axisY.Label.TextPattern = "{V:N3} VNĐ";
            ChartThongKe.RefreshData();
        }
        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            LoadChartBarThongKe();
            LoadThongKeNow();
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
