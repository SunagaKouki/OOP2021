using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RssReader {
    public partial class Browser : Form {
        public Browser() {
            InitializeComponent();
        }

        private void btReturn_Click(object sender, EventArgs e) {
            wbBrowser.GoBack();
        }

        private void btMove_Click(object sender, EventArgs e) {
            wbBrowser.GoForward();
        }

        private void wbBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {
            btReturn.Enabled = wbBrowser.CanGoBack;
            btMove.Enabled = wbBrowser.CanGoForward;
        }
    }
}
