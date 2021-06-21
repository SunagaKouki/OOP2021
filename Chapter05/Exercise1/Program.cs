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
            var s1 = Console.ReadLine();
            var s2 = Console.ReadLine();

            if (String.Compare(s1,s2,ignoreCase:true) == 0) {
                Console.WriteLine("等しい");
            } else {
                Console.WriteLine("等しくない");
            }
            #endregion
#endif
#if true
            #region 問題5.2
            var Num = Console.ReadLine();

            int num = int.Parse(Num);
            #endregion
#endif
        }
    }
}
