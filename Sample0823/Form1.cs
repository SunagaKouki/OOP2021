using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0823 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Exec_Click(object sender, EventArgs e) {
            int ans = 1;
            var num1 = int.Parse(Value.Text);
            var num2 = int.Parse(Jyou.Text);

            for (int i = 0; i < num2; i++) {
                ans = ans * num1;
            }

            Result.Text = ans.ToString();
        }
    }
}
