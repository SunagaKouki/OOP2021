
namespace Exercise1 {
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
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btAction = new System.Windows.Forms.Button();
            this.Year = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Month = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLeapYear = new System.Windows.Forms.TextBox();
            this.Birthday = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Month)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOutput
            // 
            this.tbOutput.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbOutput.Location = new System.Drawing.Point(12, 132);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(301, 31);
            this.tbOutput.TabIndex = 0;
            // 
            // btAction
            // 
            this.btAction.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAction.Location = new System.Drawing.Point(330, 85);
            this.btAction.Name = "btAction";
            this.btAction.Size = new System.Drawing.Size(88, 31);
            this.btAction.TabIndex = 1;
            this.btAction.Text = "実行";
            this.btAction.UseVisualStyleBackColor = true;
            this.btAction.Click += new System.EventHandler(this.btAction_Click);
            // 
            // Year
            // 
            this.Year.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Year.Location = new System.Drawing.Point(12, 25);
            this.Year.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(120, 31);
            this.Year.TabIndex = 2;
            this.Year.Tag = "";
            this.Year.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(138, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "年";
            // 
            // Month
            // 
            this.Month.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Month.Location = new System.Drawing.Point(189, 25);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(120, 31);
            this.Month.TabIndex = 4;
            this.Month.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(315, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "月";
            // 
            // Day
            // 
            this.Day.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Day.Location = new System.Drawing.Point(364, 25);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(120, 31);
            this.Day.TabIndex = 5;
            this.Day.ThousandsSeparator = true;
            this.Day.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(490, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "日";
            // 
            // tbLeapYear
            // 
            this.tbLeapYear.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbLeapYear.Location = new System.Drawing.Point(12, 85);
            this.tbLeapYear.Name = "tbLeapYear";
            this.tbLeapYear.Size = new System.Drawing.Size(301, 31);
            this.tbLeapYear.TabIndex = 6;
            // 
            // Birthday
            // 
            this.Birthday.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Birthday.Location = new System.Drawing.Point(12, 186);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(301, 31);
            this.Birthday.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Birthday);
            this.Controls.Add(this.tbLeapYear);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.btAction);
            this.Controls.Add(this.tbOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Month)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btAction;
        private System.Windows.Forms.NumericUpDown Year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Month;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Day;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLeapYear;
        private System.Windows.Forms.TextBox Birthday;
    }
}

