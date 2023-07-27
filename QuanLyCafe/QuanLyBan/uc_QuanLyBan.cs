using QuanLyCafe.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace QuanLyCafe.QuanLyBan
{
    public partial class uc_QuanLyBan : UserControl
    {
        public uc_QuanLyBan()
        {
            InitializeComponent();
        }
        public static QuanLyCafeEntities db_quanly = new QuanLyCafeEntities();
        public bool _isStopThread = false;
        public static void ClearAllPanel(FlowLayoutPanel flowLayout)
        {
            while (true)
            {
                if (flowLayout.Controls.Count == 0) break;
                foreach (Panel item in flowLayout.Controls)
                {
                    flowLayout.Controls.Remove(item);
                }
            }
        }

        private void btnDeleteAllTable_Click(object sender, EventArgs e)
        {
            int count = db_quanly.QLBans.Count();

            Helper_QuanLyBan.DeleteAllTable();

            Helper_ShowNoti.ShowThongBao("Xóa tất cả bàn", $"Xóa {count} bàn thành công !!", Helper_ShowNoti.SvgImageIcon.Success);
        }

        private void btnCreateBan_Click(object sender, EventArgs e)
        {
            var result = db_quanly.QLBans.ToList();
            int pos = result.Count + 1;

            for (int i = 1; i <= num_createTable.Value; i++)
            {
                if (Helper_QuanLyBan.AddTable("Bàn " + pos) == false) continue;
                Helper_QuanLyBan.CreateTable(pos, "Bàn " + pos, "Đang trống");
                pos++;
            }

            Helper_ShowNoti.ShowThongBao("Thêm bàn", $"Đã thêm {num_createTable.Value} bàn thành công", Helper_ShowNoti.SvgImageIcon.Success);
        }

        private void uc_QuanLyBan_Load(object sender, EventArgs e)
        {
            (new Thread(() =>
            {
                while (true)
                {
                    if (_isStopThread) return;
                    try
                    {
                        QuanLyCafeEntities db_quanly = new QuanLyCafeEntities();
                        int sum_table = db_quanly.QLBans.Count();
                        int num_hoatdong = db_quanly.QLBans.Where(p => p.TrangThaiBan == "Đang hoạt động").Count();
                        int num_dangtrong = db_quanly.QLBans.Where(p => p.TrangThaiBan == "Đang trống").Count();
                        int num_datban = db_quanly.QLBans.Where(p => p.TrangThaiBan == "Đang được đặt").Count();

                        StatusTableList.Text = $"Tổng: {sum_table} bàn | {num_hoatdong} Bàn Đạng Hoạt Động |  {num_dangtrong} Bàn Đang Trống | {num_datban} Bàn đang được đặt";

                        Thread.Sleep(1000);
                    }
                    catch { }
                }
            })).Start();

            Helper_QuanLyBan.FlowLayoutPanel = fLayoutTable;
            Helper_QuanLyBan.LoadAllTable();
        }
        private void rbAllTable_Click(object sender, EventArgs e)
        {
            List<QLBan> result = uc_QuanLyBan.db_quanly.QLBans.ToList();
            Helper_QuanLyBan.LoadAllTable(result);
        }

        private void rbDangDuocDat_Click(object sender, EventArgs e)
        {
            List<QLBan> result = uc_QuanLyBan.db_quanly.QLBans
                .Where(p=> p.TrangThaiBan == "Đang được đặt")
                .ToList();
            Helper_QuanLyBan.LoadAllTable(result);
        }

        private void rbDangHoatDong_Click(object sender, EventArgs e)
        {
            List<QLBan> result = uc_QuanLyBan.db_quanly.QLBans
                .Where(p => p.TrangThaiBan == "Đang hoạt động")
                .ToList();
            Helper_QuanLyBan.LoadAllTable(result);
        }

        private void rbDangTrong_Click(object sender, EventArgs e)
        {
            List<QLBan> result = uc_QuanLyBan.db_quanly.QLBans
                .Where(p => p.TrangThaiBan == "Đang trống")
                .ToList();
            Helper_QuanLyBan.LoadAllTable(result);
        }
    }
}
