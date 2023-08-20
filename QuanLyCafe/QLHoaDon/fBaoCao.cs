using DevExpress.XtraReports.UI;
using Newtonsoft.Json;
using QuanLyCafe.ThongTinQuan;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QuanLyCafe.QLHoaDon
{
    public partial class fBaoCao : DevExpress.XtraReports.UI.XtraReport
    {
        public List<_ModelHoaDon> _ModelHoaDons = new List<_ModelHoaDon>();
        public fBaoCao(List<_ModelHoaDon> _hoadon)
        {
            InitializeComponent();
            _ModelHoaDons = _hoadon;
        }

        private void fBaoCao_AfterPrint(object sender, EventArgs e)
        {
            //MessageBox.Show("A");
        }

        public static string Path = Application.StartupPath + "\\DATA\\";
        private void fBaoCao_BeforePrint(object sender, CancelEventArgs e)
        {
            System.IO.Directory.CreateDirectory(Path);
            string PathThongTin = Path + "ThongTinQuan.json";
            if (!File.Exists(PathThongTin)) return;

            string jsonstr = File.ReadAllText(PathThongTin);
            if (!string.IsNullOrEmpty(jsonstr) && !string.IsNullOrWhiteSpace(jsonstr))
            {
                List<uc_ThongTinQuan.ThongTinCafe> thongtins = JsonConvert.DeserializeObject<List<uc_ThongTinQuan.ThongTinCafe>>(jsonstr);
                foreach (uc_ThongTinQuan.ThongTinCafe dulieu in thongtins)
                {
                    xrlbDiaChi.Text = dulieu.Address;
                    xlLPhone.Text = dulieu.Telephone;
                    xrlNameCafe.Text = dulieu.NameQuanCafe;
                    xrlLoicamon.Text = dulieu.LoiCamOn;
                }
            }

            xrlbDiaChi.Text = "Ngự Bình,Phường An Cựu, Thừa Thiên Huế";
            


            //MessageBox.Show("B");
        }
    }
}
