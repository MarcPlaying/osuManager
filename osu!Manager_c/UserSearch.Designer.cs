namespace osu_Manager_c
{
    partial class UserSearch
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.monoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Button1 = new MonoFlat.MonoFlat_Button();
            this.monoFlat_TextBox1 = new MonoFlat.MonoFlat_TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.monoFlat_Label1);
            this.panel1.Location = new System.Drawing.Point(-15, -41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 97);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            this.panel1.Move += new System.EventHandler(this.panel1_Move);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::osu_Manager_c.Properties.Resources.if_exit_enter_leave_door_in_2931189;
            this.pictureBox2.Location = new System.Drawing.Point(518, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // monoFlat_Label1
            // 
            this.monoFlat_Label1.AutoSize = true;
            this.monoFlat_Label1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoFlat_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.monoFlat_Label1.Location = new System.Drawing.Point(216, 50);
            this.monoFlat_Label1.Name = "monoFlat_Label1";
            this.monoFlat_Label1.Size = new System.Drawing.Size(135, 30);
            this.monoFlat_Label1.TabIndex = 0;
            this.monoFlat_Label1.Text = "UserExplorer!";
            // 
            // monoFlat_Button1
            // 
            this.monoFlat_Button1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button1.Image = null;
            this.monoFlat_Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button1.Location = new System.Drawing.Point(197, 109);
            this.monoFlat_Button1.Name = "monoFlat_Button1";
            this.monoFlat_Button1.Size = new System.Drawing.Size(146, 41);
            this.monoFlat_Button1.TabIndex = 2;
            this.monoFlat_Button1.Text = "Open Profile";
            this.monoFlat_Button1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.monoFlat_Button1.Click += new System.EventHandler(this.monoFlat_Button1_Click);
            // 
            // monoFlat_TextBox1
            // 
            this.monoFlat_TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_TextBox1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.monoFlat_TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.monoFlat_TextBox1.Image = null;
            this.monoFlat_TextBox1.Location = new System.Drawing.Point(12, 62);
            this.monoFlat_TextBox1.MaxLength = 32767;
            this.monoFlat_TextBox1.Multiline = false;
            this.monoFlat_TextBox1.Name = "monoFlat_TextBox1";
            this.monoFlat_TextBox1.ReadOnly = false;
            this.monoFlat_TextBox1.Size = new System.Drawing.Size(538, 41);
            this.monoFlat_TextBox1.TabIndex = 1;
            this.monoFlat_TextBox1.Text = "UserName";
            this.monoFlat_TextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.monoFlat_TextBox1.UseSystemPasswordChar = false;
            // 
            // UserSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(562, 191);
            this.Controls.Add(this.monoFlat_Button1);
            this.Controls.Add(this.monoFlat_TextBox1);
            this.Controls.Add(this.panel1);
            this.Name = "UserSearch";
            this.Text = "UserSearch";
            this.Load += new System.EventHandler(this.UserSearch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MonoFlat.MonoFlat_Label monoFlat_Label1;
        private MonoFlat.MonoFlat_TextBox monoFlat_TextBox1;
        private MonoFlat.MonoFlat_Button monoFlat_Button1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}