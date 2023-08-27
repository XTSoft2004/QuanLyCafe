using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using QuanLyCafe;
using QuanLyCafe.Helper;
using QuanLyCafe.QLHoaDon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe.QLySanPham
{
    public partial class fTypeSanPham : DevExpress.XtraEditors.XtraForm
    {
        public fTypeSanPham()
        {
            InitializeComponent();
        }
        QuanLyCafeEntities db_quanly = new QuanLyCafeEntities();
        private void fTypeSanPham_Load(object sender, EventArgs e)
        {
            LoadAllType();
        }
        private void LoadAllType()
        {
            var result = db_quanly.LoaiSanPhams
                .Select(p=> new { p.IdTypeSP,p.NameType}).ToList();
              
            loaiSanPhamBindingSource.DataSource = result;
            gridView1.RefreshData();
        }
        private bool CheckName(string name)
        {
            var result = db_quanly.LoaiSanPhams
                .Select(p=>p.NameType)
                .ToList();

            if (result.Contains(name))
            {
                XtraMessageBox.Show("Loại tên này đã tồn tại vui lòng chọn tên loại khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else return false;
        }
        private void btnAddLoai_Click(object sender, EventArgs e)
        {
            string name = NameTypeTextEdit.Text;

            if (CheckName(name)) return;

            LoaiSanPham loaiSanPham = new LoaiSanPham()
            {
                NameType = name,
            };

            db_quanly.LoaiSanPhams.Add(loaiSanPham);
            db_quanly.SaveChanges();

            Helper_ShowNoti.ShowThongBao("Thông báo", $"Đã thêm danh mục sản phẩm {name} !!!", Helper_ShowNoti.SvgImageIcon.Success);
            LoadAllType();
        }

        private void btnEditLoai_Click(object sender, EventArgs e)
        {
            string name = NameTypeTextEdit.Text;
            int IdTypeSP = Convert.ToInt32(IdTypeSPTextEdit.Value);

            if (CheckName(name)) return;

            LoaiSanPham chucVu = db_quanly.LoaiSanPhams.Find(IdTypeSP);
            string name_old = chucVu.NameType;
            chucVu.NameType = NameTypeTextEdit.Text;

            db_quanly.SaveChanges();
            Helper_ShowNoti.ShowThongBao("Thông báo", $"Chỉnh sửa danh mục sản phẩm {name_old} thành {name} !!!", Helper_ShowNoti.SvgImageIcon.Success);
            LoadAllType();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedRowHandle = gridView1.FocusedRowHandle;

            string NameType = gridView1.GetRowCellValue(selectedRowHandle, "NameType").ToString();
            string IdTypeSP = gridView1.GetRowCellValue(selectedRowHandle, "IdTypeSP").ToString();

            int id = Convert.ToInt32(IdTypeSP);

            var loaiSanPham = db_quanly.LoaiSanPhams
                .Where(p=> p.IdTypeSP == id).FirstOrDefault();

            if (XtraMessageBox.Show($"Bạn có chắc chắn muốn xoá loại {NameType} không ?\n" +
                $"⚠️ Lưu ý:\n" +
                $"+ Xóa toàn bộ sản phẩm ở trong danh mục {NameType} !!!\n" +
                $"+ Xóa toàn bộ danh mục topping và topping được thêm !!\n" +
                $"+ Xóa toàn bộ hóa đơn có liên quan !!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                var sanphams = db_quanly.SanPhams
                    .Where(p => p.IdTypeSP == loaiSanPham.IdTypeSP).ToList();

                foreach(var sanpham in sanphams)
                {
                    RemoveSanPham(sanpham.IdSanPham); // Xóa các thứ liên quan đến sản phẩm

                    db_quanly.SanPhams.Remove(sanpham);
                }

                db_quanly.LoaiSanPhams.Remove(loaiSanPham);
                db_quanly.SaveChanges();

                //XtraMessageBox.Show($"Đã xoá loại {NameType} ra khỏi danh sách !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Helper_ShowNoti.ShowThongBao("Thông báo", $"Đã xoá loại {NameType} ra khỏi danh sách !!!", Helper_ShowNoti.SvgImageIcon.Success);
                LoadAllType();
            }
        }
        private void RemoveSanPham(int IdSanPham)
        {
            #region Xóa danh mục topping và topping
            var DanhMucToppings = db_quanly.DanhMucToppings 
                .Where(p => p.IdSanPham == IdSanPham).ToList();

            foreach (var item in DanhMucToppings)
            {
                var toppings = db_quanly.Toppings
                    .Where(p => p.IdDanhMucTopping == item.IdDanhMucTopping).ToList();

                foreach (var topping in toppings) db_quanly.Toppings.Remove(topping);

                db_quanly.DanhMucToppings.Remove(item);
            }
            #endregion

            var chitiethoadon = db_quanly.ChiTietHoaDons
                .Where(p => p.IdSanPham == IdSanPham).ToList();

            foreach(var item in chitiethoadon)
            {
                var hoadon = db_quanly.HoaDons
                    .Where(p => p.IdHoaDon == item.IdHoaDon).ToList();

                uc_HoaDon uc_HoaDon = new uc_HoaDon();
                uc_HoaDon.Delete_HoaDon(hoadon); // Xóa hóa đơn
            }

        }

        private void btnDeleteMutiTypeSP_Click(object sender, EventArgs e)
        {
            int[] indexSelected = gridView1.GetSelectedRows();

            if (XtraMessageBox.Show($"Bạn có chắc chắn muốn xoá các danh mục sản phẩm không ?\n" +
                $"⚠️ Lưu ý:\n" +
                $"+ Xóa toàn bộ sản phẩm ở trong danh mục sản phẩm !!!\n" +
                $"+ Xóa toàn bộ danh mục topping và topping được thêm !!\n" +
                $"+ Xóa toàn bộ hóa đơn có liên quan !!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < indexSelected.Length; i++)
                {
                    int index = indexSelected[i];
                    int IdTypeSP = Convert.ToInt32(gridView1.GetRowCellValue(index, "IdTypeSP"));
                    string NameType = gridView1.GetRowCellValue(index, "NameType").ToString();

                    var danhmucsp = db_quanly.LoaiSanPhams
                        .Where(p=> p.IdTypeSP == IdTypeSP).FirstOrDefault();

                    var sanphams = db_quanly.SanPhams
                        .Where(p => p.IdTypeSP == IdTypeSP).ToList();

                    foreach (var sanpham in sanphams)
                    {
                        RemoveSanPham(sanpham.IdSanPham); // Xóa các thứ liên quan đến sản phẩm

                        db_quanly.SanPhams.Remove(sanpham);
                    }

                    db_quanly.LoaiSanPhams.Remove(danhmucsp);
                    db_quanly.SaveChanges();

                    Helper_ShowNoti.ShowThongBao("Thông báo", $"Đã xoá loại {NameType} ra khỏi danh sách !!!", Helper_ShowNoti.SvgImageIcon.Success);
                    LoadAllType();
                }
            }

        }
    }
}
