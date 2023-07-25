using DevExpress.XtraEditors;
using QuanLyCafe.OrderSanPham;
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
    public partial class fTopping : DevExpress.XtraEditors.XtraForm
    {
        public int IdSanPham { get; set; }
        public fTopping(int idsanpham)
        {
            InitializeComponent();
            IdSanPham = idsanpham;
        }
        QuanLyCafeEntities db_quanly = new QuanLyCafeEntities();
        private void LoadAllTopping()
        {
            var list_danhmuc = db_quanly.DanhMucToppings
                .Where(p => p.IdSanPham == IdSanPham)
                .ToList();

            List<_ModelDanhMucTopping> danhMucToppings = new List<_ModelDanhMucTopping>();

            foreach (var danhmuc in list_danhmuc)
            {
                var list_topping = db_quanly.Toppings
                    .Where(p => p.IdDanhMucTopping == danhmuc.IdDanhMucTopping)
                    .Select(p => new { p.IdTopping, p.NameTopping, p.GiaTopping })
                    .ToList();

                List<_ModelAddTopping> _ModelAddToppings = new List<_ModelAddTopping>();
                foreach (var topping in list_topping)
                {
                    _ModelAddTopping item_topping = new _ModelAddTopping()
                    {
                        IdTopping = topping.IdTopping,
                        NameTopping = topping.NameTopping,
                        GiaTopping = topping.GiaTopping,
                    };
                    _ModelAddToppings.Add(item_topping);
                }

                _ModelDanhMucTopping _ModelDanhMucTopping = new _ModelDanhMucTopping()
                {
                    IdDanhMuc = danhmuc.IdDanhMucTopping,
                    NameDanhMuc = danhmuc.NameDanhMuc,
                    _list_topping = _ModelAddToppings,
                };

                danhMucToppings.Add(_ModelDanhMucTopping);
            }

            modelDanhMucToppingBindingSource.DataSource = danhMucToppings;
            gridView1.RefreshData();
        }
        private void fTopping_Load(object sender, EventArgs e)
        {
            LoadAllTopping();

            LoadDanhMucTopping();
        }

        private void btnAddTopping_Click(object sender, EventArgs e)
        {
            if(DanhMucToppingCbb.Text.Contains("_") == false)
            {
                XtraMessageBox.Show("Vui lòng kiểm tra lại tên danh mục","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int iddanhmuc = Convert.ToInt32(DanhMucToppingCbb.Text.Split('_')[0]);

            Topping topping = new Topping()
            {
                NameTopping = NameToppingTextEdit.Text,
                GiaTopping = GiaToppingSpinEdit.Value,
                IdDanhMucTopping = iddanhmuc,
            };

            db_quanly.Toppings.Add(topping);
            db_quanly.SaveChanges();

            Helper_Project.fMain.ShowNotification("Thông báo", "Thêm sản phẩm", $"Đã thêm thành công {NameToppingTextEdit.Text} topping", Helper_Project.svgImages["Success"]);

            LoadAllTopping();
        }

        private void btnDeleteTopping_Click(object sender, EventArgs e)
        {
            int[] indexSelected = gridView1.GetSelectedRows();

            if (XtraMessageBox.Show($"Bạn có muốn xoá topping {indexSelected.Length} dòng không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < indexSelected.Length; i++)
                {
                    int index = indexSelected[i];

                    string IdTopping = gridView1.GetRowCellValue(index, "IdTopping").ToString();
                    string NameTopping = gridView1.GetRowCellValue(index, "NameTopping").ToString();

                    int id = Convert.ToInt32(IdTopping);

                    Topping topping = db_quanly.Toppings.Find(id);
                    db_quanly.Toppings.Remove(topping);
                }

                db_quanly.SaveChanges();

                LoadAllTopping();
            }
        }

        private void btnEditTopping_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(IdToppingTextEdit.Text);

            Topping topping = db_quanly.Toppings.Find(index);
            topping.NameTopping = NameToppingTextEdit.Text;
            topping.GiaTopping = GiaToppingSpinEdit.Value;

            db_quanly.SaveChanges();

            Helper_Project.fMain.ShowNotification("Thông báo", "Chỉnh sửa topping", $"Chỉnh sửa thành công {NameToppingTextEdit.Text} topping", Helper_Project.svgImages["Success"]);

            LoadAllTopping();       
        }

        private void NameToppingTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void LoadDanhMucTopping()
        {
            var result = db_quanly.DanhMucToppings.ToList();

            DanhMucToppingCbb.Properties.Items.Clear();

            foreach(var item in result) {
                DanhMucToppingCbb.Properties.Items.Add($"{item.IdDanhMucTopping}_{item.NameDanhMuc}");
            }
        }
        private void btnAddDanhMuc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DanhMucToppingCbb.Text))
            {
                XtraMessageBox.Show("Chưa nhập tên danh mục, vui lòng xem lại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DanhMucTopping danhmuc = db_quanly.DanhMucToppings
                .Where(p=> p.NameDanhMuc == DanhMucToppingCbb.Text).FirstOrDefault();

            if (danhmuc != null)
            {
                XtraMessageBox.Show($"Tên {DanhMucToppingCbb.Text} đã tồn tại, vui lòng kiểm tra lại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DanhMucTopping danhmuctopping = new DanhMucTopping()
            {
                NameDanhMuc = DanhMucToppingCbb.Text,
                IdSanPham = IdSanPham,
            };

            db_quanly.DanhMucToppings.Add(danhmuctopping);

            db_quanly.SaveChanges();

            Helper_Project.fMain.ShowNotification("Thông báo", "Thêm danh mục", $"Thêm danh mục {DanhMucToppingCbb.Text} thành công !!!", Helper_Project.svgImages["Success"]);

            LoadDanhMucTopping();
        }

        private void btnDeleteDanhMuc_Click(object sender, EventArgs e)
        {
            DanhMucTopping danhmuc = db_quanly.DanhMucToppings
                .Where(p => p.NameDanhMuc == DanhMucToppingCbb.Text)
                .FirstOrDefault();

            if(danhmuc == null)
            {
                XtraMessageBox.Show($"Tên danh mục {DanhMucToppingCbb.Text} không tồn tại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db_quanly.DanhMucToppings.Remove(danhmuc);

            db_quanly.SaveChanges();

            Helper_Project.fMain.ShowNotification("Thông báo", "Xóa danh mục", $"Xóa danh mục {DanhMucToppingCbb.Text} thành công !!!", Helper_Project.svgImages["Success"]);

            LoadDanhMucTopping();
        }
    }
}