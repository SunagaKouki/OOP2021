using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {

            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            // 3.1.1
            Exercise1_1(numbers);
            Console.WriteLine("-----");

            // 3.1.2
            Exercise1_2(numbers);
            Console.WriteLine("-----");

            // 3.1.3
            Exercise1_3(numbers);
            Console.WriteLine("-----");

            // 3.1.4
            Exercise1_4(numbers);
            Console.WriteLine("-----");

            //応用
            var names = new List<string> {
                "Tokyo","New Delhi","Bangkok","London","Paris","Berlin","Canberra","Hang Kong",
            };

            // 3.2.1
            Exercise2_1(names);
            Console.WriteLine("-----");

            // 3.2.2
            Exercise2_2(names);
            Console.WriteLine("-----");

            // 3.2.3
            Exercise2_3(names);
            Console.WriteLine("-----");

            // 3.2.4
            Exercise2_4(names);
            Console.WriteLine("-----");

            //応用
            Application(names);
        }

        //3.1.1
        private static void Exercise1_1(List<int> numbers) {
            var exists = numbers.Exists(n => n % 8 == 0 || n % 9 == 0);

            if (exists) {
                Console.WriteLine("存在しています");
            } else {
                Console.WriteLine("存在していません");
            }
        }

        //3.1.2
        private static void Exercise1_2(List<int> numbers) {
            numbers.ForEach(n => Console.WriteLine(n / 2.0));
        }

        //3.1.3
        private static void Exercise1_3(List<int> numbers) {
            numbers.Where(n => n >= 50).ToList().ForEach(Console.WriteLine);
            //var nums = numbers.Where(n => n >= 50);
            //foreach (var n in numbers.Where(n => n >= 50)) {
            //    Console.WriteLine(n);
            //}
        }

        //3.1.4
        private static void Exercise1_4(List<int> numbers) {
            //numbers.Select(n => n * 2).ToList().ForEach(Console.WriteLine);
            List<int> list = numbers.Select(n => n * 2).ToList();
            foreach (var num in list) {
                Console.WriteLine(num);
            }
        }

        //3.2.1
        private static void Exercise2_1(List<string> names) {
            Console.WriteLine("都市名を入力");
            var line = Console.ReadLine();
            int index = names.FindIndex(s => s == line);
            Console.WriteLine(index);
        }

        //3.2.2
        private static void Exercise2_2(List<string> names) {
            var count = names.Count(s => s.Contains('o'));
            Console.WriteLine(count);
        }

        //3.2.3
        private static void Exercise2_3(List<string> names) {
            var selected = names.Where(s => s.Contains('o')).ToArray();
            foreach (var name in selected) {
                Console.WriteLine(name);
            }
        }

        //3.3.4
        private static void Exercise2_4(List<string> names) {
            var selected = names.Where(s => s.StartsWith("B")).Select(s => s.Length);
            foreach (var length in selected) {
                Console.WriteLine(length);
            }
        }

        //応用
        private static void Application(List<string> names) {
            int count = 0;
            //names.ForEach(n => n.Count(c => char.IsLower(c)));
            foreach (var name in names) {
                count += name.Count(c => char.IsLower(c));
            }
            Console.WriteLine(count);
        }
    }
}
