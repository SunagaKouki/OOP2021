using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void buFinish_Click(object sender, EventArgs e) {
            Application.Exit(); //アプリケーション終了
        }

        private void btOpen_Click(object sender, EventArgs e) {
            if (ofdPictureOpen.ShowDialog() == DialogResult.OK) {
                pbCar.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }
    }
}
