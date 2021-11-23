using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pelmanism {
    //カードクラス
    class Card : Button {
        //カードの横幅(W)と高さ(H)
        private const int SizeW = 50, SizeH = 70;

        //カードの絵柄
        public Image Picture { get; set; }
        //カードの状態（true:表 false:裏）
        public bool State { get; set; }
        //カード表面の色
        public Color OpenColor { get; } = Color.White;
        //カード裏面の色
        public Color CloseColor { get; } = Color.LightSeaGreen;

        //コンストラクタ
        public Card(Image picture) {
            Picture = picture;
            State = false;
            Size = new Size(SizeW, SizeH);
            BackColor = CloseColor;
            Font = new Font("MS UI Gothic", 14, FontStyle.Bold);
            Enabled = false;
        }

        //カードをオープンする
        public void Open() {
            State = true;   //表
            BackColor = OpenColor;
            Image = Picture;
            Enabled = false;    //選択不可
        }

        //カードを閉じる
        public void Close() {
            State = false;   //表
            BackColor = CloseColor;
            Image = null;
            Enabled = true;    //選択不可
        }

        //カードをひっくり返す
        public void Turn() {
            if (State) Close(); //裏にする
            else Open();        //表にする
        }
    }
}
