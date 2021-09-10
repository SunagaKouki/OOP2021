using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        Dictionary<string, string> websitedic = new Dictionary<string, string>();   //titleとlinkを紐づける

        public Form1() {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e) {
            setRssTitle(tbUrl.Text);
        }

        //指定したURL先からXMLデータを取得し、title要素を取得し、リストボックスへセットする
        private void setRssTitle(string url) {
            using (var wc = new WebClient()) {
                wc.Headers.Add("Content-type", "charset=UTF-8");

                var stream = wc.OpenRead(url);
                XDocument xdoc = XDocument.Load(stream);

                var titles = xdoc.Root.Descendants("title").ToArray();
                var links = xdoc.Root.Descendants("link").ToArray();
                lbTitles.Items.Clear();

                for (int i = 0; i < titles.Length; i++) {
                    websitedic.Add(titles[i].Value, links[i].Value);
                }

                foreach (var title in websitedic.Keys) {
                    lbTitles.Items.Add(title);
                }
            }
        }

        private void lbTitles_Click(object sender, EventArgs e) {
            if (websitedic.TryGetValue(lbTitles.SelectedItem.ToString(), out var urlstring)) {
                wbBrowser.Url = new Uri(urlstring);
            }
        }
    }
}
