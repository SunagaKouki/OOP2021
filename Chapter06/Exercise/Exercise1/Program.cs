using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };
            #region テスト用ドライバ
            Exercise1_1(numbers);
            Console.WriteLine("-----");

            Exercise1_2(numbers);
            Console.WriteLine("-----");

            Exercise1_3(numbers);
            Console.WriteLine("-----");

            Exercise1_4(numbers);
            Console.WriteLine("-----");

            Exercise1_5(numbers);
            #endregion
        }

        //最大値を求める
        private static void Exercise1_1(int[] numbers) {
            var max = numbers.Max();
            Console.WriteLine(max);
        }

        //末尾から２つの要素を取り出す
        private static void Exercise1_2(int[] numbers) {
            var skip = numbers.Length - 2;
            foreach (var n in numbers.Skip(skip)) {
                Console.WriteLine(n);
            }
        }

        //数値を文字列に変換
        private static void Exercise1_3(int[] numbers) {
            var num = numbers.Select(n => n.ToString());
            foreach (var s in num) {
                Console.Write(s +" ");
            }
            Console.WriteLine();
        }

        //小さい順に先頭から３つ取り出す
        private static void Exercise1_4(int[] numbers) {
            foreach (var n in numbers.OrderBy(n => n).Take(3)) {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }

        //重複排除後、10より大きい値をカウント
        private static void Exercise1_5(int[] numbers) {
            var count = numbers.Distinct().Count(x => x > 10);
            Console.WriteLine(count);
        }
    }
}
