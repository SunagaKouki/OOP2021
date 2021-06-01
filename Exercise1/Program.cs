using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            //2.1.3
            var songs = new Song[] {
                new Song("紅蓮華","Lisa",238),
                new Song("夜に駆ける","YOASOBI",261),
                new Song("炎","Lisa",275),
                new Song("I LOVE...","Official髭男dism",282),
                new Song("Pretender","Official髭男dism",326),
            };
            PrintSongs(songs);
        }

        //2.1.4
        private static void PrintSongs(Song[] songs) {
            foreach (var song in songs) {
                Console.WriteLine(@"{0}, {1}, {2:m\:ss}", song.Title, song.ArtistName, TimeSpan.FromSeconds(song.Length));
            }
        }
        /*
        @"{0}, {1}, {2:m\:ss}"について
        {}の中で、:は特別な意味を持っている。そのため、:を文字：として表示させるために、
        \:としている。
        */
    }
}
