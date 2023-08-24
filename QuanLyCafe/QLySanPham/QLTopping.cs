using DevExpress.XtraEditors;
using QuanLyCafe.Helper;
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
    public partial class QLTopping : DevExpress.XtraEditors.XtraForm
    {
        public int IdSanPham { get; set; }
        QuanLyCafeEntities db_quanly = new QuanLyCafeEntities();
        public QLTopping(int idSanPham)
        {
            InitializeComponent();
            IdSanPham = idSanPham;
        }

        private void QLTopping_Load(object sender, EventArgs e)
        {
            LoadAllDB();
            LoadAllToppings();
        }
        private void LoadAllToppings()
        {
            var result = db_quanly.DanhMucToppings
                 .Where(p => p.IdSanPham == IdSanPham)
                 .ToList();
            if (result == null) return;
            List<Topping> toppings = new List<Topping>();
            foreach (var item in result)
            {
                var list_topping = db_quanly.Toppings
                    .Where(p => p.IdDanhMucTopping == item.IdDanhMucTopping)
                    .Select(p => new { p.IdTopping, p.NameTopping, p.GiaTopping,p.Cost,p.IdDanhMucTopping })
                    .ToList();
                foreach (var topping in list_topping)
                {
                    Topping t = new Topping()
                    {
                        IdTopping = topping.IdTopping,
                        NameTopping = topping.NameTopping,
                        GiaTopping = topping.GiaTopping,
                        Cost = topping.Cost,
                        IdDanhMucTopping = item.IdDanhMucTopping,
                    };
                    toppings.Add(t);
                }
            }
            toppingBindingSource.DataSource = toppings;
            gridView1.RefreshData();
        }
        private void LoadAllDB()
        {
            NameDanhMucSearchLook.Properties.NullText = "Chọn danh mục";
            var result = db_quanly.DanhMucToppings
                .Where(p=> p.IdSanPham == IdSanPham)
                .Select(p => new { p.IdDanhMucTopping, p.NameDanhMuc })
                .ToList();

            NameDanhMucSearchLook.Properties.DataSource = result;

            int iddanhmuc = Convert.ToInt32(NameDanhMucSearchLook.EditValue);

            var list_topping = db_quanly.Toppings
                .Where(p => p.IdDanhMucTopping == iddanhmuc)
                .Select(p => new { p.IdTopping, p.NameTopping, p.GiaTopping,p.Cost,p.IdDanhMucTopping })
                .ToList();

            toppingBindingSource.DataSource = list_topping;
            gridView1.RefreshData();
        }

        private void NameDanhMucSearchLook_EditValueChanged(object sender, EventArgs e)
        {
            LoadAllDB();
        }

        private void DeleteTopping_Click(object sender, EventArgs e)
        {
            int index = gridView1.FocusedRowHandle;

            int IdTopping = Convert.ToInt32(gridView1.GetRowCellValue(index, "IdTopping"));

            string NameTopping = gridView1.GetRowCellValue(index, "NameTopping").ToString();

            if (XtraMessageBox.Show($"Bạn chắc chắn xóa topping {NameTopping} không ?\n" +
                $"  + Xóa hóa đơn topping có liên quan đến topping này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {

                RemoveTopping(IdTopping);

                Helper_ShowNoti.fMain.ShowNotification("Xóa topping", $"Xóa topping {NameTopping} thành công !!!", Helper_ShowNoti.SvgImageIcon.Success);

                LoadAllDB();
            }
        }

        private void btnAddDanhMuc_Click(object sender, EventArgs e)
        {
            fAddDanhMuc fAddDanhMuc = new fAddDanhMuc(IdSanPham);
            fAddDanhMuc.ShowDialog();

            LoadAllDB();
        }

        private void btnDeleteDanhMuc_Click(object sender, EventArgs e)
        {
            if(NameDanhMucSearchLook.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn danh mục để hiện ra các topping !!!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int iddanhmuc = Convert.ToInt32(NameDanhMucSearchLook.EditValue);
            string NameDanhMuc = db_quanly.DanhMucToppings.Find(iddanhmuc).NameDanhMuc;

            if (XtraMessageBox.Show($"Bạn chắc chắn xóa topping {NameDanhMuc} không ?\n" +
                $"⚠️ Cảnh báo:\n" +
                $"+ Sẽ xóa dữ liệu topping của danh mục {NameDanhMuc}\n" +
                $"+ Sẽ xóa dữ liệu hóa đơn topping của các topping được xóa\n", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {

                var list_topping = db_quanly.Toppings
                    .Where(p => p.IdDanhMucTopping == iddanhmuc)
                    .ToList();

                foreach (var item in list_topping)
                {
                    RemoveTopping(item.IdTopping);
                }

                DanhMucTopping danhmuc = db_quanly.DanhMucToppings.Find(iddanhmuc); // Xóa danh mục
                db_quanly.DanhMucToppings.Remove(danhmuc);
                db_quanly.SaveChanges();

                Helper_ShowNoti.fMain.ShowNotification("Xóa topping", $"Xóa danh mục {NameDanhMuc} thành công !!!", Helper_ShowNoti.SvgImageIcon.Success);

                LoadAllDB();
            }
        }
        private bool CheckingTopping()
        {
            if (string.IsNullOrEmpty(NameToppingTextEdit.Text))
            {
                XtraMessageBox.Show("Bạn chưa nhập tên topping !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (CostSpinEdit.Value > GiaToppingSpinEdit.Value)
            {
                XtraMessageBox.Show("Giá trị Cost lớn hơn giá trị của sản phẩm !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (NameDanhMucSearchLook.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn tên danh mục !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool CheckExistTopping_Name()
        {
            db_quanly = new QuanLyCafeEntities();
            string nametopping = NameToppingTextEdit.Text;
            int iddanhmuc = Convert.ToInt32(NameDanhMucSearchLook.EditValue);
            var toppings = db_quanly.Toppings
                .Where(p => p.IdDanhMucTopping == iddanhmuc)
                .ToList();

            if (toppings.Find(p => p.NameTopping == nametopping) != null) return true;
            else return false;

        }
        private void btnAddTopping_Click(object sender, EventArgs e)
        {
            if (CheckingTopping() == false) return;

            if (!string.IsNullOrEmpty(NameToppingTextEdit.Text) && CheckExistTopping_Name())
            {
                XtraMessageBox.Show("Tên toppings này đã tồn tại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Topping topping = new Topping()
            {
                NameTopping = NameToppingTextEdit.Text,
                GiaTopping = GiaToppingSpinEdit.Value,
                IdDanhMucTopping = Convert.ToInt32(NameDanhMucSearchLook.EditValue),
                Cost = CostSpinEdit.Value == null ? 0 : CostSpinEdit.Value,
            };

            db_quanly.Toppings.Add(topping);

            db_quanly.SaveChanges();

            Helper_ShowNoti.fMain.ShowNotification("Thêm topping", $"Thêm topping {NameToppingTextEdit.Text} thành công !!", Helper_ShowNoti.SvgImageIcon.Success);

            LoadAllDB();
        }

        private void btnEditTopping_Click(object sender, EventArgs e)
        {
            if (CheckingTopping() == false) return;

            Topping topping = db_quanly.Toppings.Find(IdToppingSpinEdit.Value);
            topping.NameTopping = NameToppingTextEdit.Text; 
            topping.GiaTopping = GiaToppingSpinEdit.Value;
            topping.IdDanhMucTopping = Convert.ToInt32(NameDanhMucSearchLook.EditValue);
            topping.Cost = CostSpinEdit.Value;

            db_quanly.SaveChanges();

            Helper_ShowNoti.ShowThongBao("Chỉnh sửa topping", $"Chỉnh sửa {NameToppingTextEdit.Text} thành công !!", Helper_ShowNoti.SvgImageIcon.Success);
       
            LoadAllDB();
        }

        private void btnDeleteMutiTopping_Click(object sender, EventArgs e)
        {
            int[] indexSelected = gridView1.GetSelectedRows();

            if (XtraMessageBox.Show($"Bạn có muốn xoá {indexSelected.Length} topping không ?\n" +
                $"⚠️ Cảnh báo:\n" +
                $"+ Sẽ xóa đi các topping được chọn\n" +
                $"+ Xóa các dữ liệu hóa đơn liên quan đến topping được xóa !!!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < indexSelected.Length; i++)
                {
                    int index = indexSelected[i];

                    string IdTopping = gridView1.GetRowCellValue(index, "IdTopping").ToString();
                    string NameTopping = gridView1.GetRowCellValue(index, "NameTopping").ToString();
                    int id = Convert.ToInt32(IdTopping);

                    RemoveTopping(id);

                    Helper_ShowNoti.ShowThongBao("Xóa Topping", $"Xóa topping {NameTopping} thành công !!!", Helper_ShowNoti.SvgImageIcon.Success);
                }

                db_quanly.SaveChanges();

                LoadAllDB();
            }
        }
        private void RemoveTopping(int IdTopping)
        {
            var hoadontopping = db_quanly.HoaDonToppings
                .Where(p => p.IdTopping == IdTopping)
                .ToList();

            foreach (var hoadon in hoadontopping) db_quanly.HoaDonToppings.Remove(hoadon);

            Topping topping = db_quanly.Toppings.Find(IdTopping);

            db_quanly.Toppings.Remove(topping);

            db_quanly.SaveChanges();
        }
    }
}