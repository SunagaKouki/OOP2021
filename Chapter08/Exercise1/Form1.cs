using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btAction_Click(object sender, EventArgs e) {
            //var today = DateTime.Today;
            var today = new DateTime((int)Year.Value, (int)Month.Value, (int)Day.Value);
            DayOfWeek dayOfWeek = today.DayOfWeek;
            string dow = "";

            switch (dayOfWeek) {
                case DayOfWeek.Sunday:
                    dow = "日";
                    break;
                case DayOfWeek.Monday:
                    dow = "月";
                    break;
                case DayOfWeek.Tuesday:
                    dow = "火";
                    break;
                case DayOfWeek.Wednesday:
                    dow = "水";
                    break;
                case DayOfWeek.Thursday:
                    dow = "木";
                    break;
                case DayOfWeek.Friday:
                    dow = "金";
                    break;
                case DayOfWeek.Saturday:
                    dow = "土";
                    break;
                default:
                    break;
            }
            tbOutput.Text = dow + "曜日です";

            //閏年判定
            var isLeapYear = DateTime.IsLeapYear((int)Year.Value);
            if (isLeapYear) {
                tbLeapYear.Text = "閏年です";
            } else {
                tbLeapYear.Text = "閏年ではありません";
            }

            //誕生日の日時の差
            var birthday = new DateTime(2001, 4, 29);
            TimeSpan diff = today - birthday;
            Birthday.Text = "差は" + diff.Days + "日間です";

            tbOutput.Text = DateTime.Now.ToString();
        }

        //年齢を求める
        public int GetAge(DateTime birthday,DateTime targetDay) {
            var age = targetDay.Year - birthday.Year;
            if (targetDay < birthday.AddYears(age)) {
                age--;
            }
            return age;
        }
    }
}
