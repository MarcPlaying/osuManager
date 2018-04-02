using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osu_Manager_c
{
    public partial class downloader : Form
    {

        public String path;
        public String filetodownload;

        public downloader(String path, String Filetodownload)
        {
            InitializeComponent();
            this.path = path;
            filetodownload = Filetodownload;
        }

        private void downloader_Load(object sender, EventArgs e)
        {
            this.Hide();
            using (var client = new WebClient())
            {
                client.DownloadFile(filetodownload, path);
            }

            MessageBox.Show("The File "+filetodownload+ "was downloaded and it was saved in "+path);
            ;
        }

        
    }
}
