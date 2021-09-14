
namespace RssReader {
    partial class Browser {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.btReturn = new System.Windows.Forms.Button();
            this.btMove = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wbBrowser
            // 
            this.wbBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbBrowser.Location = new System.Drawing.Point(12, 60);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(1096, 559);
            this.wbBrowser.TabIndex = 0;
            this.wbBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbBrowser_DocumentCompleted);
            // 
            // btReturn
            // 
            this.btReturn.Font = new System.Drawing.Font("源ノ角ゴシック Code JP R", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btReturn.Location = new System.Drawing.Point(13, 13);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(102, 41);
            this.btReturn.TabIndex = 1;
            this.btReturn.Text = "戻る";
            this.btReturn.UseVisualStyleBackColor = true;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // btMove
            // 
            this.btMove.Font = new System.Drawing.Font("源ノ角ゴシック Code JP R", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btMove.Location = new System.Drawing.Point(131, 13);
            this.btMove.Name = "btMove";
            this.btMove.Size = new System.Drawing.Size(102, 41);
            this.btMove.TabIndex = 2;
            this.btMove.Text = "進む";
            this.btMove.UseVisualStyleBackColor = true;
            this.btMove.Click += new System.EventHandler(this.btMove_Click);
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("源ノ角ゴシック Code JP R", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btClose.Location = new System.Drawing.Point(249, 14);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(102, 41);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "閉じる";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 631);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btMove);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.wbBrowser);
            this.Name = "Browser";
            this.Text = "Browser";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Button btMove;
        private System.Windows.Forms.Button btClose;
        public System.Windows.Forms.WebBrowser wbBrowser;
    }
}