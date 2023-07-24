using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyCafe.OrderSanPham;

namespace QuanLyCafe.QuanLyBan
{
    internal class Helper_QuanLyBan
    {
        public static FlowLayoutPanel FlowLayoutPanel;

        public static Color color_DangHoatDong = Color.DarkSeaGreen;
        public static Color color_DangTrong = Color.LightSalmon;
        public static Color color_DangDuocDat = Color.LightPink;

        public static void CreateTable(int id,string nameban,string statusTable)
        {
            Panel panelBan = new Panel()
            {
                Name = "Ban_" + id,
                Size = new Size(300, 150),
            };

            #region Bo Trong Panel

            Panel panelColor = new Panel()
            {
                Size = new Size(250, 120),
                //BackColor = Color.DarkSeaGreen,
            };
            if (statusTable == "Đang hoạt động") panelColor.BackColor = color_DangHoatDong;
            else if (statusTable == "Đang trống") panelColor.BackColor = color_DangTrong;
            else if (statusTable == "Đang được đặt") panelColor.BackColor = color_DangDuocDat;


            int cornerRadius = 30; // Bán kính góc bo

            GraphicsPath roundPath = new GraphicsPath();
            roundPath.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90); // Góc trên bên trái
            roundPath.AddArc(panelColor.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90); // Góc trên bên phải
            roundPath.AddArc(panelColor.Width - cornerRadius, panelColor.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90); // Góc dưới bên phải
            roundPath.AddArc(0, panelColor.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90); // Góc dưới bên trái
            roundPath.CloseFigure(); // Đóng đường cong

            panelColor.Region = new Region(roundPath);

            #endregion

