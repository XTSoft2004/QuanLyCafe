using DevExpress.Utils;
using DevExpress.Utils.Svg;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
