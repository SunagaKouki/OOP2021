namespace SendMail {
    public class SettingsBase {

        public int Port { get; set; }           //ポート番号
        public string Host { get; set; }        //ホスト名
        public string MailAddr { get; set; }    //メールアドレス
        public string Pass { get; set; }        //パスワード
        public bool Ssl { get; set; }            //SSL

        public bool Checks() {
            if (string.IsNullOrWhiteSpace(Host)) {
                return false;
            }
            if (string.IsNullOrWhiteSpace(Port.ToString())) {
                return false;
            }
            if (string.IsNullOrWhiteSpace(MailAddr)) {
                return false;
            }
            if (string.IsNullOrWhiteSpace(Pass)) {
                return false;
            }

            return true;
        }
    }
}