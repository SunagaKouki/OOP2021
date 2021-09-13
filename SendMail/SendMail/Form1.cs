using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btSend_Click(object sender, EventArgs e) {
            try {
                MailMessage mailMessage = new MailMessage();   //メール送信の為のインスタンスを生成
                mailMessage.From = new MailAddress("ojsinfosys01@gmail.com");   //差出人メールアドレス
                mailMessage.To.Add(tbTo.Text);  //宛先（To）
                mailMessage.Subject = tbTitle.Text; //件名（タイトル）
                mailMessage.Body = tbMessage.Text;  //本文

                SmtpClient smtpClient = new SmtpClient();   //SMTPを使ってメールを送信する
                smtpClient.Credentials
                    = new NetworkCredential(
                                            "ojsinfosys01@gmail.com",
                                            "Infosys2021"
                                            );   //メール送信の為の認証情報を設定（ユーザー名、パスワード）
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);

                MessageBox.Show("送信完了");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
