using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryControl {
    public partial class Form1 : Form {
        private int timer;
        DateTime dt = DateTime.Now;

        public Form1() {
            InitializeComponent();

            timer1.Start();
            LbTimeDate.Text = dt.ToString("yyyy年MM月dd日(ddd)");  //年、月、日、曜日
            LbTime.Text = dt.ToString("HH:mm");                    //時間、分
        }

        private void timer1_Tick(object sender, EventArgs e) {
            timer++;
            int timeSec = int.Parse(dt.ToString("ss"));
            var time = timer + timeSec;

            if (time < 60) {
                LbSec.Text = time.ToString();
            } else {
                DateTime dt = DateTime.Now;
                LbTimeDate.Text = dt.ToString("yyyy年MM月dd日(ddd)");
                LbTime.Text = dt.ToString("HH:mm");
                LbSec.Text = dt.ToString("ss");
            }
        }
    }
}
