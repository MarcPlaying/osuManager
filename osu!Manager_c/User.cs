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
using Gecko;

namespace osu_Manager_c

{

    

    public partial class User : Form
    {
        public bool Badges = false;
        public enum BadgesEn
        {
            MyHero,
            Creator,
            Friend
        };
        public string Username;
        public string UserID;

        public User(string un, string uid)
        {
            Username = un;
            UserID = uid;
            InitializeComponent();
            Xpcom.Initialize("Firefox");

        }

        private void User_Load(object sender, EventArgs e)
        {
            String UserName = Environment.UserName;
            this.FormBorderStyle = FormBorderStyle.None;
            label1.Text = "User profile of - "+Username + "(" + UserID +  ")";
            webBrowser1.Navigate("https://new.ppy.sh/u/"+UserID);
            Random rnd = new Random();
            int avatar = rnd.Next(1, 1000000000);
            using (var client = new WebClient())
            {
                try
                {
                    client.DownloadFile("https://a.ppy.sh/" + UserID, "C:/Users/" + UserName + "/AppData/Roaming/osu!Manager/" + avatar + ".png");
                }
                catch
                {
                    
                }
                
            }
            String badges;
            using (var client = new WebClient())
            {

                try
                {
                    //NEWSERV
                    string getbad = client.DownloadString(Config.localserv + @"\paths/GET_BADGES.txt");
                    badges = client.DownloadString(Config.localserv + getbad + Username + ".txt");
                }
                catch
                {
                    badges = "failure";
                }

                if(badges == "failure")
                {

                }
                else
                {
                    this.Size = new Size(995, 754);
                    monoFlat_Label1.Visible = true;
                    if(badges == "soos")
                    {
                        pictureBox3.Image = Properties.Resources.if_Flash_631544;
                    }
                    else if(badges == "soossaas")
                    {
                        pictureBox3.Image = Properties.Resources.if_Flash_631544;
                        pictureBox4.Image = Properties.Resources.if_user_1287507;
                    }else if(badges =="soossaassees")
                    {
                        pictureBox3.Image = Properties.Resources.if_Flash_631544;
                        pictureBox4.Image = Properties.Resources.if_user_1287507;
                        pictureBox5.Image = Properties.Resources.if_Instagram_UI_15_2315584;
                    }else if(badges == "sees")
                    {
                        pictureBox3.Image = Properties.Resources.if_Instagram_UI_15_2315584;
                    }else if(badges == "saas")
                    {
                        pictureBox3.Image = Properties.Resources.if_user_1287507;
                    }
                    else
                    {
                        MessageBox.Show("ERROR 404");
                    }
                }
                   
                

            }

            try
            {
                pictureBox1.Image = Image.FromFile("C:/Users/" + UserName + "/AppData/Roaming/osu!Manager/" + avatar + ".png");
            }
            catch
            {
                pictureBox1.Image = (Image)Properties.Resources.if_1041_boy_c_2400506;
               
            }
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void panel1_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
