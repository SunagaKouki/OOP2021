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
        IEnumerable<ItemDate> items = null;

        public Form1() {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e) {
            setRssTitle(tbUrl.Text);
        }

        //指定したURL先からXMLデータを取得し、title要素を取得し、リストボックスへセットする
        private void setRssTitle(string url) {
            using (var wc = new WebClient()) {
                try {
                    wc.Headers.Add("Content-type", "charset=UTF-8");

                    var stream = wc.OpenRead(url);
                    XDocument xdoc = XDocument.Load(stream);

                    items = xdoc.Root.Descendants("item").Select(x => new ItemDate {
                        Title = (string)x.Element("title"),
                        Link = (string)x.Element("link"),
                        PubDate = (DateTime)x.Element("pubDate"),
                        Description = (string)x.Element("description")
                    });
                    lbTitles.Items.Clear();

                    foreach (var item in items) {
                        lbTitles.Items.Add(item.Title);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void lbTitles_Click(object sender, EventArgs e) {
            try {
                tbPubDate.Text = "更新の日付：";
                tbPubDate.Text += (items.ToArray()[lbTitles.SelectedIndex].PubDate.ToString());

                lbDescription.Text = "概要:";
                if (items.ToArray()[lbTitles.SelectedIndex].Description != null) {
                    lbDescription.Text += (items.ToArray()[lbTitles.SelectedIndex].Description);
                } else {
                    lbDescription.Text += "なし";
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDisplay_Click(object sender, EventArgs e) {
            try {
                Browser browser = new Browser();
                var url = new Uri(items.ToArray()[lbTitles.SelectedIndex].Link);
                browser.wbBrowser.Url = url;
                browser.Show();
            }
            catch (Exception) {
            }
        }
    }
}
