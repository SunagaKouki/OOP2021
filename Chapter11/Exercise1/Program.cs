using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {

            var file = "Sample.xml";

            Exercise1_1(file);
            Console.WriteLine("- 11.1.1 ------");

            Exercise1_2(file);
            Console.WriteLine("- 11.1.2 ------");

            Exercise1_3(file);
            Console.WriteLine("- 11.1.3 ------");
        }

        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load(file);

            foreach (var xnovelist in xdoc.Root.Elements()) {
                var xname = xnovelist.Element("name");
                var xteams = xnovelist.Element("teammembers");
                Console.WriteLine("{0} {1}", xname.Value, xteams.Value);
            }
        }

        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load(file);
            var xnovelists = xdoc.Root.Elements()
                                 .OrderByDescending(x => (int)(x.Element("firstplayed")));

            foreach (var xnovelist in xnovelists) {
                var xname = xnovelist.Element("name");
                XAttribute xkanji = xname.Attribute("kanji");
                Console.WriteLine("{0}", xkanji?.Value);
            }
        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load(file);

            var xnovelist = xdoc.Root.Elements()
                                .Max(x => (int)x.Element("teammembers"));

            Console.WriteLine("{0}", xnovelist);
        }
    }
}
