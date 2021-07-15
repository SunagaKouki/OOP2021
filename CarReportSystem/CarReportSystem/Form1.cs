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
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvRegistData.DataSource = listCarReport;
        }

        private void buFinish_Click(object sender, EventArgs e) {
            Application.Exit(); //アプリケーション終了
        }

        //画像展開ボタン
        private void btOpen_Click(object sender, EventArgs e) {
            if (ofdPictureOpen.ShowDialog() == DialogResult.OK) {
                pbCar.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }

        //画像削除ボタン
        private void btDelete_Click(object sender, EventArgs e) {
            pbCar.Image = null;
        }

        //追加ボタン
        private void btAdd_Click(object sender, EventArgs e) {

            if (cmAuthor.Text == "" || cbCarName.Text == "") {
                MessageBox.Show("入力されていません");
                return;
            }

            CarReport carReport = new CarReport {
                Date = dtpDate.Value,
                Auther = cmAuthor.Text,
                Maker = selectedGroup(),
                CarName = tbReport.Text,
                Report = tbReport.Text,
                Picture = pbCar.Image
            };
            listCarReport.Add(carReport);   //レコード追加

            setCbAuthor(cmAuthor.Text);
            setCbCarName(cbCarName.Text);
        }

        //選択されているメーカーの列挙型を渡す
        private CarReport.MakerGroup selectedGroup() {
            foreach (var rb in gbMaker.Controls) {
                if (((RadioButton)rb).Checked) {
                    return (CarReport.MakerGroup)int.Parse(((string)((RadioButton)rb).Tag));
                }
            }
            return CarReport.MakerGroup.その他;
        }

        //コンボボックスに記録者をセットする
        private void setCbAuthor(string author) {
            if (!cmAuthor.Items.Contains(author)) {
                cmAuthor.Items.Add(author);
            }
        }
        //コンボボックスに車名をセットする
        private void setCbCarName(string carName) {
            if (!cmAuthor.Items.Contains(carName)) {
                cbCarName.Items.Add(carName);
            }
        }

        private void dgvRegistData_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1)
                return;

            //選択された行のデータを取得
            CarReport selectedCar = listCarReport[e.RowIndex];

            //取得したデータ項目を各コントロールへ設定
            dtpDate.Value = selectedCar.Date;
            cmAuthor.Text = selectedCar.Auther;
            SetMakerRadioButton(selectedCar.Maker);
            cbCarName.Text = selectedCar.CarName;
            tbReport.Text = selectedCar.Report;
            pbCar.Image = selectedCar.Picture;
        }

        private void SetMakerRadioButton(CarReport.MakerGroup mg) {
            switch (mg) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.外国車:
                    rbImport.Checked = true;
                    break;
                default:    //その他:
                    rbOther.Checked = true;
                    break;
            }
        }

        private void btDateDelete_Click(object sender, EventArgs e) {
            listCarReport.RemoveAt(dgvRegistData.CurrentRow.Index);
        }

        private void btFix_Click(object sender, EventArgs e) {
            listCarReport[dgvRegistData.CurrentRow.Index].UpDate(
                dtpDate.Value, cmAuthor.Text, selectedGroup(), cbCarName.Text, tbReport.Text, pbCar.Image);
        }
    }
}
