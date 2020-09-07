using System;
using System.Collections.Generic;
using System.Linq;

namespace AnketachMetaAnalysis.Models
{
    public class TotalChartData
    {
        public List<TotalChartDataItem> DataItems { get; set; } = new List<TotalChartDataItem>();
        public int MaxTotalMessageCount => DataItems.Any() ? DataItems.Max(d => d.TotalMessageCount) : 2;
        public int Step => MaxTotalMessageCount >= 5 ? (int)Math.Round((double)MaxTotalMessageCount / 5) : 1;
    }
}
