using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAppDemo.MVVM.Model
{
    public static class PrefectureFacts
    {
        /// <summary>
        /// 都道府県番号を取得します。
        /// </summary>
        /// <param name="kind"></param>
        /// <returns></returns>
        public static int GetPrefectureNumber(this PrefecturesKind kind)
        {
            switch (kind)
            {
                case PrefecturesKind.Hokkaido: return 1;
                case PrefecturesKind.Aomori: return 2;
                case PrefecturesKind.Iwate: return 3;
                case PrefecturesKind.Miyagi: return 4;
                case PrefecturesKind.Akita: return 5;
                case PrefecturesKind.Yamagata: return 6;
                case PrefecturesKind.Fukushima: return 7;
                case PrefecturesKind.Ibaraki: return 8;
                case PrefecturesKind.Tochigi: return 9;
                case PrefecturesKind.Gunma: return 10;
                case PrefecturesKind.Saitama: return 11;
                case PrefecturesKind.Chiba: return 12;
                case PrefecturesKind.Tokyo: return 13;
                case PrefecturesKind.Kanagawa: return 14;
                case PrefecturesKind.Niigata: return 15;
                case PrefecturesKind.Toyama: return 16;
                case PrefecturesKind.Ishikawa: return 17;
                case PrefecturesKind.Fukui: return 18;
                case PrefecturesKind.Yamanashi: return 19;
                case PrefecturesKind.Nagano: return 20;
                case PrefecturesKind.Gifu: return 21;
                case PrefecturesKind.Shizuoka: return 22;
                case PrefecturesKind.Aichi: return 23;
                case PrefecturesKind.Mie: return 24;
                case PrefecturesKind.Shiga: return 25;
                case PrefecturesKind.Kyoto: return 26;
                case PrefecturesKind.Osaka: return 27;
                case PrefecturesKind.Hyogo: return 28;
                case PrefecturesKind.Nara: return 29;
                case PrefecturesKind.Wakayama: return 30;
                case PrefecturesKind.Tottori: return 31;
                case PrefecturesKind.Shimane: return 32;
                case PrefecturesKind.Okayama: return 33;
                case PrefecturesKind.Hiroshima: return 34;
                case PrefecturesKind.Yamaguchi: return 35;
                case PrefecturesKind.Tokushima: return 36;
                case PrefecturesKind.Kagawa: return 37;
                case PrefecturesKind.Ehime: return 38;
                case PrefecturesKind.Kochi: return 39;
                case PrefecturesKind.Fukuoka: return 40;
                case PrefecturesKind.Saga: return 41;
                case PrefecturesKind.Nagasaki: return 42;
                case PrefecturesKind.Kumamoto: return 43;
                case PrefecturesKind.Oita: return 44;
                case PrefecturesKind.Miyazaki: return 45;
                case PrefecturesKind.Kagoshima: return 46;
                case PrefecturesKind.Okinawa: return 47;
            }

            return -1;
        }
    }
}
