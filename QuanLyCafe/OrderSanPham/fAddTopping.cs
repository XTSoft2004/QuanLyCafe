using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe.OrderSanPham
{
    public partial class fAddTopping : DevExpress.XtraEditors.XtraForm
    {
        public int IdSanPham { get; set; }
        public List<_ModelOrderSanPham> _listsanpham = new List<_ModelOrderSanPham>();
        public fAddTopping(int idsanpham,ref List<_ModelOrderSanPham> _ModelOrderSanPhams)
        {
            InitializeComponent();
            IdSanPham = idsanpham;
            _listsanpham = _ModelOrderSanPhams;
        }
        QuanLyCafeEntities db_quanly = new QuanLyCafeEntities();
        private int Count_Topping = 0;
        private void LoadAllTopping()
        {
            var result = db_quanly.Toppings
                .Where(p=> p.IdSanPham == IdSanPham)
                .Select(p => new { p.IdTopping,p.NameTopping, p.GiaTopping })
                .ToList();

            toppingBindingSource.DataSource = result;
            gridView1.RefreshData();                  
        }
        private void fAddTopping_Load(object sender, EventArgs e)
        {
            LoadAllTopping();
        }
        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            Count_Topping = gridView1.SelectedRowsCount;
            int[] index = gridView1.GetSelectedRows();
            btnAddTopping.Text = $"Thêm {index.Length} topping";
        }
        private void btnAddTopping_Click(object sender, EventArgs e)
        {
            int[] index = gridView1.GetSelectedRows();
            if(index.Length > 0)
            {
                List<_ModelAddTopping> list_topping = new List<_ModelAddTopping>();

                for (int i = 0; i < index.Length; i++)
                {
                    int IdTopping = Convert.ToInt32(gridView1.GetRowCellValue(index[i], "IdTopping"));
                    string NameTopping = gridView1.GetRowCellValue(index[i], "NameTopping").ToString();
                    decimal GiaTopping = Convert.ToDecimal(gridView1.GetRowCellValue(index[i], "GiaTopping"));
                    _ModelAddTopping _ModelAddTopping = new _ModelAddTopping()
                    {
                        IdTopping = IdTopping,
                        NameTopping = NameTopping,
                        GiaTopping = GiaTopping,
                    };
                    list_topping.Add(_ModelAddTopping);
                }

                _ModelOrderSanPham _order = _listsanpham.Find(p => p.IdSanPham == IdSanPham);
                _order.ToppingList = null;
                _order.ToppingList = list_topping;

                gridView1.SelectRow(index[0]);

                Count_Topping = gridView1.SelectedRowsCount;
                Helper_Project.fMain.ShowNotification("Thông báo", "Thêm topping", $"Đã thêm {Count_Topping} topping thành công !!!", Helper_Project.svgImages["Success"]);

                this.Close();
            }
            else
            {
                Helper_Project.fMain.ShowNotification("Thông báo", "Thêm topping", $"Vui lòng chọn nhiều hơn 1 topping !!!", Helper_Project.svgImages["Warning"]);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}