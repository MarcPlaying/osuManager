using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace osu_Manager_c
{
    public partial class Restart : Form
    {
        public Restart()
        {
            InitializeComponent();
        }

        private void Restart_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            foreach (Form form in Start.iList)
            {
                form.Close();
            }


            String path = Application.StartupPath+ "/restarthandler.bat";
            
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("@echo off");
                    sw.WriteLine("echo The Programm now Restart! Please wait some Secounds....");
                    sw.WriteLine("timeout 5 > NUL");
                    sw.WriteLine("start "+ Application.StartupPath + " restarthandler.bat");
                    sw.WriteLine("The Programm is now Online.");
                }
            

            System.Diagnostics.Process.Start(path);

            Application.Exit();




        }

        


    }
}
