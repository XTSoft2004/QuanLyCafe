using DevExpress.Utils;
using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using QuanLyCafe.TongQuan;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe.Helper
{
    public class Helper_ShowNoti
    {
        public static SvgImageCollection svgImages;
        public static fMain fMain = new fMain();
        public class AlertData
        {
            public AlertData(string title, string message, SvgImageIcon enum_SgvImage)
            {
                Title = title;
                Message = message;
                MessageIcon = Choose_SvgImage(enum_SgvImage);
            }
            public string Title { get; set; }
            public string Message { get; set; }
            public SvgImage MessageIcon { get; set; }
            private SvgImage Choose_SvgImage(SvgImageIcon enum_SgvImage)
            {
                switch (enum_SgvImage)
                {
                    case SvgImageIcon.Success:
                        return svgImages["Success"];

                    case SvgImageIcon.Error:
                        return svgImages["Error"];

                    case SvgImageIcon.Error_Fix:
                        return svgImages["Error_Fix"];

                    case SvgImageIcon.Team_Work:
                        return svgImages["Team_Work"];

                    case SvgImageIcon.Warning:
                        return svgImages["Warning"];
                }
                return null;
            } 
        }
        public static void ShowThongBao(string Message, string Title, SvgImageIcon svgImageIcon)
        {
            fMain.ShowNotification(Message, Title, svgImageIcon);
            CafeLog.SaveLog($"[{uc_TongQuat.InfoLogin.IdNhanVien}:{uc_TongQuat.InfoLogin.NameNhanVien}] | {Title}");
        }
        public enum IconXtraMessageBox
        {
            Information,
            Warning,
            Error,
            Stop,
            Asterisk,
            Exclamation,
            Question,
            Hand,
            None,
        }
        public static void ShowXtraMessageBox(string text,string caption, IconXtraMessageBox iconXtra = IconXtraMessageBox.None)
        {
            switch(iconXtra)
            {
                case IconXtraMessageBox.Information:
                    XtraMessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case IconXtraMessageBox.Warning:
                    XtraMessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case IconXtraMessageBox.Error:
                    XtraMessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case IconXtraMessageBox.Stop:
                    XtraMessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;
                case IconXtraMessageBox.Asterisk:
                    XtraMessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
                case IconXtraMessageBox.Question:
                    XtraMessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                case IconXtraMessageBox.Hand:
                    XtraMessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    break;
                case IconXtraMessageBox.None:
                    XtraMessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.None);
                    break;
            }
        }
        public enum SvgImageIcon
        {
            Success,
            Error,
            Error_Fix,
            Warning,
            Team_Work,
        }
        public class CafeLog
        {
            public static void SaveLog(string title)
            {
                string dateTimeString = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                DateTime dateTime = DateTime.ParseExact(dateTimeString, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                LogRepository logRepository = new LogRepository()
                {
                    TextLog = title,
                    DateLog = dateTime,
                };
                QuanLyCafeEntities db_quanly = new QuanLyCafeEntities();
                db_quanly.LogRepositories.Add(logRepository);
                db_quanly.SaveChanges();
            }
        }
    }
}
