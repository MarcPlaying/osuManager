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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Random rand = new Random();
        public int soos;
        public static String ver = "1.1.0";
        private void Form1_Load(object sender, EventArgs e)
        {
            Start.iList.Add(this);
            String UserName = Environment.UserName;
            this.FormBorderStyle = FormBorderStyle.None;
            System.IO.Directory.CreateDirectory(Config.mainDir);
            bool vip = false;
            //try
            //{
            //   using (var client = new WebClient())
            //            {
            //
            // string a = client.DownloadString("https://marc.enjuu.click/manager/vip/" + UserName + ".txt");
            // vip = true;
            //    }
            //
            // }
            //  catch
            //  {
            // vip = false;
            //    }
            if (vip == true)
            {
                pictureBox28.Visible = true;
            }
            else
            {
                pictureBox28.Visible = false;
            }
            using (var client = new WebClient())
            {
                String newestver = "";
                try
                {
                    //NEWESTVER
                    string getver = client.DownloadString(Config.localserv + "\ver\ver.txt");
                    newestver = client.DownloadString(getver);
                }
                catch
                {

                }
                if(newestver == ver)
                {

                }
                else
                {
                    MessageBox.Show("A new Version is available This ver: "+ver+" New ver: "+newestver);
                    try
                    {
                        System.Diagnostics.Process.Start(Config.siteforupadate);
                    }
                    catch
                    {
                        Form error = new errornet("355 ", "WebBrowser not Found", "The WebBrowser for the Update could'nt Start", "Now you must open the Page by self");
                        error.Show();
                    }
                    
                }
            }

            

            if (Properties.Settings.Default.loggedin == true)
            {
                
            }
            if (Properties.Settings.Default.loggedin == true)
            {
                if(Properties.Settings.Default.loggedinnew == true)
                {

                }
                else
                {
                    using (var client = new WebClient())
                    {
                       
                        
                    }
                }
                
            }
            if (Properties.Settings.Default.loggedinnew == true){
                using (var client = new WebClient())
                {
                    if(Properties.Settings.Default.osuUserID == "0")
                    {
                        
                        soos = rand.Next(1, 1000);
                        client.DownloadFile("https://a.ppy.sh/" + Properties.Settings.Default.osuUserID, Config.mainDir +"/pb" + soos + ".png");
                        pictureBox10.Image = Image.FromFile(Config.mainDir + "/pb" + soos + ".png");
                        Properties.Settings.Default.loggedinnew = false;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        
                    }
                    
                }
            }
            else
            {
                Properties.Settings.Default.osuUserName = null;
                Properties.Settings.Default.osuUserID = null;
                Properties.Settings.Default.loggedin = false;
                ResetUser otherForm = new ResetUser();
                otherForm.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                otherForm.Show();
            }

            if (Properties.Settings.Default.loggedin == true)
            {
                label14.Text = Properties.Settings.Default.osuUserName;
                label24.Text = "( "+Properties.Settings.Default.osuUserID+" )";
                using (var client = new WebClient())
                {
                    try
                    {
                        client.DownloadFile("https://a.ppy.sh/" + Properties.Settings.Default.osuUserID, Config.mainDir + "/pb" + soos + ".png");
                    }
                    catch
                    {

                    }
                    
                    
                }
                try
                {
                    pictureBox10.Image = Image.FromFile(Config.mainDir + "/pb" + soos + ".png");
                }
                catch
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile("https://marc.enjuu.click/manager/user.png", Config.mainDir + "/nli.png");
                    }
                    pictureBox10.Image = Image.FromFile(Config.mainDir + "/nli.png");
                }
                

            }
            else
            {
               
                label14.Text = "Not Logged In!";
                label24.Text = null;
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://marc.enjuu.click/manager/user.png", Config.mainDir + "/nli.png");
                }
                pictureBox10.Image = Image.FromFile(Config.mainDir + "/nli.png");
                Properties.Settings.Default.osuUserName = null;
                Properties.Settings.Default.osuUserID = null;
                Properties.Settings.Default.loggedin = false;
                ResetUser otherForm = new ResetUser();
                otherForm.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
                otherForm.Show();
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;

            }


        }
        void otherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                String UserName = Environment.UserName;
                client.DownloadFile("http://m2.ppy.sh/r/osu!install.exe", Config.mainDir + "/install.exe");
                System.Diagnostics.Process.Start(Config.mainDir + "/install.exe");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                String UserName = Environment.UserName;
                client.DownloadFile("http://m2.ppy.sh/r/osu!install.exe", Config.mainDir + "/install.exe");
                System.Diagnostics.Process.Start(Config.mainDir + "/install.exe");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.usepath == true)
            {
                System.Diagnostics.Process.Start(Properties.Settings.Default.path + "/osu!.exe");
            }
            else
            {
                String UserName = Environment.UserName;
                System.Diagnostics.Process.Start("C:/Users/" + UserName + "/AppData/Local/osu!/osu!.exe");
            }
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                String UserName = Environment.UserName;
                client.DownloadFile("http://space.enjuu.click/marcspace/install.exe", Config.mainDir + "/osu!Manager/installlazer.exe");
                System.Diagnostics.Process.Start(Config.mainDir + "/osu!Manager/installlazer.exe");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                String UserName = Environment.UserName;
                client.DownloadFile("http://space.enjuu.click/marcspace/install.exe", Config.mainDir + "/osu!Manager/installlazer.exe");
                System.Diagnostics.Process.Start(Config.mainDir + "/osu!Manager/installlazer.exe");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            String UserName = Environment.UserName;
            System.Diagnostics.Process.Start("C:/Users/" + UserName + "/AppData/Local/osulazer/osu!.exe");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            String UserName = Environment.UserName;
            System.Diagnostics.Process.Start("C:/Users/" + UserName + "/AppData/Local/osulazer/osu!.exe");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {




           

            using (WebClient wc = new WebClient())
            {
                String UserName = Environment.UserName;
                Properties.Settings.Default.loggedin = true;
                Properties.Settings.Default.Save();
                

                

                if (Properties.Settings.Default.loggedin == true)
                {
                    
                    pictureBox10.Image = Image.FromFile(Config.mainDir + "/pb.png");
                    label14.Text = Properties.Settings.Default.osuUserName;
                    label24.Text = Properties.Settings.Default.osuUserID;
                }

                

            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.osuUserName = null;
            Properties.Settings.Default.osuUserID = null;
            Properties.Settings.Default.loggedin = false;
            
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public void MenuGen(String what)
        {
            if(what == "Start")
            {
                Panel credits = panel17;
                Panel settings = panel10;

                credits.Visible = false;
                settings.Visible = false;
            }else if(what == "Settings")
            {
                Panel credits = panel17;
                Panel settings = panel10;

                credits.Visible = false;
                settings.Visible = true;
            }
            else if(what == "Credits")
            {
                Panel credits = panel17;
                Panel settings = panel10;
                settings.Visible = true;
                credits.Visible = true;
            }
            else
            {
                MessageBox.Show("404 Not Found");
            }
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            MenuGen("Settings");
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            MenuGen("Start");
        }

        private void label19_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.osuUserName = null;
            Properties.Settings.Default.osuUserID = null;
            Properties.Settings.Default.loggedin = false;
            Form lgd = new ResetUser();
            lgd.Show();
            this.Hide();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            String UserName = Environment.UserName;
            try
            {
                Directory.Delete(Config.mainDir, true);
            }
            catch
            {

            }
            
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            Form user = new User(Properties.Settings.Default.osuUserName, Properties.Settings.Default.osuUserID);
            user.Show();
        }

        private void label25_Click(object sender, EventArgs e)
        {
            Form user = new User(Properties.Settings.Default.osuUserName, Properties.Settings.Default.osuUserID);
            user.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            Form form = new UserSearch();
            form.Show();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            Form form = new UserSearch();
            form.Show();
        }

        private void label27_Click(object sender, EventArgs e)
        {
            Form i = new TourneyManager();
            i.Show();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            Form i = new TourneyManager();
            i.Show();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            Form soos = new Skin_Downloader();
            soos.Show();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            factoryreset();
        }

        public void factoryreset()
        {
            String UserName = Environment.UserName;
            try
            {
                Properties.Settings.Default.osuUserName = null;
                Properties.Settings.Default.osuUserID = null;
                Properties.Settings.Default.loggedin = false;
                Directory.Delete(Config.mainDir, true);
                Properties.Settings.Default.osuUserName = null;
                Properties.Settings.Default.osuUserID = null;
                Properties.Settings.Default.loggedin = false;
                Properties.Settings.Default.usepath = false;
                Properties.Settings.Default.Reset();
                Properties.Settings.Default.Save();
                Application.Exit();
            }
            catch
            {
                Properties.Settings.Default.osuUserName = null;
                Properties.Settings.Default.osuUserID = null;
                Properties.Settings.Default.loggedin = false;
                Properties.Settings.Default.osuUserName = null;
                Properties.Settings.Default.osuUserID = null;
                Properties.Settings.Default.loggedin = false;
                Properties.Settings.Default.usepath = false;
                Properties.Settings.Default.Reset();
                Properties.Settings.Default.Save();
                Application.Exit();
            }

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {
            factoryreset();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            MenuGen("Settings");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            MenuGen("Settings");
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            MenuGen("Credits");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            MenuGen("Credits");
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            MenuGen("Credits");
        }

        private void label11_Click_1(object sender, EventArgs e)
        {
            Form form = new Anotherosupath();
            form.Show();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            Form form = new Anotherosupath();
            form.Show();
        }
    }
}


