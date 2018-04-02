using System.Windows.Forms;

namespace osu_Manager_c
{
    internal class Formrunner : Form
    {
        private Form soos;

        public Formrunner(Form soos)
        {
            this.soos = soos;
        }

        private void InitializeComponents()
        {
            this.SuspendLayout();
            // 
            // Formrunner
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Formrunner";
            this.Load += new System.EventHandler(this.Formrunner_Load);
            this.ResumeLayout(false);

        }

        private void Formrunner_Load(object sender, System.EventArgs e)
        {
            soos.Show();
            this.Hide();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Formrunner
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Formrunner";
            this.Load += new System.EventHandler(this.Formrunner_Load_1);
            this.ResumeLayout(false);

        }

        private void Formrunner_Load_1(object sender, System.EventArgs e)
        {

        }
    }
}