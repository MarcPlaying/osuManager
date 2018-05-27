using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osu_Manager_c
{
    public partial class TourneyManager : Form
    {
        public Boolean isintourney;
        public TourneyManager()
        {
            InitializeComponent();
        }

        private void TourneyManager_Load(object sender, EventArgs e)
        {
            String UserName = Environment.UserName;
            this.FormBorderStyle = FormBorderStyle.None;
            if (File.Exists("C:/Users/" + UserName + "/AppData/Local/osu!/tournament.cfg"))
            {
                isintourney = true;
                monoFlat_Button3.Text = "Disable Tournament";
            }
            else
            {
                isintourney = false;
                monoFlat_Button3.Text = "Enable Tournament";
            }

        }

        private void monoFlat_Button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void monoFlat_Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void monoFlat_Button3_Click(object sender, EventArgs e)
        {
            String UserName = Environment.UserName;
            if (isintourney == true)
            {
                File.Delete("C:/Users/" + UserName + "/AppData/Local/osu!/tournament.cfg");
                isintourney = false;
                monoFlat_Button3.Text = "Enable Tournament";
            }
            else
            {
                File.Create("C:/Users/" + UserName + "/AppData/Local/osu!/tournament.cfg");
                isintourney = true;
                monoFlat_Button3.Text = "Disable Tournament";
            }
        }

        private void monoFlat_Button4_Click(object sender, EventArgs e)
        {
            String UserName = Environment.UserName;
            System.Diagnostics.Process.Start("C:/Users/" + UserName + "/AppData/Local/osu!/osu!.exe");
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
    }
}
