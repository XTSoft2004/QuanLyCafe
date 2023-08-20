﻿using DevExpress.XtraReports.UI;
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
    public partial class ReportHoaDon : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportHoaDon()
        {
            InitializeComponent();
        }
        public static string Path = Application.StartupPath + "\\DATA\\";

        private void ReportHoaDon_BeforePrint(object sender, CancelEventArgs e)
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
                    AddressCafe.Text = "Địa chỉ: " + dulieu.Address;
                    Phone.Text = "Phone: " + dulieu.Telephone;
                    NameCafe.Text = dulieu.NameQuanCafe;
                    NameWifi.Text = "Tên Wifi:\n" + dulieu.NameWIFI;
                    PasswordWifi.Text = "Password: " + dulieu.PasswordWIFI;
                    LoiCamOn.Text = dulieu.LoiCamOn;
                }
            }

        }
    }
}