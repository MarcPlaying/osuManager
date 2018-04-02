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
using System.IO;
using Ionic.Zip;

namespace osu_Manager_c
{
    public partial class Skin_Downloader : Form
    {
        public Skin_Downloader()
        {
            InitializeComponent();
        }

        public int rand;

        public int download = 0;

        private void Skin_Downloader_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            String UserName = Environment.UserName;
            Random r = new Random();
            int rint = r.Next(1, 20000000);
            using (var client = new WebClient())
            {
                client.DownloadFile(Config.SiteForSkins, Config.mainDir + rint + ".zip");
            }
            rand = rint;

            ExtractFileToDirectory(Config.mainDir + rint + ".zip", "C:/Users/" + UserName + "/AppData/Roaming/osu!Manager/Sk" + rint);
            DirectoryInfo d = new DirectoryInfo(Config.mainDir + "/Sk" + rint);
            FileInfo[] Files = d.GetFiles("*.txt");
            foreach (FileInfo file in Files)
            {
                String i = file.Name;
                String i2 = i.Replace(".txt", ".osk");
                listBox1.Items.Add(i2);
            }
        }

        public void ExtractFileToDirectory(string zipFileName, string outputDirectory)
        {
            ZipFile zip = ZipFile.Read(zipFileName);
            Directory.CreateDirectory(outputDirectory);
            zip.ExtractAll(outputDirectory);
        }

        private void monoFlat_Button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("You  must select a Skin");
            }
            else
            {
                String UserName = Environment.UserName;
                String url2;
                monoFlat_Label1.Text = listBox1.SelectedItem.ToString();
                String item = listBox1.SelectedItem.ToString();
                using (var streamReader = File.OpenText(Config.mainDir +"/Sk" + rand + "/" + item.Replace(".osk", ".txt")))
                {
                    String url = streamReader.ReadLine();
                    url2 = url;
                    streamReader.Close();
                }
                using (var client = new WebClient())
                {
                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                    Random r = new Random();
                    int r22 = r.Next(1, 2000);
                    if (Properties.Settings.Default.usepath == true)
                    {
                        client.DownloadFileAsync(new Uri(url2), @Properties.Settings.Default.path + @"\Skins\" + "mgr " + listBox1.SelectedItem.ToString() + ".osk");
                    }
                    else
                    {
                        client.DownloadFileAsync(new Uri(url2), @"C:\Users\" + UserName + @"\AppData\Local\osu!\Skins\" + "mgr " + listBox1.SelectedItem.ToString() + ".osk");
                    }

                }



            }

        }
        public void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
        }
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            String i = listBox1.SelectedItem.ToString();
            String i2 = i;  i2 = i.Replace(".txt", ".osk");
            monoFlat_Label3.Text = "Download of \n" + i2+ " \nis completed";
        }

        private bool dragging;
        private Point pointClicked;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                pointClicked = new Point(e.X, e.Y);
            }
            else
            {
                dragging = false;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point pointMoveTo;
                pointMoveTo = this.PointToScreen(new Point(e.X, e.Y));
                pointMoveTo.Offset(-pointClicked.X, -pointClicked.Y);
                this.Location = pointMoveTo;
            }
        }
    } 
}
