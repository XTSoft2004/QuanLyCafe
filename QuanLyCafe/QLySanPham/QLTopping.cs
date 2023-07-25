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
    public partial class QLTopping : DevExpress.XtraEditors.XtraForm
    {
        public int IdSanPham { get; set; }
        public QLTopping(int idsanpham)
        {
            InitializeComponent();
            IdSanPham = idsanpham;
        }

        private void QLTopping_Load(object sender, EventArgs e)
        {
            LoadAllTopping();
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
                    //gridColumn1.FieldName = topping.IdTopping;
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
    }
}