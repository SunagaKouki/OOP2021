using Exercise1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {
            //4.2.1
            var ymConllection = new YearMonth[] {
                new YearMonth(1980, 3),
                new YearMonth(1990, 5),
                new YearMonth(2000, 7),
                new YearMonth(2010, 9),
                new YearMonth(2020, 12),
            };

            //4.2.2
            Exericise2_2(ymConllection);
            Console.WriteLine("------");
            //4.2.4
            Exericise2_4(ymConllection);
            Console.WriteLine("------");
            //4.2.5
            Exericise2_5(ymConllection);
        }

        //4.2.2
        private static void Exericise2_2(YearMonth[] ymConllection) {
            foreach (var ym in ymConllection) {
                Console.WriteLine(ym);
            }
        }

        //4.2.3
        static YearMonth FindFirst21C(YearMonth[] ymConllection) {
            foreach (var ym in ymConllection) {
                if (ym.Is21Century)
                    return ym;
            }
            return null;
        }

        //4.2.4
        private static void Exericise2_4(YearMonth[] ymConllection) {
            var yearmonth = FindFirst21C(ymConllection);
            var s = yearmonth != null ? yearmonth.Year.ToString() : "21世紀のデータはありません";
            Console.WriteLine(s);
        }

        //4.2.5
        private static void Exericise2_5(YearMonth[] ymConllection) {
            var array = ymConllection.Select(ym => ym.AddOneMonth()).ToArray();

            foreach (var ym in array) {
                Console.WriteLine(ym);
            }
        }
    }
}
