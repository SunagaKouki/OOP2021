using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SendMail {
    public partial class ConfigForm : Form {

        public Settings settings = Settings.getInstance();

        public ConfigForm() {
            InitializeComponent();
        }

        private void byDefault_Click(object sender, EventArgs e) {
            tbHost.Text = settings.sHost();
            tbPort.Text = settings.sPort();
            tbUserName.Text = settings.sMailAddr();
            tbPass.Text = settings.sPass();
            cbSsl.Checked = settings.bSsl();
            tbSender.Text = settings.sMailAddr();
        }

        //OKボタン
        private void btOk_Click(object sender, EventArgs e) {
            btApply_Click(sender, e);   //適用ボタンの処理を呼び出す
            this.Close();
        }

        //適用ボタン
        private void btApply_Click(object sender, EventArgs e) {
            settings.setSendConfig(tbHost.Text, int.Parse(tbPort.Text), tbUserName.Text, tbPass.Text, cbSsl.Checked);
        }

        //キャンセルボタン
        private void btCancel_Click(object sender, EventArgs e) {
            if (settings.Checks()) {
                this.Close();
            } else {
                Check_All();
            }
            this.Close();
        }

        private void ConfigForm_Load(object sender, EventArgs e) {
            tbHost.Text = settings.Host;
            tbPort.Text = settings.Port.ToString();
            tbUserName.Text = settings.MailAddr;
            tbPass.Text = settings.Pass;
            cbSsl.Checked = settings.Ssl;
            tbSender.Text = settings.MailAddr;
        }

        private bool Check_All() {
            if (string.IsNullOrWhiteSpace(tbHost.Text)) {
                MessageBox.Show("送信サーバーが未入力です");
            }
            if (string.IsNullOrWhiteSpace(tbPort.Text)) {
                MessageBox.Show("ポート番号がみにゅ力です");

            }
            if (string.IsNullOrWhiteSpace(tbUserName.Text)) {
                MessageBox.Show("ユーザー名が未入力です");
            }
            if (string.IsNullOrWhiteSpace(tbPass.Text)) {
                MessageBox.Show("パスワードが未入力です");
            }
            settings.setSendConfig(tbHost.Text, int.Parse(tbPort.Text), tbUserName.Text, tbPass.Text, cbSsl.Checked);

            return true;
        }
    }
}
