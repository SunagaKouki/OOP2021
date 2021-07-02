using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section03 {

    // List 7-20
    class Program {
        static void Main(string[] args) {
            // コンストラクタ呼び出し
            var abbrs = new Abbreviations();

            // Addメソッドの呼び出し例
            abbrs.Add("IOC", "国際オリンピック委員会");
            abbrs.Add("NPT", "核兵器不拡散条約");            

            //7.2.3 (Countの呼び出し)
            var count = abbrs.Count;
            Console.WriteLine("----7.2.3----Countの呼び出し");
            Console.WriteLine(abbrs.Count);
            Console.WriteLine();

            Console.WriteLine("----7.2.3----Removeの呼び出し");
            if (abbrs.Remove("IOC")) {
                Console.WriteLine("削除されました");
            }
            Console.WriteLine("----7.2.3----Removeの呼び出し");
            if (abbrs.Remove("IOC")) {
                Console.WriteLine("削除されました");
            } else {
                Console.WriteLine("削除エラー");
            }

            //7.2.4
            foreach (var item in abbrs.Where(x => x.Key.Length == 3)) {
                Console.WriteLine("{0}={1}", item.Key, item.Value);
            }
        }
    }
}
