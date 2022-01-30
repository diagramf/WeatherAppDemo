using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WeatherAppDemo.MVVM.Model;

namespace WeatherAppDemo.MVVM.Services
{
    public sealed class WeatherModelService
    {
        private readonly WeatherModelHttpClient client;

        public WeatherModelService(WeatherModelHttpClient client)
        {
            this.client = client;
        }

        public async Task<WeatherModel> GetWeather(PrefecturesKind kind)
        {
            string uriFormattedPrefecturesKind = GetUriFormat(kind);
            string baseAddress = ConfigurationManager.AppSettings.Get("WeatherAPIBaseAddress");

            Uri baseUri = new Uri(baseAddress);
            Uri uri = new Uri(baseUri, uriFormattedPrefecturesKind);
            WeatherModel weatherModel = await client.GetAsync<WeatherModel>(uri.ToString());
            return weatherModel;
        }

        private string GetUriFormat(PrefecturesKind kind)
        {
            int prefectureNumber = kind.GetPrefectureNumber();
            string formatted = $"{prefectureNumber}0000.json";
            return formatted;
        }
    }
}
