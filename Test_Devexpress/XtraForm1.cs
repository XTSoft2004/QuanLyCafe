using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.Linq.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe.QLySanPham
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }
        //QuanLyCafeEntities db_quanly = new QuanLyCafeEntities();
        //public DataTable ConvertEntityDanhMuc(IEnumerable<DanhMucTopping> entities)
        //{
        //    // Create a new DataTable
        //    DataTable dataTable = new DataTable("DanhMuc");

        //    // Add columns to the DataTable (matching the entity properties)
        //    dataTable.Columns.Add("IdDanhMucTopping", typeof(int));
        //    dataTable.Columns.Add("NameDanhMuc", typeof(string));

        //    // Populate the DataTable with data from the entities
        //    foreach (var entity in entities)
        //    {
        //        DataRow row = dataTable.NewRow();
        //        row["IdDanhMucTopping"] = entity.IdDanhMucTopping;
        //        row["NameDanhMuc"] = entity.NameDanhMuc;
        //        //dataTable.Rows.Add(entity.IdDanhMucTopping, entity.NameDanhMuc);
        //        dataTable.Rows.Add(row);
        //    }

        //    return dataTable;
        //}
        //public DataTable ConvertEntityTopping(IEnumerable<Topping> entities)
        //{
        //    // Create a new DataTable
        //    DataTable dataTable = new DataTable("Topping");

        //    // Add columns to the DataTable (matching the entity properties)
        //    dataTable.Columns.Add("IdTopping", typeof(int));
        //    dataTable.Columns.Add("NameTopping", typeof(string));
        //    dataTable.Columns.Add("GiaTopping", typeof(decimal));
        //    dataTable.Columns.Add("IdDanhMucTopping", typeof(int));

        //    // Populate the DataTable with data from the entities
        //    //foreach (var entity in entities)
        //    //{
        //    //    dataTable.Rows.Add(entity.IdTopping, entity.NameTopping, entity.GiaTopping, entity.IdDanhMucTopping);
        //    //}

        //    foreach (var entity in entities)
        //    {
        //        DataRow row = dataTable.NewRow();
        //        row["IdTopping"] = entity.IdTopping;
        //        row["NameTopping"] = entity.NameTopping;
        //        row["GiaTopping"] = entity.GiaTopping;
        //        row["IdDanhMucTopping"] = entity.IdDanhMucTopping;
        //        dataTable.Rows.Add(row);
        //    }

        //    return dataTable;
        //}
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //// Create a new DataSet
            //DataSet ds = new DataSet();

            //var list_danhmuc = db_quanly.DanhMucToppings
            //    .Where(p => p.IdSanPham == 12)
            //    .ToList();

            //var list_topping = db_quanly.Toppings
            //            .ToList();

            //// Convert the list_topping to a DataTable
            //DataTable db_topping = ConvertEntityTopping(list_topping);
            //DataTable db_danhmuc = ConvertEntityDanhMuc(list_danhmuc);

            //// Add the DataTable to the DataSet
            //ds.Tables.Add(db_topping);
            //ds.Tables.Add(db_danhmuc);

            //// Now you have the DataSet containing the DataTable with your Entity data.

            //DataColumn key1 = ds.Tables["DanhMuc"].Columns["IdDanhMucTopping"];

            //DataColumn key2 = ds.Tables["Topping"].Columns["IdDanhMucTopping"];


            //ds.Relations.Add("ex1", key1, key2);
            //gridControl1.LevelTree.Nodes.Add("ex1", gv2);
            //gv2.ViewCaption = "List Topping";

            //gridControl1.DataSource = ds.Tables["DanhMuc"];

            //gv1.BestFitColumns(true);
            //gv2.BestFitColumns(true);

            //gridControl1.ForceInitialize();
            //gv1.SetMasterRowExpanded(0, true);
        }
        //private void PrintDataTable(DataTable dataTable)
        //{
        //    // Print the column headers
        //    foreach (DataColumn column in dataTable.Columns)
        //    {
        //        Console.Write(column.ColumnName + "\t");
        //    }
        //    Console.WriteLine(); // Move to the next line

        //    // Print the data rows
        //    foreach (DataRow row in dataTable.Rows)
        //    {
        //        foreach (var item in row.ItemArray)
        //        {
        //            Console.Write(item + "\t");
        //        }
        //        Console.WriteLine(); // Move to the next line
        //    }
        //}
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //var list_danhmuc = db_quanly.DanhMucToppings
            //    .Where(p => p.IdSanPham == 12)
            //    .ToList();

            //// Convert the list_topping to a DataTable
            //DataTable db_danhmuc = ConvertEntityDanhMuc(list_danhmuc);

            //PrintDataTable(db_danhmuc);
        }

        private void DeleteTopping_Click(object sender, EventArgs e)
        {
            //int index = gv2.FocusedRowHandle;
            //string NameTopping = gv1.GetRowCellValue(index, "NameDanhMuc")?.ToString();
            //MessageBox.Show(NameTopping);
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {

        }
    }
}