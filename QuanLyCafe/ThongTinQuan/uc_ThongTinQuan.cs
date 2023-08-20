using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe.ThongTinQuan
{
    public partial class uc_ThongTinQuan : UserControl
    {
        public uc_ThongTinQuan()
        {
            InitializeComponent();
        }
        public class ThongTinCafe
        {
            public string NameQuanCafe { get; set; }
            public string Address { get; set; }
            public string NameWIFI { get; set; }    
            public string PasswordWIFI { get; set; }
            public string Telephone { get; set; }
            public string LoiCamOn { get; set; }
        }
        public static string Path = Application.StartupPath + "\\DATA\\";
        private void btnSaveThongTin_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(Path);
            string PathThongTin = Path + "ThongTinQuan.json";
            if (File.Exists(PathThongTin)) File.Delete(PathThongTin);

            List<ThongTinCafe> thongTinCafe = new List<ThongTinCafe>();
            thongTinCafe.Add(new ThongTinCafe()
            {
                NameQuanCafe = TeNameCafe.Text,
                Address = TeAddress.Text,
                NameWIFI = TeNameCafe.Text,
                PasswordWIFI = TePasswordWIFI.Text,
                Telephone = TeTelePhone.Text,
                LoiCamOn = TeLoiCamOn.Text,
            });

            string json = JsonConvert.SerializeObject(thongTinCafe);
            File.AppendAllText(PathThongTin, json);

            XtraMessageBox.Show("Đã thêm thông tin quán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void uc_ThongTinQuan_Load(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(Path);
            string PathThongTin = Path + "ThongTinQuan.json";
            if (!File.Exists(PathThongTin)) return;

            string jsonstr = File.ReadAllText(PathThongTin);
            if (!string.IsNullOrEmpty(jsonstr) && !string.IsNullOrWhiteSpace(jsonstr))
            {
                List<ThongTinCafe> thongtins = JsonConvert.DeserializeObject<List<ThongTinCafe>>(jsonstr);
                foreach (ThongTinCafe dulieu in thongtins)
                {
                    TeNameCafe.Text = dulieu.NameQuanCafe;
                    TeAddress.Text = dulieu.Address;
                    TeNameWIFI.Text = dulieu.NameWIFI;
                    TePasswordWIFI.Text = dulieu.PasswordWIFI;
                    TeTelePhone.Text = dulieu.Telephone;
                    TeLoiCamOn.Text = dulieu.LoiCamOn;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(Path);
            string PathThongTin = Path + "ThongTinQuan.json";
            if (!File.Exists(PathThongTin)) File.Delete(PathThongTin);

            XtraMessageBox.Show("Đã xóa thông tin quán !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
