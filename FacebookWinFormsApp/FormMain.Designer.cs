namespace BasicFacebookFeatures
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.facebook_logo = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ListBoxAlbums = new System.Windows.Forms.ListBox();
            this.ListBoxLikes = new System.Windows.Forms.ListBox();
            this.ListBoxEvents = new System.Windows.Forms.ListBox();
            this.ListBoxGroups = new System.Windows.Forms.ListBox();
            this.LinkAlbums = new System.Windows.Forms.LinkLabel();
            this.LinkLikes = new System.Windows.Forms.LinkLabel();
            this.LinkEvents = new System.Windows.Forms.LinkLabel();
            this.LinkGroups = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebook_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(808, 7);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(205, 45);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(1017, 7);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(214, 45);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1284, 701);
            this.tabControl1.TabIndex = 54;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LinkGroups);
            this.tabPage1.Controls.Add(this.LinkEvents);
            this.tabPage1.Controls.Add(this.LinkLikes);
            this.tabPage1.Controls.Add(this.LinkAlbums);
            this.tabPage1.Controls.Add(this.ListBoxGroups);
            this.tabPage1.Controls.Add(this.ListBoxEvents);
            this.tabPage1.Controls.Add(this.ListBoxLikes);
            this.tabPage1.Controls.Add(this.ListBoxAlbums);
            this.tabPage1.Controls.Add(this.facebook_logo);
            this.tabPage1.Controls.Add(this.pictureBoxProfile);
            this.tabPage1.Controls.Add(this.buttonLogout);
            this.tabPage1.Controls.Add(this.buttonLogin);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1276, 670);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // facebook_logo
            // 
            this.facebook_logo.Image = ((System.Drawing.Image)(resources.GetObject("facebook_logo.Image")));
            this.facebook_logo.Location = new System.Drawing.Point(-86, -11);
            this.facebook_logo.Name = "facebook_logo";
            this.facebook_logo.Size = new System.Drawing.Size(226, 155);
            this.facebook_logo.TabIndex = 56;
            this.facebook_logo.TabStop = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(1127, 59);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(100, 96);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1235, 666);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ListBoxAlbums
            // 
            this.ListBoxAlbums.FormattingEnabled = true;
            this.ListBoxAlbums.ItemHeight = 18;
            this.ListBoxAlbums.Location = new System.Drawing.Point(30, 209);
            this.ListBoxAlbums.Name = "ListBoxAlbums";
            this.ListBoxAlbums.Size = new System.Drawing.Size(120, 94);
            this.ListBoxAlbums.TabIndex = 57;
            // 
            // ListBoxLikes
            // 
            this.ListBoxLikes.FormattingEnabled = true;
            this.ListBoxLikes.ItemHeight = 18;
            this.ListBoxLikes.Location = new System.Drawing.Point(423, 209);
            this.ListBoxLikes.Name = "ListBoxLikes";
            this.ListBoxLikes.Size = new System.Drawing.Size(125, 94);
            this.ListBoxLikes.TabIndex = 58;
            // 
            // ListBoxEvents
            // 
            this.ListBoxEvents.FormattingEnabled = true;
            this.ListBoxEvents.ItemHeight = 18;
            this.ListBoxEvents.Location = new System.Drawing.Point(30, 396);
            this.ListBoxEvents.Name = "ListBoxEvents";
            this.ListBoxEvents.Size = new System.Drawing.Size(135, 94);
            this.ListBoxEvents.TabIndex = 59;
            // 
            // ListBoxGroups
            // 
            this.ListBoxGroups.FormattingEnabled = true;
            this.ListBoxGroups.ItemHeight = 18;
            this.ListBoxGroups.Location = new System.Drawing.Point(423, 396);
            this.ListBoxGroups.Name = "ListBoxGroups";
            this.ListBoxGroups.Size = new System.Drawing.Size(135, 94);
            this.ListBoxGroups.TabIndex = 60;
            // 
            // LinkAlbums
            // 
            this.LinkAlbums.AutoSize = true;
            this.LinkAlbums.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.LinkAlbums.Location = new System.Drawing.Point(9, 158);
            this.LinkAlbums.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkAlbums.Name = "LinkAlbums";
            this.LinkAlbums.Size = new System.Drawing.Size(275, 39);
            this.LinkAlbums.TabIndex = 61;
            this.LinkAlbums.TabStop = true;
            this.LinkAlbums.Text = "Fetch Albums\r\n(Click an album to view its cover picture)";
            this.LinkAlbums.UseCompatibleTextRendering = true;
            this.LinkAlbums.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAlbums_LinkClicked);
            // 
            // LinkLikes
            // 
            this.LinkLikes.AutoSize = true;
            this.LinkLikes.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.LinkLikes.Location = new System.Drawing.Point(423, 158);
            this.LinkLikes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkLikes.Name = "LinkLikes";
            this.LinkLikes.Size = new System.Drawing.Size(239, 39);
            this.LinkLikes.TabIndex = 62;
            this.LinkLikes.TabStop = true;
            this.LinkLikes.Text = "Fetch Likes\r\n(Click on a page to view its picture)";
            this.LinkLikes.UseCompatibleTextRendering = true;
            // 
            // LinkEvents
            // 
            this.LinkEvents.AutoSize = true;
            this.LinkEvents.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.LinkEvents.Location = new System.Drawing.Point(9, 343);
            this.LinkEvents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkEvents.Name = "LinkEvents";
            this.LinkEvents.Size = new System.Drawing.Size(291, 39);
            this.LinkEvents.TabIndex = 63;
            this.LinkEvents.TabStop = true;
            this.LinkEvents.Text = "Fetch Events\r\n(Click on an event to view its cover picture)";
            this.LinkEvents.UseCompatibleTextRendering = true;
            // 
            // LinkGroups
            // 
            this.LinkGroups.AutoSize = true;
            this.LinkGroups.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.LinkGroups.Location = new System.Drawing.Point(423, 343);
            this.LinkGroups.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkGroups.Name = "LinkGroups";
            this.LinkGroups.Size = new System.Drawing.Size(244, 39);
            this.LinkGroups.TabIndex = 64;
            this.LinkGroups.TabStop = true;
            this.LinkGroups.Text = "Fetch Groups \r\n(Click on a group to view its picture)";
            this.LinkGroups.UseCompatibleTextRendering = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 701);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebook_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.PictureBox facebook_logo;
        private System.Windows.Forms.LinkLabel LinkAlbums;
        private System.Windows.Forms.ListBox ListBoxGroups;
        private System.Windows.Forms.ListBox ListBoxEvents;
        private System.Windows.Forms.ListBox ListBoxLikes;
        private System.Windows.Forms.ListBox ListBoxAlbums;
        private System.Windows.Forms.LinkLabel LinkLikes;
        private System.Windows.Forms.LinkLabel LinkGroups;
        private System.Windows.Forms.LinkLabel LinkEvents;
    }
}

