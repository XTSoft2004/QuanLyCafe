using DevExpress.CodeParser;
using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.TongQuan
{
    public class Helper_ChartControl
    {
        public Helper_ChartControl(string nameSeries, string namePoint, decimal valuePoint, string textPattern = "{A}: {V}")
        {
            NameSeries = nameSeries;
            NamePoint = namePoint;
            ValuePoint = valuePoint;
            TextPattern = textPattern;
        }

        private string NameSeries { get; set; }
        private string NamePoint { get; set; }
        private decimal ValuePoint { get; set; }
        private string TextPattern { get; set; }
        public static Series CreateSeries(string NameSeries, decimal? ValueCost, decimal? ValueSale, string TextPattern = "{A}: {V}")
        {
            Series _series = new Series(NameSeries, ViewType.Bar); // TextPattern: A = Doanh thu lợi nhuận
            _series.Points.Add(new SeriesPoint("Lợi nhuận", ValueCost));
            _series.Points.Add(new SeriesPoint("Tổng tiền bán được", ValueSale));
            _series.Label.TextPattern = TextPattern;
            return _series;
        }
        public static void AddSeries(ref Series _series,string NameSeries, decimal? ValueCost, string TextPattern = "{A}: {V:N3} VNĐ")
        {
            //string str = ValueCost.Value.ToString("N3");
            _series.Points.Add(new SeriesPoint(NameSeries, ValueCost.Value));
            //_series.Points.Add(new SeriesPoint("Tổng tiền bán được", ValueSale));
            _series.Label.TextPattern = TextPattern;
        }
    }
}
