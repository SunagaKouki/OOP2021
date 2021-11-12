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
    public partial class fmMain : Form {
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public fmMain() {
            InitializeComponent();
            //dgvRegistData.DataSource = listCarReport;
        }

        //アプリケーション終了  OK
        private void buFinish_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        //画像展開ボタン  OK
        private void btOpen_Click(object sender, EventArgs e) {
            if (ofdPictureOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }

        //画像削除ボタン  OK
        private void btDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        //選択されているメーカーの列挙型を渡す  OK
        private CarReport.MakerGroup selectedGroup() {
            foreach (var rb in gbMaker.Controls) {
                if (((RadioButton)rb).Checked) {
                    return (CarReport.MakerGroup)int.Parse(((string)((RadioButton)rb).Tag));
                }
            }
            return CarReport.MakerGroup.その他;
        }

        //コンボボックスに記録者をセットする  OK
        private void setCbAuthor(string author) {
            if (!cmAuthor.Items.Contains(author)) {
                cmAuthor.Items.Add(author);
            }
        }

        //コンボボックスに車名をセットする  OK
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
            pbPicture.Image = selectedCar.Picture;
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

        private void carReportBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202131DataSet);

        }

        private void Form1_Load(object sender, EventArgs e) {
            carReportDataGridView.CurrentRow.Cells[0].Value = false;
            dtpDate.Value = (DateTime)carReportDataGridView.CurrentRow.Cells[1].Value;
            cmAuthor.Text = (string)carReportDataGridView.CurrentRow.Cells[2].Value;
            gbMaker.Tag = carReportDataGridView.CurrentRow.Cells[3].Value;
            cbCarName.Text = (string)carReportDataGridView.CurrentRow.Cells[4].Value;
            tbReport.Text = (string)carReportDataGridView.CurrentRow.Cells[5].Value;
            pbPicture.Image = (Image)carReportDataGridView.CurrentRow.Cells[6].Value;
        }

        //接続ボタン
        private void btConnect_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202131DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableAdapter.Fill(this.infosys202131DataSet.CarReport);

            bindingNavigator1.Enabled = true;
        }

        //更新ボタン  OK
        private void btUpdate_Click(object sender, EventArgs e) {
            if (carReportDataGridView.CurrentRow == null) {
                return;
            }
            carReportDataGridView.CurrentRow.Cells[1].Value = dtpDate.Value;    //日付
            carReportDataGridView.CurrentRow.Cells[2].Value = cmAuthor.Text;    //記録者
            carReportDataGridView.CurrentRow.Cells[3].Value = selectedGroup();  //メーカー
            carReportDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;   //車名
            carReportDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;    //レポート
            carReportDataGridView.CurrentRow.Cells[6].Value = ImageToByteArray(pbPicture.Image);  //画像

            //データベースへ反映
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202131DataSet);
        }

        private void carReportDataGridView_SelectionChanged(object sender, EventArgs e) {
            if (carReportDataGridView.CurrentRow == null) {
                return;
            }
            try {
                dtpDate.Value = (DateTime)carReportDataGridView.CurrentRow.Cells[1].Value;
                cmAuthor.Text = carReportDataGridView.CurrentRow.Cells[2].Value.ToString();
                //SetMakerRadioButton((CarReport.MakerGroup)carReportDataGridView.CurrentRow.Cells[3].Value);
                SetMakerRadioButton((CarReport.MakerGroup)Enum.Parse(typeof(CarReport.MakerGroup), carReportDataGridView.CurrentRow.Cells[3].Value.ToString()));
                //メーカー（文字列 → 列挙型）
                cbCarName.Text = carReportDataGridView.CurrentRow.Cells[4].Value.ToString();
                tbReport.Text = carReportDataGridView.CurrentRow.Cells[5].Value.ToString();
                pbPicture.Image = ByteArrayToImage((byte[])carReportDataGridView.CurrentRow.Cells[6].Value);
            }
            catch (Exception) {
                pbPicture.Image = null;
            }
        }

        // バイト配列をImageオブジェクトに変換  OK
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }
        // Imageオブジェクトをバイト配列に変換  OK
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }
        //OK
        private void carReportDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e) {

        }
    }
}
