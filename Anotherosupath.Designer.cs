namespace osu_Manager_c
{
    partial class Anotherosupath
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.monoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.monoFlat_TextBox1 = new MonoFlat.MonoFlat_TextBox();
            this.monoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Button1 = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Label2 = new MonoFlat.MonoFlat_Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.monoFlat_HeaderLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-18, -19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 69);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // monoFlat_HeaderLabel1
            // 
            this.monoFlat_HeaderLabel1.AutoSize = true;
            this.monoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.monoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.monoFlat_HeaderLabel1.Location = new System.Drawing.Point(87, 33);
            this.monoFlat_HeaderLabel1.Name = "monoFlat_HeaderLabel1";
            this.monoFlat_HeaderLabel1.Size = new System.Drawing.Size(118, 20);
            this.monoFlat_HeaderLabel1.TabIndex = 1;
            this.monoFlat_HeaderLabel1.Text = "Path Correction";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.pictureBox1.Image = global::osu_Manager_c.Properties.Resources.if_folder_storage_files_2931141;
            this.pictureBox1.Location = new System.Drawing.Point(25, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // monoFlat_TextBox1
            // 
            this.monoFlat_TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_TextBox1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.monoFlat_TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.monoFlat_TextBox1.Image = null;
            this.monoFlat_TextBox1.Location = new System.Drawing.Point(7, 79);
            this.monoFlat_TextBox1.MaxLength = 32767;
            this.monoFlat_TextBox1.Multiline = false;
            this.monoFlat_TextBox1.Name = "monoFlat_TextBox1";
            this.monoFlat_TextBox1.ReadOnly = false;
            this.monoFlat_TextBox1.Size = new System.Drawing.Size(313, 41);
            this.monoFlat_TextBox1.TabIndex = 1;
            this.monoFlat_TextBox1.Text = "New Path";
            this.monoFlat_TextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.monoFlat_TextBox1.UseSystemPasswordChar = false;
            // 
            // monoFlat_Label1
            // 
            this.monoFlat_Label1.AutoSize = true;
            this.monoFlat_Label1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.monoFlat_Label1.Location = new System.Drawing.Point(8, 127);
            this.monoFlat_Label1.Name = "monoFlat_Label1";
            this.monoFlat_Label1.Size = new System.Drawing.Size(299, 15);
            this.monoFlat_Label1.TabIndex = 2;
            this.monoFlat_Label1.Text = "Default path is C:\\Users\\Username\\AppData\\Local\\osu!";
            // 
            // monoFlat_Button1
            // 
            this.monoFlat_Button1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button1.Image = null;
            this.monoFlat_Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button1.Location = new System.Drawing.Point(36, 156);
            this.monoFlat_Button1.Name = "monoFlat_Button1";
            this.monoFlat_Button1.Size = new System.Drawing.Size(244, 41);
            this.monoFlat_Button1.TabIndex = 3;
            this.monoFlat_Button1.Text = "Send";
            this.monoFlat_Button1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button1.Click += new System.EventHandler(this.monoFlat_Button1_Click);
            // 
            // monoFlat_Label2
            // 
            this.monoFlat_Label2.AutoSize = true;
            this.monoFlat_Label2.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.monoFlat_Label2.Location = new System.Drawing.Point(35, 200);
            this.monoFlat_Label2.Name = "monoFlat_Label2";
            this.monoFlat_Label2.Size = new System.Drawing.Size(247, 15);
            this.monoFlat_Label2.TabIndex = 4;
            this.monoFlat_Label2.Text = "If you send it you must Restart the Programm";
            // 
            // Anotherosupath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(332, 247);
            this.Controls.Add(this.monoFlat_Label2);
            this.Controls.Add(this.monoFlat_Button1);
            this.Controls.Add(this.monoFlat_Label1);
            this.Controls.Add(this.monoFlat_TextBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Anotherosupath";
            this.Text = "Anotherosupath";
            this.Load += new System.EventHandler(this.Anotherosupath_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MonoFlat.MonoFlat_HeaderLabel monoFlat_HeaderLabel1;
        private MonoFlat.MonoFlat_TextBox monoFlat_TextBox1;
        private MonoFlat.MonoFlat_Label monoFlat_Label1;
        private MonoFlat.MonoFlat_Button monoFlat_Button1;
        private MonoFlat.MonoFlat_Label monoFlat_Label2;
    }
}