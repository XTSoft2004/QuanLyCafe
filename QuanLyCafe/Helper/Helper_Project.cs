﻿using DevExpress.Utils;
using DevExpress.Utils.Svg;
using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Skins.SolidColorHelper;

namespace QuanLyCafe
{
    internal class Helper_Project
    {
        public static Random rnd = new Random();
        public static void SaveData(string path, string data)
        {
            while (true)
            {
                try
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(data);
                        sw.Close();
                    }
                    break;
                }
                catch { }
            }
        }
        public static string ChuyenDoiGiaTriTien(decimal x)
        {
            decimal GiatienSanPham = x;
            string giatien = GiatienSanPham.ToString("N3");
            //string giatien = x.ToString().Split('.')[0] + "." + x.ToString("F3").Split('.')[1];
            return giatien;
        }
        public static string DownloadImage(string link)
        {
            string path = string.Empty;
            try
            {
                WebClient webClient = new WebClient();
                System.IO.Directory.CreateDirectory("DATA\\IMG_SANPHAM");
                path = Application.StartupPath + "\\DATA\\IMG_SANPHAM\\" + Path.GetFileName(link);

                if (File.Exists(path))
                {
                    path = Application.StartupPath + "\\DATA\\IMG_SANPHAM\\" + Path.GetFileName(link).Split('.')[0] + rnd.Next(111, 9999) + "." + Path.GetFileName(link).Split('.')[1];
                }

                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                webClient.DownloadFile(new Uri(link), path);
                webClient.Dispose();
                return path;
            }
            catch
            {
                return null;
            }
        }
        public static string CopyIMGToFolder(string path_old)
        {
            string path_img = Application.StartupPath + "\\DATA\\IMG_SANPHAM";
            System.IO.Directory.CreateDirectory(path_img);
            string path_new = path_img + "\\" + Path.GetFileName(path_old);
            if (!File.Exists(path_new))
            {
                File.Copy(path_old, path_new);
            }
            return path_new;
        }

        public static void ClearAllPanel(FlowLayoutPanel flowLayout)
        {
            while (true)
            {
                if (flowLayout.Controls.Count == 0) break;
                foreach (Panel item in flowLayout.Controls)
                {
                    flowLayout.Controls.Remove(item);
                }
            }
        }

        public static FluentDesignFormContainer MainControlAdd;
        public static void ShowFormUC(UserControl userControl)
        {
            if(userControl != null) { 
                userControl.Dock = DockStyle.Fill;
                MainControlAdd.Controls.Add(userControl);
                userControl.BringToFront();
            }
            else
            {
                userControl.BringToFront();
            }
        }
        public static byte[] ConvertImageToByte(string pathImage)
        {
            try
            {
                Image image = Image.FromFile(pathImage);
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return memoryStream.ToArray();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error converting image to byte array: " + ex.Message);
                return null;
            }
        }
        public static byte[] ConvertImageToByte(Image imageIn)
        {
            if (imageIn == null) return null;

            MemoryStream ms = new MemoryStream();
            Bitmap bmpImage = new Bitmap(imageIn);
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] data = ms.GetBuffer();

            return data;
        }
        public static Image ConverByteToImage(byte[] imagebyte)
        {
            try
            {
                using (MemoryStream memoryStream = new MemoryStream(imagebyte))
                {
                    Image image = Image.FromStream(memoryStream);
                    return image;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static Image ConvertImageUrlToImage(string imageUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    byte[] imageData = client.GetByteArrayAsync(imageUrl).Result;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image image = Image.FromStream(ms);
                        return image;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi chuyển đổi hình ảnh: " + ex.Message);
                    return null;
                }
            }
        }

        public static void CloseApp(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            if (processes.Length > 0)
            {
                processes[0].Kill();
                Console.WriteLine("ChromeDriver process terminated successfully.");
            }
            else
            {
                Console.WriteLine("ChromeDriver process not found.");
            }
        }
    }
}
