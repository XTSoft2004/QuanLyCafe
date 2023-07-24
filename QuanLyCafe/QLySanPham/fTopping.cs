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
            var result = db_quanly.Toppings
                .Where(p => p.IdSanPham == IdSanPham)
                .Select(p => new { p.IdTopping, p.NameTopping, p.GiaTopping })
                .ToList();

            toppingBindingSource.DataSource = result;
            gridView1.RefreshData();
        }
        private void fTopping_Load(object sender, EventArgs e)
        {
            LoadAllTopping();
        }

        private void btnAddTopping_Click(object sender, EventArgs e)
        {
            Topping topping = new Topping()
            {
                NameTopping = NameToppingTextEdit.Text,
                GiaTopping = GiaToppingTextEdit.Value,
                IdSanPham = IdSanPham,
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
            topping.GiaTopping = GiaToppingTextEdit.Value;

            db_quanly.SaveChanges();

            Helper_Project.fMain.ShowNotification("Thông báo", "Chỉnh sửa topping", $"Chỉnh sửa thành công {NameToppingTextEdit.Text} topping", Helper_Project.svgImages["Success"]);

            LoadAllTopping();       
        }
    }
}