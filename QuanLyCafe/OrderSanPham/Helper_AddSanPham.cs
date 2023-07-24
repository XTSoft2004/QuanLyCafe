using DevExpress.DXTemplateGallery.Extensions;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe.OrderSanPham
{
    internal class Helper_AddSanPham
    {
        public string StrName_Panel { get; set; }
        public string StrNameSanPham { get; set; }
        public decimal StrGiaTienSanPham { get; set; }
        public Image ImageSanPham { get; set; }

        public static FlowLayoutPanel FlowLayoutPanel_SanPham;

        public static BindingSource _ModelAddSanPham;

        public static GridView Grid_SanPham;
        public List<_ModelOrderSanPham> _ListOrder { get; set; }
        public Helper_AddSanPham(ref List<_ModelOrderSanPham> listorder,string Name_Panel, string NameSanPham,decimal GiaTienSanPham,byte[] PathSanPham)
        {
            StrName_Panel = Name_Panel;
            StrNameSanPham = NameSanPham;
            StrGiaTienSanPham = GiaTienSanPham;
            ImageSanPham = Helper_Project.ConverByteToImage(PathSanPham);
            _ListOrder = listorder;
        }
        public void AddPanel()
        {
            Panel pn_Order = new Panel()
            {
                Name = "Panel_Older_" + StrName_Panel,
                Size = new Size(170, 210),
                Dock = DockStyle.Top,
                //BackColor = Color.LightBlue, 
            };
            pn_Order.Click += new EventHandler(btn_AddSanPham);

            PictureBox Pic_SanPham = new PictureBox()
            {
                Name = "Pic_" + StrName_Panel,
                Size = new Size(150, 120),
                //BackColor = Color.White,
                Image = ImageSanPham,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Anchor = AnchorStyles.None,
            };
            Pic_SanPham.Location = new Point((pn_Order.Width - Pic_SanPham.Width) / 2, 10);
            Pic_SanPham.Click += new EventHandler(btn_AddSanPham);

            int cornerRadius = 20; // Bán kính góc bo

            // Tạo hình dạng góc bo
            GraphicsPath roundPath = new GraphicsPath();
            roundPath.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90); // Góc trên bên trái
            roundPath.AddArc(Pic_SanPham.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90); // Góc trên bên phải
            roundPath.AddArc(Pic_SanPham.Width - cornerRadius, Pic_SanPham.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90); // Góc dưới bên phải
            roundPath.AddArc(0, Pic_SanPham.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90); // Góc dưới bên trái
            roundPath.CloseFigure(); // Đóng đường cong

            Pic_SanPham.Region = new Region(roundPath);

            Label label_namesanpham = new Label()
            {
                Name = "lbName_" + StrName_Panel,
                Text = StrNameSanPham,              
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Times New Roman", 10, FontStyle.Bold),             
                Size = new Size(150, 40),
            };
            label_namesanpham.Location = new Point((pn_Order.Width - label_namesanpham.Width) / 2, Pic_SanPham.Height + 10); // Chỉnh sửa vị trí của label
            new ToolTip().SetToolTip(label_namesanpham, StrNameSanPham); //Thêm tool tip vào label

            Label label_giatiensanpham = new Label()
            {
                Name = "lbGia_" + StrName_Panel,
                Text = Helper_Project.ChuyenDoiGiaTriTien(StrGiaTienSanPham) + " VNĐ",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Times New Roman", 10, FontStyle.Bold),
                ForeColor  = Color.Blue,
                Size = new Size(150, 50),
            };
            label_giatiensanpham.Location = new Point((pn_Order.Width - label_giatiensanpham.Width) / 2, Pic_SanPham.Height + 40);// Chỉnh sửa vị trí của label

            pn_Order.Controls.Add(Pic_SanPham);
            pn_Order.Controls.Add(label_namesanpham);
            pn_Order.Controls.Add(label_giatiensanpham);

            FlowLayoutPanel_SanPham.Invoke(new MethodInvoker(delegate ()
            {
                FlowLayoutPanel_SanPham.Controls.Add(pn_Order);
            }));

        }
        private void btn_AddSanPham(object sender, EventArgs e)
        {
            int row = Grid_SanPham.RowCount;
            for(int i = 0; i < row; i++)
            {
                object index = Grid_SanPham.GetRow(i);
                if(index is _ModelOrderSanPham rows)
                {
                    if(rows.NameSanPham == StrNameSanPham)
                    {
                        _ListOrder[i].SoLuong++;
                        _ListOrder[i].TongTien = _ListOrder[i].SoLuong * _ListOrder[i].GiaSanPham;

                        _ModelAddSanPham.DataSource = _ListOrder;
                        Grid_SanPham.RefreshData();
                        return;
                    }
                }
            }

            _ModelOrderSanPham _ModelOrderSanPham = new _ModelOrderSanPham()
            {
                STT = row + 1,
                IdSanPham = Convert.ToInt32(StrName_Panel),
                NameSanPham = StrNameSanPham,
                GiaSanPham = StrGiaTienSanPham,
                SoLuong = 1,
                TongTien = StrGiaTienSanPham,        
                GhiChu = string.Empty,
            };

            _ListOrder.Add(_ModelOrderSanPham);
            _ModelAddSanPham.DataSource = _ListOrder;
            Grid_SanPham.RefreshData();

            //for (int rows = 0; rows < DGV_THANHTOAN.Rows.Count; rows++)
            //{
            //    DataGridViewRow r = DGV_THANHTOAN.Rows[rows];
            //    string NameSanPham = (r.Cells["NameSanPham"].Value == null) ? "" : r.Cells["NameSanPham"].Value.ToString();
            //    if (NameSanPham == StrNameSanPham)
            //    {
            //        DGV_THANHTOAN.Rows[rows].Cells["NumSoLuong"].Value = (Convert.ToInt32(DGV_THANHTOAN.Rows[rows].Cells["NumSoLuong"].Value.ToString()) + 1).ToString();
            //        decimal sum_thanhtoan_now = Convert.ToDecimal(DGV_THANHTOAN.Rows[rows].Cells["num_TinhTong"].Value.ToString().Replace(" VNĐ", "")) + Convert.ToDecimal(StrGiaTienSanPham);
            //        DGV_THANHTOAN.Rows[rows].Cells["num_TinhTong"].Value = Helper_Project.ChuyenDoiGiaTriTien(sum_thanhtoan_now) + " VNĐ";
            //        return;
            //    }
            //}

            //decimal tinh_tien = Convert.ToDecimal(StrGiaTienSanPham);

            //DGV_THANHTOAN.Rows.Add(DGV_THANHTOAN.Rows.Count + 1, StrNameSanPham, 1, Helper_Project.ChuyenDoiGiaTriTien(tinh_tien) + " VNĐ", "", "Delete");
        }
    }
}
