using AddingSitesToBlackList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AddSiteToBL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ads = new AddSite() { Sites = new Sites() };
            if (ads.ShowDialog(this) == DialogResult.OK)
            {
                listBox1.Items.Add(ads.Sites);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Sites)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = listBox1.SelectedItem is Sites;
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                var item = (Sites)listBox1.Items[index];
                var ads = new AddSite() { Sites = item };
                if (ads.ShowDialog(this) == DialogResult.OK)
                {
                    listBox1.Items.Remove(item);
                    listBox1.Items.Insert(index, item);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() { Filter = "Сайт|*.site" };

            if (sfd.ShowDialog(this) != DialogResult.OK)
                return;

            var site = new AddingSitesToBlackListClass();
            {
                site.SitesList = listBox1.Items.OfType<Sites>().ToList();
            };

            var xs = new XmlSerializer(typeof(AddingSitesToBlackListClass));

            var file = File.Create(sfd.FileName);

            xs.Serialize(file, site);
            file.Close();
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Сайт|*.site" };

            if (ofd.ShowDialog(this) != DialogResult.OK)
                return;

            var xs = new XmlSerializer(typeof(AddingSitesToBlackListClass));
            var file = File.OpenRead(ofd.FileName);
            var site = (AddingSitesToBlackListClass)xs.Deserialize(file);
            file.Close();

            listBox1.Items.Clear();
            foreach (var s in site.SitesList)
            {
                listBox1.Items.Add(s);
            }
        }
    }
}
