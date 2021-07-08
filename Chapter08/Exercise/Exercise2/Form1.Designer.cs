
namespace Exercise2 {
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
            this.lbTimerDisp = new System.Windows.Forms.Label();
            this.btStartDisp = new System.Windows.Forms.Button();
            this.btStopDIsp = new System.Windows.Forms.Button();
            this.btCleanDIsp = new System.Windows.Forms.Button();
            this.btLapDIsp = new System.Windows.Forms.Button();
            this.lbLap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTimerDisp
            // 
            this.lbTimerDisp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbTimerDisp.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTimerDisp.Location = new System.Drawing.Point(12, 9);
            this.lbTimerDisp.Name = "lbTimerDisp";
            this.lbTimerDisp.Size = new System.Drawing.Size(216, 46);
            this.lbTimerDisp.TabIndex = 0;
            this.lbTimerDisp.Text = "00:00:00:00";
            this.lbTimerDisp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btStartDisp
            // 
            this.btStartDisp.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btStartDisp.Location = new System.Drawing.Point(12, 68);
            this.btStartDisp.Name = "btStartDisp";
            this.btStartDisp.Size = new System.Drawing.Size(105, 49);
            this.btStartDisp.TabIndex = 1;
            this.btStartDisp.Text = "スタート";
            this.btStartDisp.UseVisualStyleBackColor = true;
            this.btStartDisp.Click += new System.EventHandler(this.btStartDisp_Click);
            // 
            // btStopDIsp
            // 
            this.btStopDIsp.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btStopDIsp.Location = new System.Drawing.Point(123, 68);
            this.btStopDIsp.Name = "btStopDIsp";
            this.btStopDIsp.Size = new System.Drawing.Size(105, 49);
            this.btStopDIsp.TabIndex = 2;
            this.btStopDIsp.Text = "ストップ";
            this.btStopDIsp.UseVisualStyleBackColor = true;
            this.btStopDIsp.Click += new System.EventHandler(this.btStopDIsp_Click);
            // 
            // btCleanDIsp
            // 
            this.btCleanDIsp.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btCleanDIsp.Location = new System.Drawing.Point(12, 123);
            this.btCleanDIsp.Name = "btCleanDIsp";
            this.btCleanDIsp.Size = new System.Drawing.Size(105, 49);
            this.btCleanDIsp.TabIndex = 3;
            this.btCleanDIsp.Text = "リセット";
            this.btCleanDIsp.UseVisualStyleBackColor = true;
            this.btCleanDIsp.Click += new System.EventHandler(this.btCleanDIsp_Click);
            // 
            // btLapDIsp
            // 
            this.btLapDIsp.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btLapDIsp.Location = new System.Drawing.Point(124, 123);
            this.btLapDIsp.Name = "btLapDIsp";
            this.btLapDIsp.Size = new System.Drawing.Size(104, 49);
            this.btLapDIsp.TabIndex = 4;
            this.btLapDIsp.Text = "ラップ　→";
            this.btLapDIsp.UseVisualStyleBackColor = true;
            this.btLapDIsp.Click += new System.EventHandler(this.btLapDIsp_Click);
            // 
            // lbLap
            // 
            this.lbLap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbLap.Location = new System.Drawing.Point(235, 13);
            this.lbLap.Name = "lbLap";
            this.lbLap.Size = new System.Drawing.Size(121, 159);
            this.lbLap.TabIndex = 5;
            this.lbLap.Text = "lbLap";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(368, 188);
            this.Controls.Add(this.lbLap);
            this.Controls.Add(this.btLapDIsp);
            this.Controls.Add(this.btCleanDIsp);
            this.Controls.Add(this.btStopDIsp);
            this.Controls.Add(this.btStartDisp);
            this.Controls.Add(this.lbTimerDisp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTimerDisp;
        private System.Windows.Forms.Button btStartDisp;
        private System.Windows.Forms.Button btStopDIsp;
        private System.Windows.Forms.Button btCleanDIsp;
        private System.Windows.Forms.Button btLapDIsp;
        private System.Windows.Forms.Label lbLap;
    }
}

