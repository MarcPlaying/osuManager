using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osu_Manager_c
{
    public partial class Anotherosupath : Form
    {
        public Anotherosupath()
        {
            InitializeComponent();
        }

        private void Anotherosupath_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void monoFlat_Button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.usepath = true;
            Properties.Settings.Default.path = monoFlat_TextBox1.Text;
            Properties.Settings.Default.Save();
            Application.Exit();
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
