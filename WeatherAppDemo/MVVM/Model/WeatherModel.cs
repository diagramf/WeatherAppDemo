using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAppDemo.MVVM.Model
{
    public sealed class WeatherModel
    {
        public string PublisherName { get; set; }
        public DateTime ReportTime { get; set; }
        public string TargetArea { get; set; }
        public string HeadlineText { get; set; }
        public string Text { get; set; }
    }
}
