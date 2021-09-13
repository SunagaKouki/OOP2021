
namespace RssReader {
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.lbTitles = new System.Windows.Forms.ListBox();
            this.btRead = new System.Windows.Forms.Button();
            this.lbDescription = new System.Windows.Forms.Label();
            this.tbPubDate = new System.Windows.Forms.TextBox();
            this.btDisplay = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("源ノ角ゴシック Code JP R", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "RssReader";
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("源ノ角ゴシック Code JP R", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUrl.Location = new System.Drawing.Point(192, 14);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(624, 26);
            this.tbUrl.TabIndex = 1;
            // 
            // lbTitles
            // 
            this.lbTitles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTitles.FormattingEnabled = true;
            this.lbTitles.HorizontalScrollbar = true;
            this.lbTitles.ItemHeight = 15;
            this.lbTitles.Location = new System.Drawing.Point(18, 73);
            this.lbTitles.Name = "lbTitles";
            this.lbTitles.Size = new System.Drawing.Size(395, 544);
            this.lbTitles.TabIndex = 2;
            this.lbTitles.Click += new System.EventHandler(this.lbTitles_Click);
            // 
            // btRead
            // 
            this.btRead.Font = new System.Drawing.Font("源ノ角ゴシック Code JP R", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btRead.Location = new System.Drawing.Point(843, 10);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(91, 32);
            this.btRead.TabIndex = 4;
            this.btRead.Text = "読み込み";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // lbDescription
            // 
            this.lbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDescription.BackColor = System.Drawing.SystemColors.Info;
            this.lbDescription.Font = new System.Drawing.Font("源ノ角ゴシック Code JP R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbDescription.Location = new System.Drawing.Point(439, 163);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(662, 168);
            this.lbDescription.TabIndex = 5;
            // 
            // tbPubDate
            // 
            this.tbPubDate.Font = new System.Drawing.Font("源ノ角ゴシック Code JP R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbPubDate.Location = new System.Drawing.Point(444, 73);
            this.tbPubDate.Multiline = true;
            this.tbPubDate.Name = "tbPubDate";
            this.tbPubDate.Size = new System.Drawing.Size(465, 42);
            this.tbPubDate.TabIndex = 6;
            // 
            // btDisplay
            // 
            this.btDisplay.Font = new System.Drawing.Font("源ノ角ゴシック Code JP R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDisplay.Location = new System.Drawing.Point(943, 73);
            this.btDisplay.Name = "btDisplay";
            this.btDisplay.Size = new System.Drawing.Size(158, 42);
            this.btDisplay.TabIndex = 7;
            this.btDisplay.Text = "Webを表示";
            this.btDisplay.UseVisualStyleBackColor = true;
            this.btDisplay.Click += new System.EventHandler(this.btDisplay_Click);
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("源ノ角ゴシック Code JP R", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btExit.Location = new System.Drawing.Point(797, 358);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(304, 51);
            this.btExit.TabIndex = 8;
            this.btExit.Text = "アプリケーションを終了する";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 651);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btDisplay);
            this.Controls.Add(this.tbPubDate);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.lbTitles);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "  ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.ListBox lbTitles;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox tbPubDate;
        private System.Windows.Forms.Button btDisplay;
        private System.Windows.Forms.Button btExit;
    }
}

