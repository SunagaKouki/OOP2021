using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
#if false
            #region 問題5.1
            Console.Write("文字入力：");
            var s1 = Console.ReadLine();
            Console.Write("文字入力：");
            var s2 = Console.ReadLine();

            if (String.Compare(s1,s2,ignoreCase:true) == 0) {
                Console.WriteLine("等しい");
            } else {
                Console.WriteLine("等しくない");
            }
            #endregion
#endif
#if false
            #region 問題5.2
            int num;
            Console.Write("数値入力：");
            var Num = Console.ReadLine();

            if (int.TryParse(Num, out num)) {
                Console.WriteLine(num.ToString("#,#"));
            } else {
                Console.WriteLine("数値文字列ではありません");
            }
            #endregion
#endif
        }
    }
}
