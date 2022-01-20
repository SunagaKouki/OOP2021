
namespace InventoryControl {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.LbTimeDate = new System.Windows.Forms.Label();
            this.LbTime = new System.Windows.Forms.Label();
            this.LbSec = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LbTimeDate
            // 
            this.LbTimeDate.AutoSize = true;
            this.LbTimeDate.Font = new System.Drawing.Font("HGPｺﾞｼｯｸM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LbTimeDate.Location = new System.Drawing.Point(196, 162);
            this.LbTimeDate.Name = "LbTimeDate";
            this.LbTimeDate.Size = new System.Drawing.Size(187, 19);
            this.LbTimeDate.TabIndex = 0;
            this.LbTimeDate.Text = "2000年01月01日(水)";
            // 
            // LbTime
            // 
            this.LbTime.AutoSize = true;
            this.LbTime.Font = new System.Drawing.Font("MS UI Gothic", 60F);
            this.LbTime.Location = new System.Drawing.Point(181, 181);
            this.LbTime.Name = "LbTime";
            this.LbTime.Size = new System.Drawing.Size(210, 80);
            this.LbTime.TabIndex = 1;
            this.LbTime.Text = "09:00";
            // 
            // LbSec
            // 
            this.LbSec.AutoSize = true;
            this.LbSec.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LbSec.Location = new System.Drawing.Point(372, 225);
            this.LbSec.Name = "LbSec";
            this.LbSec.Size = new System.Drawing.Size(43, 29);
            this.LbSec.TabIndex = 3;
            this.LbSec.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LbSec);
            this.Controls.Add(this.LbTime);
            this.Controls.Add(this.LbTimeDate);
            this.Name = "Form1";
            this.Text = "管理画面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTimeDate;
        private System.Windows.Forms.Label LbTime;
        private System.Windows.Forms.Label LbSec;
        private System.Windows.Forms.Timer timer1;
    }
}

