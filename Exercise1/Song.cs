using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Song {
        //2.1.1
        public string Title { get; set; }           //歌のタイトル
        public string ArtistName { get; set; }      //アーティスト名
        public int Length { get; set; }             //演奏時間（秒）

        //2.1.2
        public Song(string Title, string ArtistName, int Length) {
            this.Title = Title;
            this.ArtistName = ArtistName;
            this.Length = Length;
        }
    }
}
