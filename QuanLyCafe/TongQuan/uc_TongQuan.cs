using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe.TongQuan
{
    public partial class uc_TongQuan : DevExpress.XtraEditors.XtraUserControl
    {
        public uc_TongQuan()
        {
            InitializeComponent();
        }

        QuanLyCafeEntities db_quanly = new QuanLyCafeEntities();
        private void uc_TongQuan_Load(object sender, EventArgs e)
        {
            DateTime datetime1 = DateTime.Now.Date;
            DateTime datetime2 = DateTime.Now.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            var thongke = db_quanly.HoaDons.Where(h => h.NgayMua >= datetime1 && h.NgayMua <= datetime2).ToList();

            //int TienLoi = 0;
            //foreach (var h in thongke)
            //{
            //    var sanpham = db_quanly.SanPhams.Where(p => p.IdSanPham)
            //}
            ThongKeMoney _thongkeMoney = new ThongKeMoney()
            {
                TongTien = thongke.Sum(p => p.TongTien),
                
            };
            ChartThongKe.DataSource = ChartThongKe.DataSource;
        }
    }
}
