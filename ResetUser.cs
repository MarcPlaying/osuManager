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

namespace osu_Manager_c
{
    public partial class ResetUser : Form
    {
        public ResetUser()
        {
            InitializeComponent();
        }

        private void ResetUser_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void monoFlat_Button1_Click(object sender, EventArgs e)
        {
            if(monoFlat_Toggle1.Toggled == false)
            {
                MessageBox.Show("You must Check the Toggle for using osu!Manager");
            }
            else
            {
                Properties.Settings.Default.osuUserName = monoFlat_TextBox1.Text;

                using (WebClient wc = new WebClient())
                {
                    String UserName = Environment.UserName;
                    string json = wc.DownloadString("https://osu.ppy.sh/api/get_user?k="+Config.osuAPIkey+"&u=" + monoFlat_TextBox1.Text);
                    String result1 = System.Text.RegularExpressions.Regex.Match(json, @"\d+").Value;
                    Properties.Settings.Default.osuUserID = result1;
                    Properties.Settings.Default.loggedin = true;
                    Properties.Settings.Default.loggedinnew = true;
                    Properties.Settings.Default.Save();
                    Form main = new Form1();
                    main.Show();
                    this.Hide();
                }
            }
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
