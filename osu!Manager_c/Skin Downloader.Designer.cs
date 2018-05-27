namespace osu_Manager_c
{
    partial class Skin_Downloader
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.monoFlat_Label2 = new MonoFlat.MonoFlat_Label();
            this.monoFlat_HeaderLabel1 = new MonoFlat.MonoFlat_HeaderLabel();
            this.monoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Button1 = new MonoFlat.MonoFlat_Button();
            this.monoFlat_Label3 = new MonoFlat.MonoFlat_Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(163, 303);
            this.listBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.monoFlat_Label2);
            this.panel1.Controls.Add(this.monoFlat_HeaderLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-15, -36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 99);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::osu_Manager_c.Properties.Resources.if_Rounded___High_Ultra_Colour15___Palette_2250037;
            this.pictureBox1.Location = new System.Drawing.Point(27, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(194, 132);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(212, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // monoFlat_Label2
            // 
            this.monoFlat_Label2.AutoSize = true;
            this.monoFlat_Label2.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.monoFlat_Label2.Location = new System.Drawing.Point(94, 77);
            this.monoFlat_Label2.Name = "monoFlat_Label2";
            this.monoFlat_Label2.Size = new System.Drawing.Size(120, 15);
            this.monoFlat_Label2.TabIndex = 4;
            this.monoFlat_Label2.Text = "hosted on enjuu.click";
            // 
            // monoFlat_HeaderLabel1
            // 
            this.monoFlat_HeaderLabel1.AutoSize = true;
            this.monoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.monoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.monoFlat_HeaderLabel1.Location = new System.Drawing.Point(93, 57);
            this.monoFlat_HeaderLabel1.Name = "monoFlat_HeaderLabel1";
            this.monoFlat_HeaderLabel1.Size = new System.Drawing.Size(177, 20);
            this.monoFlat_HeaderLabel1.TabIndex = 1;
            this.monoFlat_HeaderLabel1.Text = "Skin!Downloader - 1.1.3";
            // 
            // monoFlat_Label1
            // 
            this.monoFlat_Label1.AutoSize = true;
            this.monoFlat_Label1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.monoFlat_Label1.Location = new System.Drawing.Point(220, 114);
            this.monoFlat_Label1.Name = "monoFlat_Label1";
            this.monoFlat_Label1.Size = new System.Drawing.Size(160, 15);
            this.monoFlat_Label1.TabIndex = 2;
            this.monoFlat_Label1.Text = "Currently Nothing Download";
            // 
            // monoFlat_Button1
            // 
            this.monoFlat_Button1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button1.Image = null;
            this.monoFlat_Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button1.Location = new System.Drawing.Point(194, 69);
            this.monoFlat_Button1.Name = "monoFlat_Button1";
            this.monoFlat_Button1.Size = new System.Drawing.Size(212, 41);
            this.monoFlat_Button1.TabIndex = 1;
            this.monoFlat_Button1.Text = "Download and Install Skin";
            this.monoFlat_Button1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button1.Click += new System.EventHandler(this.monoFlat_Button1_Click);
            // 
            // monoFlat_Label3
            // 
            this.monoFlat_Label3.AutoSize = true;
            this.monoFlat_Label3.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.monoFlat_Label3.Location = new System.Drawing.Point(191, 158);
            this.monoFlat_Label3.Name = "monoFlat_Label3";
            this.monoFlat_Label3.Size = new System.Drawing.Size(106, 15);
            this.monoFlat_Label3.TabIndex = 6;
            this.monoFlat_Label3.Text = "Nothing in history.";
            // 
            // Skin_Downloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(447, 386);
            this.Controls.Add(this.monoFlat_Label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.monoFlat_Label1);
            this.Controls.Add(this.monoFlat_Button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Skin_Downloader";
            this.Text = "Skin_Downloader";
            this.Load += new System.EventHandler(this.Skin_Downloader_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MonoFlat.MonoFlat_Button monoFlat_Button1;
        private MonoFlat.MonoFlat_Label monoFlat_Label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private MonoFlat.MonoFlat_HeaderLabel monoFlat_HeaderLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MonoFlat.MonoFlat_Label monoFlat_Label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private MonoFlat.MonoFlat_Label monoFlat_Label3;
    }
}