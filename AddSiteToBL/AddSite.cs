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
using AddingSitesToBlackList;

namespace AddSiteToBL
{
    public partial class AddSite : Form
    {
        public AddSite()
        {
            InitializeComponent();
        }

        public Sites Sites { get; set; }

        private void addScreenButton_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Фотография|*.jpg;*.png;*.jpeg;*.bmp" };
            var dr = ofd.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            //
            Sites.BlockDate = DateTime.Now.AddMonths(1);
            //

            Sites.Adress = adressBox.Text;
            Sites.AdressPubl = adressPublBox.Text;
            Sites.Reason = reasonBox.Text;

            var stream = new MemoryStream();
            try
            {
                pictureBox1.Image.Save(stream, ImageFormat.Jpeg);

                Sites.Screenshot = stream.ToArray();
            }
            catch { }

            try
            {
                Sites.Violation = violationBox.SelectedItem.ToString();
                Sites.Stat = comboBox1.SelectedItem.ToString();
                Sites.PublishDate = PublishMightDateBox.Value.Date;
            }
            catch { }
        }

        private void AddSite_Load(object sender, EventArgs e)
        {
            adressBox.Text = Sites.Adress;
            adressPublBox.Text = Sites.AdressPubl;
            violationBox.SelectedItem = Sites.Violation;
            comboBox1.SelectedItem = Sites.Stat;
            reasonBox.Text = Sites.Reason;
            pictureBox1.Image = ByteToImage(Sites.Screenshot);
            PublishMightDateBox.Value = Sites.PublishDate;
        }

        //Stackoverflow method
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
    }
}
