using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace SendMail {
    public partial class Form1 : Form {

        //設定画面
        private ConfigForm configForm = new ConfigForm();
        //設定情報
        private Settings settings = Settings.getInstance();

        public Form1() {
            InitializeComponent();
        }

        private void btSend_Click(object sender, EventArgs e) {
            if (!Settings.Set) {
                MessageBox.Show("送信情報を設定してください");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbTo.Text)) {
                MessageBox.Show("宛先を入力してください");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbMessage.Text)) {
                MessageBox.Show("本文を入力してください");
                return;
            }

            btSend.Enabled = false;

            try {
                //メール送信の為のインスタンスを生成
                MailMessage mailMessage = new MailMessage();
                //差出人メールアドレス
                mailMessage.From = new MailAddress(configForm.settings.MailAddr);

                //宛先（To）
                mailMessage.To.Add(tbTo.Text);
                if (tbCc.Text != "") {
                    mailMessage.CC.Add(tbCc.Text);
                }
                if (tbbcc.Text != "") {
                    mailMessage.Bcc.Add(tbbcc.Text);
                }

                mailMessage.Subject = tbTitle.Text; //件名（タイトル）
                mailMessage.Body = tbMessage.Text;  //本文

                SmtpClient smtpClient = new SmtpClient();   //SMTPを使ってメールを送信する
                //メール送信の為の認証情報を設定（ユーザー名、パスワード）
                smtpClient.Credentials = new NetworkCredential(configForm.settings.MailAddr, configForm.settings.Pass);
                smtpClient.Host = configForm.settings.Host;
                smtpClient.Port = configForm.settings.Port;
                smtpClient.EnableSsl = settings.Ssl;
                
                //送信完了時に呼ばれるイベントハンドラ
                smtpClient.SendCompleted += SmtpClient_SendCompleted;
                //smtpClient.Send(mailMessage);

                string userState = "SendMail";
                smtpClient.SendAsync(mailMessage, userState);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void SmtpClient_SendCompleted(object sender, AsyncCompletedEventArgs e) {
            if (e.Error != null) {
                MessageBox.Show(e.Error.Message);
            } else {
                MessageBox.Show("送信完了");
                新規作成NToolStripMenuItem_Click(sender, e);
            }
        }

        private void btConfig_Click(object sender, EventArgs e) {
            configForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //起動時に送信情報が未設定の場合、設定画面を表示する
            if (Settings.Set) {
                configForm.ShowDialog();
            }
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void 新規作成NToolStripMenuItem_Click(object sender, EventArgs e) {
            tbTo.Text = "";
            tbCc.Text = "";
            tbbcc.Text = "";
            tbTitle.Text = "";
            tbMessage.Text = "";
        }
    }
}
