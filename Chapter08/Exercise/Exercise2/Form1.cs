using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2 {
    public partial class Form1 : Form {

        //時間計測のストップウォッチオブジェクト
        Stopwatch sw = new Stopwatch();

        Timer tm = new Timer();

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            lbTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\:ff");
        }

        private void timer1_Tick(object sender, EventArgs e) {
            lbTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\:ff");
        }

        private void btStartDisp_Click(object sender, EventArgs e) {
            sw.Start();
            tm.Start();
        }

        private void btStopDIsp_Click(object sender, EventArgs e) {
            sw.Stop();
            tm.Stop();
        }

        private void btCleanDIsp_Click(object sender, EventArgs e) {
            sw.Restart();
            lbTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\:ff");
        }

        private void btLapDIsp_Click(object sender, EventArgs e) {
            //lbLap.items.Insert(0, sw.Elapsed.ToString(@"hh\:mm\:ss\:ff"));
        }
    }
}
