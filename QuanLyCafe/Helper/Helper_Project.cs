using DevExpress.Utils;
using DevExpress.Utils.Svg;
using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Skins.SolidColorHelper;

namespace QuanLyCafe
{
    internal class Helper_Project
    {
        public static Random rnd = new Random();
        public static SvgImageCollection svgImages;
        public static fMain fMain = new fMain();
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
            using (MemoryStream ms = new MemoryStream())
            {
                // Create an ImageConverter instance
                ImageConverter converter = new ImageConverter();

                // Convert the image to a byte array using the ImageConverter
                byte[] byteArray = (byte[])converter.ConvertTo(imageIn, typeof(byte[]));

                return byteArray; 
            }
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
                // Handle any exceptions that might occur (e.g., invalid image format)
                Console.WriteLine("Error converting byte array to image: " + ex.Message);
                return null;
            }
        }
        public class AlertData
        {
            public AlertData(string newMessage, string title, string message, SvgImage messageicon)
            {
                NewMessage = newMessage;
                Title = title;
                Message = message;
                MessageIcon = messageicon;
            }
            public string NewMessage { get; set; }
            public string Title { get; set; }
            public string Message { get; set; }
            public SvgImage MessageIcon { get; set; }
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
