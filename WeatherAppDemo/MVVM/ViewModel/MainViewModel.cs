using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WeatherAppDemo.Core;
using WeatherAppDemo.MVVM.Model;
using WeatherAppDemo.MVVM.Services;

namespace WeatherAppDemo.MVVM.ViewModel
{
    public sealed class MainViewModel : ObservableObject
    {
        private WeatherModel _weatherModel;
        public WeatherModel WeatherModel
        {
            get => _weatherModel;
            set
            {
                _weatherModel = value;
                OnPropertyChanged(nameof(WeatherModel));
            }
        }

        public Dictionary<PrefecturesKind, string> PrefecturesDict { get; set; }

        public PrefecturesKind SelectedPrefecture { get; set; }

        private readonly WeatherModelService weatherModelService;
        private readonly HttpClient client;
        public IAsyncCommand GetLatestWeatherCommand { get; private set; }

        public MainViewModel()
        {
            client = new HttpClient();
            weatherModelService = new WeatherModelService(new WeatherModelHttpClient(client));

            PrefecturesDict = new Dictionary<PrefecturesKind, string>()
            {
                {PrefecturesKind.Hokkaido, "北海道" },
                {PrefecturesKind.Aomori, "青森" },
                {PrefecturesKind.Iwate, "岩手" },
                {PrefecturesKind.Miyagi, "宮城" },
                {PrefecturesKind.Akita, "秋田" },
                {PrefecturesKind.Yamagata, "山形" },
                {PrefecturesKind.Fukushima, "福島" },
                {PrefecturesKind.Ibaraki, "茨城" },
                {PrefecturesKind.Tochigi, "栃木" },
                {PrefecturesKind.Gunma, "群馬" },
                {PrefecturesKind.Saitama, "埼玉" },
                {PrefecturesKind.Chiba, "千葉" },
                {PrefecturesKind.Tokyo, "東京都" },
                {PrefecturesKind.Kanagawa, "神奈川" },
                {PrefecturesKind.Niigata, "新潟" },
                {PrefecturesKind.Toyama, "富山" },
                {PrefecturesKind.Ishikawa, "石川" },
                {PrefecturesKind.Fukui, "福井" },
                {PrefecturesKind.Yamanashi, "山梨" },
                {PrefecturesKind.Nagano, "長野" },
                {PrefecturesKind.Gifu, "岐阜" },
                {PrefecturesKind.Shizuoka, "静岡" },
                {PrefecturesKind.Aichi, "愛知" },
                {PrefecturesKind.Mie, "三重" },
                {PrefecturesKind.Shiga, "滋賀" },
                {PrefecturesKind.Kyoto, "京都" },
                {PrefecturesKind.Osaka, "大阪" },
                {PrefecturesKind.Hyogo, "兵庫" },
                {PrefecturesKind.Nara, "奈良" },
                {PrefecturesKind.Wakayama, "和歌山" },
                {PrefecturesKind.Tottori, "鳥取" },
                {PrefecturesKind.Shimane, "島根" },
                {PrefecturesKind.Okayama, "岡山" },
                {PrefecturesKind.Hiroshima, "広島" },
                {PrefecturesKind.Yamaguchi, "山口" },
                {PrefecturesKind.Tokushima, "徳島" },
                {PrefecturesKind.Kagawa, "香川" },
                {PrefecturesKind.Ehime, "愛媛" },
                {PrefecturesKind.Kochi, "高知" },
                {PrefecturesKind.Fukuoka, "福岡" },
                {PrefecturesKind.Saga, "佐賀" },
                {PrefecturesKind.Nagasaki, "長崎" },
                {PrefecturesKind.Kumamoto, "熊本" },
                {PrefecturesKind.Oita, "大分" },
                {PrefecturesKind.Miyazaki, "宮崎" },
                {PrefecturesKind.Kagoshima, "鹿児島" },
                {PrefecturesKind.Okinawa, "沖縄" }
            };
            SelectedPrefecture = PrefecturesKind.Tokyo;

            GetLatestWeatherCommand = new AsyncCommand(async () =>
            {
                WeatherModel = await weatherModelService.GetWeather(SelectedPrefecture);
            });
        }
    }
}
