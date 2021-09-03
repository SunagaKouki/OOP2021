using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section04 {
    class Program {
        static void Main(string[] args) {
            new Program();
        }

        //コンストラクタ
        public Program() {
            //DownloadString();
            //DownloadFileAsync();
            //OpenReadSample();

            Dictionary<string, int> code = new Dictionary<string, int>() {
                {"前橋",4210},
                {"みなかみ", 4220},
                {"宇都宮", 4110},
                {"水戸", 4010},
            };

            //var list = new List<int> { 4210, 4220, 4110, 4010 };

            Console.WriteLine("Yahoo!週間天気予報");
            Console.WriteLine();
            Console.WriteLine("地域コードを入力");
            Console.WriteLine("1:前橋");
            Console.WriteLine("2:みなかみ");
            Console.WriteLine("3:宇都宮");
            Console.WriteLine("4:水戸");
            Console.WriteLine("9:その他（直接入力）");
            Console.WriteLine();
            Console.Write(">");

            var selectArea = Console.ReadLine();    //文字列として入力した数字を取り込む

            

            //if (1 == int.Parse(selectArea)) {
            //    var code1 = 4210;
            //    var name1 = "前橋";
            //    if (2 == int.Parse(selectArea)) {
            //        var code2 = 4220;
            //        var name2 = "みなかみ";
            //        if (3 == int.Parse(selectArea)) {
            //            var code3 = 4110;
            //            var name3 = "宇都宮";
            //            if (4 == int.Parse(selectArea)) {
            //                var code4 = 4010;
            //                var name4 = "水戸";
            //                if (9 == int.Parse(selectArea)) {
            //                    Console.WriteLine("コードを入力してください。");
            //                    var code = Console.ReadLine();
            //                }
            //            }
            //        }
            //    }
            //}

            var results = GetWeatherReportFromYahoo(4210);
            Console.WriteLine("******************:");
            Console.WriteLine("{0}の週間天気を出力");
            Console.WriteLine("******************:");
            foreach (var s in results) {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }

        //リスト14.15
        public void DownloadString() {
            var wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            var html = wc.DownloadString("https://yahoo.co.jp");
            Console.WriteLine(html);
        }

        //リスト14.17
        private void DownloadFileAsync() {
            var wc = new WebClient();
            var url = new Uri(@"C:\Users\ks32146\Downloads\タイピングソフト.zip");
            var filename = @"C:\temp\example.zip";
            wc.DownloadProgressChanged += wc_DownloadProgressChanged;
            wc.DownloadFileCompleted += wc_DownloadFileCompleted;
            wc.DownloadFileAsync(url, filename);
            Console.ReadLine();    //アプリケーションが終了しないようにする
        }

        static void wc_DownloadProgressChanged(object sender,
                            DownloadProgressChangedEventArgs e) {
            Console.WriteLine("{0}% {1}/{2}", e.ProgressPercentage,
                              e.BytesReceived, e.TotalBytesToReceive);
        }

        static void wc_DownloadFileCompleted(object sender,
                            System.ComponentModel.AsyncCompletedEventArgs e) {
            Console.WriteLine("ダウンロード完了");
        }

        //リスト14.18（ストリームとしてダウンロード）
        public void OpenReadSample() {
            var wc = new WebClient();
            using (var stream = wc.OpenRead(@"https://yahoo.co.jp/")) {
            using (var sr = new StreamReader(stream,Encoding.UTF8)) {
                string html = sr.ReadToEnd();
                Console.WriteLine(html);
            }
            }
        }

        //リスト14.19
        private static IEnumerable<string> GetWeatherReportFromYahoo(int cityCode) {
            using (var wc = new WebClient()) {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var uriString = string.Format(
                    @"http://rss.weather.yahoo.co.jp/rss/days/{0}.xml", cityCode);
                var url = new Uri(uriString);
                var stream = wc.OpenRead(url);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("title");
                foreach (var node in nodes) {
                    string s = Regex.Replace(node.Value, "【|】| - Yahoo!天気・災害", "");
                    yield return s;
                }
            }
        }
    }
}
