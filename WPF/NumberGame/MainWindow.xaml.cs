using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumberGame {
    public partial class MainWindow : Window {
        int rand = new Random().Next(1, 26);

        public MainWindow() {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {

        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            int num = int.Parse((string)((Button)sender).Content);

            if (rand == num) {
                TbTextNum.Text = "正解";
            } else if (rand > num) {
                TbTextNum.Text = "もっと大きい数字です";
            } else {
                TbTextNum.Text = "もっと小さい数字です";
            }
        }
    }
}
