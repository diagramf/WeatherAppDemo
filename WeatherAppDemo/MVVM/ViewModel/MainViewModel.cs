using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAppDemo.MVVM.Model;

namespace WeatherAppDemo.MVVM.ViewModel
{
    public sealed class MainViewModel
    {
        public WeatherModel WeatherModel { get; set; }

        public Dictionary<string, string> PrefecturesDict { get; set; }

        public MainViewModel()
        {

            PrefecturesDict = new Dictionary<string, string>()
            {
                {"13", "東京都" }
            };


            WeatherModel = new WeatherModel{
                TargetArea = "東京都",
                PublisherName = "気象庁",
                Text = "日本付近は冬型の気圧配置となっています。一方、伊豆諸島付近は気圧の谷となっています。\n\n　東京地方は、おおむね晴れています。\n\n　２７日は、冬型の気圧配置が続きますが、気圧の谷や湿った空気の影響を受けるため、晴れで夕方から曇りとなるでしょう。\n\n　２８日は、東日本では冬型の気圧配置は緩み、気圧の谷や湿った空気の影響を受けるため、晴れ時々曇りとなる見込みです。\n\n【関東甲信地方】\n　関東甲信地方は、晴れや曇りで、長野県北部や関東地方北部では雪の降っている所があります。\n\n　２７日は、冬型の気圧配置が続きますが、伊豆諸島付近は気圧の谷となる見込みです。このため、晴れや曇りで、長野県や関東地方北部では雪の降る所があるでしょう。\n\n　２８日は、東日本では冬型の気圧配置は緩み、気圧の谷や湿った空気の影響を受ける見込みです。このため、晴れや曇りで、長野県や関東地方北部では雪の降る所があるでしょう。\n\n　関東地方と伊豆諸島の海上では、２７日から２８日にかけて波が高い見込みです。船舶は高波に注意してください。",
                ReportTime = DateTime.Now
            };

        }
    }
}
