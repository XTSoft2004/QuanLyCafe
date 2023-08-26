using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
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

namespace QuanLyCafe.OrderSanPham.Form_Helper
{
    public partial class fAddTopping : DevExpress.XtraEditors.XtraForm
    {
        public int IdSanPham { get; set; }
        public List<_ModelOrderSanPham> _ListTopping = new List<_ModelOrderSanPham>();
        public List<_ModelTopping> toppings = new List<_ModelTopping>();
        QuanLyCafeEntities db_quanly = new QuanLyCafeEntities();
        public fAddTopping(int idSanPham, ref List<_ModelOrderSanPham> listtopping)
        {
            InitializeComponent();
            IdSanPham = idSanPham;
            _ListTopping = listtopping;
        }

        private void fAddTopping_Load(object sender, EventArgs e)
        {
            LoadAllDB();

            var result = db_quanly.DanhMucToppings
                   .Where(p => p.IdSanPham == IdSanPham)
                   .Select(p => p.IdDanhMucTopping)
                   .FirstOrDefault();

            var list_topping = db_quanly.Toppings
                .Where(p=> p.IdDanhMucTopping == result)
                .Select(p => new { p.IdTopping, p.NameTopping, p.GiaTopping, p.Cost })
                .ToList();

            ListTopping.DataSource = list_topping;
            gridView1.RefreshData();
        }
        private void LoadAllDB()
        {
            searchLookUpEdit1.Properties.NullText = "Chọn danh mục";
            var result = db_quanly.DanhMucToppings
                .Where(p => p.IdSanPham == IdSanPham)
                .Select(p => new { p.IdDanhMucTopping, p.NameDanhMuc })
                .ToList();

            searchLookUpEdit1.Properties.DataSource = result;

            int iddanhmuc = Convert.ToInt32(searchLookUpEdit1.EditValue);

            var list_topping = db_quanly.Toppings
                .Where(p => p.IdDanhMucTopping == iddanhmuc)
                .Select(p => new { p.IdTopping, p.NameTopping, p.GiaTopping,p.Cost })
                .ToList();

            ListTopping.DataSource = list_topping;
            gridView1.RefreshData();
        }

        private void AddTopping_Click(object sender, EventArgs e)
        {

            int idtopping = Convert.ToInt32(gridView1.GetFocusedRowCellValue("IdTopping"));
            string nametopping = gridView1.GetFocusedRowCellValue("NameTopping").ToString();
            decimal giatopping = Convert.ToDecimal(gridView1.GetFocusedRowCellValue("GiaTopping"));

            if(toppings.Exists(p=> p.IdTopping == idtopping))
            {
                Helper_ShowNoti.ShowXtraMessageBox($"Topping {nametopping} này đã có trong danh sách rồi !!!", "Thêm Topping", Helper_ShowNoti.IconXtraMessageBox.Error);
                //Helper_ShowNoti.ShowThongBao("Thêm Topping", $"Topping {nametopping} này đã có trong danh sách rồi !!!", Helper_ShowNoti.SvgImageIcon.Error);
                return;
            }

            var topping_choose = db_quanly.Toppings.Where(p=> p.IdTopping == idtopping).FirstOrDefault();

            _ModelTopping topping = new _ModelTopping()
            {
                IdTopping = topping_choose.IdTopping,
                NameTopping = topping_choose.NameTopping,
                GiaTopping = topping_choose.GiaTopping,
                Cost = topping_choose.Cost,
            };

            toppings.Add(topping);

            ToppingBinding.DataSource = toppings;
            gridView2.RefreshData();

            ThemTopping.Text = $"Thêm {gridView2.RowCount} topping";

            Helper_ShowNoti.ShowThongBao("Thêm topping vào danh sách", $"Đã thêm topping {nametopping} thành công !!!", Helper_ShowNoti.SvgImageIcon.Success);
        }

        private void HuyBoTopping_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteTopping_Click(object sender, EventArgs e)
        {
            int index = gridView2.FocusedRowHandle;
            int IdTopping = Convert.ToInt32(gridView2.GetFocusedRowCellValue("IdTopping"));
            _ModelTopping topping = toppings.Where(p => p.IdTopping == IdTopping).FirstOrDefault();
            toppings.Remove(topping);

            ToppingBinding.DataSource = toppings;
            gridView2.RefreshData();

            ThemTopping.Text = $"Thêm {gridView2.RowCount} topping";
        }

        private void ThemTopping_Click(object sender, EventArgs e)
        {
            if(XtraMessageBox.Show($"Bạn muốn thêm {gridView2.RowCount} vào sản phẩm","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                _ModelOrderSanPham _ModelOrderSanPham = _ListTopping
                    .Where(p => p.IdSanPham == IdSanPham).FirstOrDefault();

                _ModelOrderSanPham._list_toppings = toppings;
                
                var sanpham = db_quanly.SanPhams.Where(p => p.IdSanPham == IdSanPham).FirstOrDefault();
                Helper_ShowNoti.ShowThongBao("Thêm topping", $"Đã thêm {gridView2.RowCount} topping vào sản phẩm {sanpham.NameSanPham} thành công !!!", Helper_ShowNoti.SvgImageIcon.Success);

                this.Close();
            }
        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            int iddanhmuc = Convert.ToInt32(searchLookUpEdit1.EditValue);
            var list_topping = db_quanly.Toppings
                .Where(p=> p.IdDanhMucTopping == iddanhmuc)
                .Select(p => new { p.IdTopping, p.NameTopping, p.GiaTopping })
                .ToList();
            ListTopping.DataSource = list_topping;
            gridView1.RefreshData();

        }
    }
}