            Label label = new Label()
            {
                Text = nameban,
                Font = new Font("Times New Roman", 17, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(100, 30),
            };


            Label labelTrangThai = new Label()
            {
                Text = statusTable,
                Font = new Font("Times New Roman", 13, FontStyle.Bold),
                ForeColor = Color.White,
                Size = new Size(150, 20),
                Location = new Point(85, 60),
            };

            PictureBox picture = new PictureBox()
            {
                Image = Properties.Resources.active_table,
                Location = new Point(10, 30),
                Size = new Size(55, 50),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Anchor = AnchorStyles.None,
            };


            #region Các Button Bàn

            Panel panelBtn = new Panel()
            {
                Name = nameban,
                BackColor = Color.LightGray,
                Size = new Size(250, 30),
                Location = new Point(0, 90),
            };


            //Button btnDangSuDung = new Button()
            //{
            //    Size = new Size(100, 30),
            //    Location = new Point(0, 0),  // Đặt vị trí cho button nhỏ bên trong p1
            //    Text = "Bàn đang sử dụng",
            //    Font = new Font("Times New Roman", 8),
            //    Name = "btn_DangSuDung_" + id,
            //    //BackColor = Color.Blue,
            //};
            //btnDangSuDung.Click += new EventHandler(btnBanDangSuDung_Click);


            //Button btnBanTrong = new Button()
            //{
            //    Size = new Size(70, 30),
            //    Location = new Point(100, 0),  // Đặt vị trí cho button nhỏ bên trong p1
            //    Text = "Bàn trống",
            //    Font = new Font("Times New Roman", 8),
            //    Name = "btn_BanTrong_" + id,
            //    //BackColor = Color.White,
            //};
            //btnBanTrong.Click += new EventHandler(btnBanTrong_Click);

            Button btnDuocDat = new Button()
            {
                Size = new Size(120, 30),
                Location = new Point(3, 0),  // Đặt vị trí cho button nhỏ bên trong p1
                Text = "Bàn đặt",
                Font = new Font("Times New Roman", 8),
                Name = "btn_ChuaSuDung_" + id,
                //BackColor = Color.LightPink,
            };
            btnDuocDat.Click += new EventHandler(btnBanDuocDat_Click);

            Button btnOrder = new Button()
            {
                Size = new Size(125, 30),
                Location = new Point(123, 0),  // Đặt vị trí cho button nhỏ bên trong p1
                Text = "Order",
                Font = new Font("Times New Roman", 8),
                Name = "btn_Order_" + id,
                //BackColor = Color.LightPink,
            };
            btnOrder.Click += new EventHandler(btnOrderBan_Click);

            //panelBtn.Controls.Add(btnDangSuDung);
            panelBtn.Controls.Add(btnDuocDat);
            panelBtn.Controls.Add(btnOrder);
            //panelBtn.Controls.Add(btnBanTrong);

            #endregion

            panelColor.Controls.Add(labelTrangThai);
            panelColor.Controls.Add(panelBtn);
            panelColor.Controls.Add(label);
            panelColor.Controls.Add(picture);


            panelBan.Controls.Add(panelColor);


            FlowLayoutPanel.Controls.Add(panelBan);
        }
        private static void btnOrderBan_Click(object sender, EventArgs e)
        {
            Button btn_click = (Button)sender;
            string nameban = btn_click.Name;
            int idban = Convert.ToInt32(nameban.Split('_')[2]);
            uc_OrderSanPham uc_OrderSanPham = new uc_OrderSanPham(idban);
            Helper_Project.ShowFormUC(uc_OrderSanPham);
        }
        private static void btnBanDangSuDung_Click(object sender, EventArgs e)
        {
            Button btn_click = (Button)sender;

            Panel panel_click = (Panel)btn_click.Parent;
            string id = panel_click.Name;

            EditStatusTable(id, Status_Table.Ban_Dang_Hoat_Dong);
        }
        private static void btnBanTrong_Click(object sender, EventArgs e)
        {
            Button btn_click = (Button)sender;

            Panel panel_click = (Panel)btn_click.Parent;
            string id = panel_click.Name;
            EditStatusTable(id, Status_Table.Ban_Trong);
        }
        private static void btnBanDuocDat_Click(object sender, EventArgs e)
        {
            Button btn_click = (Button)sender;

            Panel panel_click = (Panel)btn_click.Parent;
            string id = panel_click.Name;
            EditStatusTable(id, Status_Table.Ban_Duoc_Dat);
        }
        private enum Status_Table
        {
            Ban_Dang_Hoat_Dong,
            Ban_Trong,
            Ban_Duoc_Dat,
        };
        private static void EditStatusTable(string nameban, Status_Table status_table)
        {
            QLBan qLBan = uc_QuanLyBan.db_quanly.QLBans
                .Where(p => p.NameBan == nameban).FirstOrDefault();
            switch (status_table)
            {
                case Status_Table.Ban_Dang_Hoat_Dong:
                    qLBan.TrangThaiBan = "Đang hoạt động";
                    break;
                case Status_Table.Ban_Trong:
                    qLBan.TrangThaiBan = "Đang trống";
                    break;
                case Status_Table.Ban_Duoc_Dat:
                    qLBan.TrangThaiBan = "Đang được đặt";
                    break;
            }
            uc_QuanLyBan.db_quanly.SaveChanges();

            LoadAllTable();
        }
        public static void LoadAllTable()
        {
            uc_QuanLyBan.ClearAllPanel(FlowLayoutPanel);

            var result = uc_QuanLyBan.db_quanly.QLBans
                .Select(p => new { p.IdBan, p.NameBan, p.TrangThaiBan }).ToList();

            foreach (var item in result)
            {
                Helper_QuanLyBan.CreateTable(item.IdBan, item.NameBan, item.TrangThaiBan);
            }
        }
        public static void LoadTable(List<QLBan> result)
        {
            uc_QuanLyBan.ClearAllPanel(FlowLayoutPanel);

            foreach (var item in result)
            {
                Helper_QuanLyBan.CreateTable(item.IdBan, item.NameBan, item.TrangThaiBan);
            }
        }
        public static bool AddTable(string nameban)
        {
            List<string> result = uc_QuanLyBan.db_quanly.QLBans
                .Select(p => p.NameBan)
                .ToList();

            if (result.Contains(nameban))
            {
                XtraMessageBox.Show($"{nameban} đã tồn tại !!!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            QLBan qLBan = new QLBan()
            {
                NameBan = nameban,
                TrangThaiBan = "Đang trống",
            };

            uc_QuanLyBan.db_quanly.QLBans.Add(qLBan);
            uc_QuanLyBan.db_quanly.SaveChanges();
            return true;
        }
        public static void DeleteAllTable()
        {
            QuanLyCafeEntities db_quanly = new QuanLyCafeEntities();    
            var result = db_quanly.QLBans.ToList();

            foreach (var item in result)
            {
                QLBan qLBan = item;
                db_quanly.QLBans.Remove(qLBan);
            }

            db_quanly.SaveChanges();
        }
    }
}
