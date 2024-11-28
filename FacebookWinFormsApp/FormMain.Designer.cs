using System.Drawing;

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
            this.tabControlOurFeatures = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelUserName = new System.Windows.Forms.Label();
            this.listBoxPostComments = new System.Windows.Forms.ListBox();
            this.FetchPosts = new System.Windows.Forms.LinkLabel();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.pictureBoxEvents = new System.Windows.Forms.PictureBox();
            this.pictureBoxGroups = new System.Windows.Forms.PictureBox();
            this.pictureBoxLikes = new System.Windows.Forms.PictureBox();
            this.pictureBoxAlbum = new System.Windows.Forms.PictureBox();
            this.LinkGroups = new System.Windows.Forms.LinkLabel();
            this.LinkEvents = new System.Windows.Forms.LinkLabel();
            this.LinkLikes = new System.Windows.Forms.LinkLabel();
            this.LinkAlbums = new System.Windows.Forms.LinkLabel();
            this.ListBoxGroups = new System.Windows.Forms.ListBox();
            this.ListBoxEvents = new System.Windows.Forms.ListBox();
            this.ListBoxLikes = new System.Windows.Forms.ListBox();
            this.ListBoxAlbums = new System.Windows.Forms.ListBox();
            this.facebook_logo = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBoxCloseFriend = new System.Windows.Forms.PictureBox();
            this.FetchCityStats = new System.Windows.Forms.LinkLabel();
            this.ListBoxFriendsCityStats = new System.Windows.Forms.ListBox();
            this.labelAvgFemales = new System.Windows.Forms.Label();
            this.labelAvgMales = new System.Windows.Forms.Label();
            this.labelFemaleCounter = new System.Windows.Forms.Label();
            this.labelMaleCounter = new System.Windows.Forms.Label();
            this.buttonCalculateStats = new System.Windows.Forms.Button();
            this.labelAvgAge = new System.Windows.Forms.Label();
            this.labelGenderCount = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlOurFeatures.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebook_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(147, 14);
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
            this.buttonLogout.Location = new System.Drawing.Point(147, 62);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(205, 45);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // tabControlOurFeatures
            // 
            this.tabControlOurFeatures.Controls.Add(this.tabPage1);
            this.tabControlOurFeatures.Controls.Add(this.tabPage2);
            this.tabControlOurFeatures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlOurFeatures.Location = new System.Drawing.Point(0, 0);
            this.tabControlOurFeatures.Name = "tabControlOurFeatures";
            this.tabControlOurFeatures.SelectedIndex = 0;
            this.tabControlOurFeatures.Size = new System.Drawing.Size(1246, 743);
            this.tabControlOurFeatures.TabIndex = 54;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelUserName);
            this.tabPage1.Controls.Add(this.listBoxPostComments);
            this.tabPage1.Controls.Add(this.FetchPosts);
            this.tabPage1.Controls.Add(this.listBoxPosts);
            this.tabPage1.Controls.Add(this.pictureBoxEvents);
            this.tabPage1.Controls.Add(this.pictureBoxGroups);
            this.tabPage1.Controls.Add(this.pictureBoxLikes);
            this.tabPage1.Controls.Add(this.pictureBoxAlbum);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1238, 704);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(1237, 157);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(0, 26);
            this.labelUserName.TabIndex = 75;
            // 
            // listBoxPostComments
            // 
            this.listBoxPostComments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPostComments.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxPostComments.DisplayMember = "name";
            this.listBoxPostComments.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPostComments.FormattingEnabled = true;
            this.listBoxPostComments.ItemHeight = 29;
            this.listBoxPostComments.Location = new System.Drawing.Point(802, 147);
            this.listBoxPostComments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxPostComments.Name = "listBoxPostComments";
            this.listBoxPostComments.Size = new System.Drawing.Size(239, 62);
            this.listBoxPostComments.TabIndex = 71;
            // 
            // FetchPosts
            // 
            this.FetchPosts.AutoSize = true;
            this.FetchPosts.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.FetchPosts.Location = new System.Drawing.Point(538, 23);
            this.FetchPosts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FetchPosts.Name = "FetchPosts";
            this.FetchPosts.Size = new System.Drawing.Size(387, 56);
            this.FetchPosts.TabIndex = 70;
            this.FetchPosts.TabStop = true;
            this.FetchPosts.Text = "Fetch Posts\r\n(Click on a post to view its comments)";
            this.FetchPosts.UseCompatibleTextRendering = true;
            this.FetchPosts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FetchPosts_LinkClicked);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPosts.DisplayMember = "name";
            this.listBoxPosts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 29;
            this.listBoxPosts.Location = new System.Drawing.Point(472, 74);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(508, 91);
            this.listBoxPosts.TabIndex = 69;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // pictureBoxEvents
            // 
            this.pictureBoxEvents.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxEvents.Location = new System.Drawing.Point(305, 587);
            this.pictureBoxEvents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxEvents.Name = "pictureBoxEvents";
            this.pictureBoxEvents.Size = new System.Drawing.Size(97, 97);
            this.pictureBoxEvents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEvents.TabIndex = 68;
            this.pictureBoxEvents.TabStop = false;
            // 
            // pictureBoxGroups
            // 
            this.pictureBoxGroups.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxGroups.Location = new System.Drawing.Point(730, 587);
            this.pictureBoxGroups.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxGroups.Name = "pictureBoxGroups";
            this.pictureBoxGroups.Size = new System.Drawing.Size(93, 97);
            this.pictureBoxGroups.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGroups.TabIndex = 67;
            this.pictureBoxGroups.TabStop = false;
            // 
            // pictureBoxLikes
            // 
            this.pictureBoxLikes.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxLikes.Location = new System.Drawing.Point(730, 333);
            this.pictureBoxLikes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxLikes.Name = "pictureBoxLikes";
            this.pictureBoxLikes.Size = new System.Drawing.Size(93, 92);
            this.pictureBoxLikes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLikes.TabIndex = 66;
            this.pictureBoxLikes.TabStop = false;
            // 
            // pictureBoxAlbum
            // 
            this.pictureBoxAlbum.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxAlbum.Location = new System.Drawing.Point(305, 333);
            this.pictureBoxAlbum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxAlbum.Name = "pictureBoxAlbum";
            this.pictureBoxAlbum.Size = new System.Drawing.Size(97, 92);
            this.pictureBoxAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbum.TabIndex = 65;
            this.pictureBoxAlbum.TabStop = false;
            // 
            // LinkGroups
            // 
            this.LinkGroups.AutoSize = true;
            this.LinkGroups.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.LinkGroups.Location = new System.Drawing.Point(436, 430);
            this.LinkGroups.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkGroups.Name = "LinkGroups";
            this.LinkGroups.Size = new System.Drawing.Size(365, 56);
            this.LinkGroups.TabIndex = 64;
            this.LinkGroups.TabStop = true;
            this.LinkGroups.Text = "Fetch Groups \r\n(Click on a group to view its picture)";
            this.LinkGroups.UseCompatibleTextRendering = true;
            this.LinkGroups.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkGroups_LinkClicked);
            // 
            // LinkEvents
            // 
            this.LinkEvents.AutoSize = true;
            this.LinkEvents.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.LinkEvents.Location = new System.Drawing.Point(9, 430);
            this.LinkEvents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkEvents.Name = "LinkEvents";
            this.LinkEvents.Size = new System.Drawing.Size(437, 56);
            this.LinkEvents.TabIndex = 63;
            this.LinkEvents.TabStop = true;
            this.LinkEvents.Text = "Fetch Events\r\n(Click on an event to view its cover picture)";
            this.LinkEvents.UseCompatibleTextRendering = true;
            this.LinkEvents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkEvents_LinkClicked);
            // 
            // LinkLikes
            // 
            this.LinkLikes.AutoSize = true;
            this.LinkLikes.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.LinkLikes.Location = new System.Drawing.Point(436, 185);
            this.LinkLikes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkLikes.Name = "LinkLikes";
            this.LinkLikes.Size = new System.Drawing.Size(358, 56);
            this.LinkLikes.TabIndex = 62;
            this.LinkLikes.TabStop = true;
            this.LinkLikes.Text = "Fetch Likes\r\n(Click on a page to view its picture)";
            this.LinkLikes.UseCompatibleTextRendering = true;
            this.LinkLikes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLikes_LinkClicked);
            // 
            // LinkAlbums
            // 
            this.LinkAlbums.AutoSize = true;
            this.LinkAlbums.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.LinkAlbums.Location = new System.Drawing.Point(21, 185);
            this.LinkAlbums.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkAlbums.Name = "LinkAlbums";
            this.LinkAlbums.Size = new System.Drawing.Size(412, 56);
            this.LinkAlbums.TabIndex = 61;
            this.LinkAlbums.TabStop = true;
            this.LinkAlbums.Text = "Fetch Albums\r\n(Click an album to view its cover picture)";
            this.LinkAlbums.UseCompatibleTextRendering = true;
            this.LinkAlbums.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAlbums_LinkClicked);
            // 
            // ListBoxGroups
            // 
            this.ListBoxGroups.FormattingEnabled = true;
            this.ListBoxGroups.ItemHeight = 26;
            this.ListBoxGroups.Location = new System.Drawing.Point(436, 489);
            this.ListBoxGroups.Name = "ListBoxGroups";
            this.ListBoxGroups.Size = new System.Drawing.Size(356, 186);
            this.ListBoxGroups.TabIndex = 60;
            this.ListBoxGroups.SelectedIndexChanged += new System.EventHandler(this.ListBoxGroups_SelectedIndexChanged);
            // 
            // ListBoxEvents
            // 
            this.ListBoxEvents.FormattingEnabled = true;
            this.ListBoxEvents.ItemHeight = 26;
            this.ListBoxEvents.Location = new System.Drawing.Point(21, 480);
            this.ListBoxEvents.Name = "ListBoxEvents";
            this.ListBoxEvents.Size = new System.Drawing.Size(326, 186);
            this.ListBoxEvents.TabIndex = 59;
            this.ListBoxEvents.SelectedIndexChanged += new System.EventHandler(this.ListBoxEvents_SelectedIndexChanged);
            // 
            // ListBoxLikes
            // 
            this.ListBoxLikes.FormattingEnabled = true;
            this.ListBoxLikes.ItemHeight = 26;
            this.ListBoxLikes.Location = new System.Drawing.Point(436, 253);
            this.ListBoxLikes.Name = "ListBoxLikes";
            this.ListBoxLikes.Size = new System.Drawing.Size(356, 160);
            this.ListBoxLikes.TabIndex = 58;
            this.ListBoxLikes.SelectedIndexChanged += new System.EventHandler(this.ListBoxLikes_SelectedIndexChanged);
            // 
            // ListBoxAlbums
            // 
            this.ListBoxAlbums.FormattingEnabled = true;
            this.ListBoxAlbums.ItemHeight = 26;
            this.ListBoxAlbums.Location = new System.Drawing.Point(21, 253);
            this.ListBoxAlbums.Name = "ListBoxAlbums";
            this.ListBoxAlbums.Size = new System.Drawing.Size(326, 160);
            this.ListBoxAlbums.TabIndex = 57;
            this.ListBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.ListBoxAlbums_SelectedIndexChanged);
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
            this.pictureBoxProfile.Location = new System.Drawing.Point(1079, 6);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(153, 141);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.pictureBoxCloseFriend);
            this.tabPage2.Controls.Add(this.FetchCityStats);
            this.tabPage2.Controls.Add(this.ListBoxFriendsCityStats);
            this.tabPage2.Controls.Add(this.labelAvgFemales);
            this.tabPage2.Controls.Add(this.labelAvgMales);
            this.tabPage2.Controls.Add(this.labelFemaleCounter);
            this.tabPage2.Controls.Add(this.labelMaleCounter);
            this.tabPage2.Controls.Add(this.buttonCalculateStats);
            this.tabPage2.Controls.Add(this.labelAvgAge);
            this.tabPage2.Controls.Add(this.labelGenderCount);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1238, 704);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(775, 466);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(408, 191);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(738, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(345, 32);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "Find friends who live next to me";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBoxCloseFriend
            // 
            this.pictureBoxCloseFriend.Location = new System.Drawing.Point(1025, 365);
            this.pictureBoxCloseFriend.Name = "pictureBoxCloseFriend";
            this.pictureBoxCloseFriend.Size = new System.Drawing.Size(96, 81);
            this.pictureBoxCloseFriend.TabIndex = 13;
            this.pictureBoxCloseFriend.TabStop = false;
            // 
            // FetchCityStats
            // 
            this.FetchCityStats.AutoSize = true;
            this.FetchCityStats.Location = new System.Drawing.Point(733, 87);
            this.FetchCityStats.Name = "FetchCityStats";
            this.FetchCityStats.Size = new System.Drawing.Size(244, 26);
            this.FetchCityStats.TabIndex = 12;
            this.FetchCityStats.TabStop = true;
            this.FetchCityStats.Text = "Fetch Friends City Stats";
            this.FetchCityStats.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FetchCityStats_LinkClicked);
            // 
            // ListBoxFriendsCityStats
            // 
            this.ListBoxFriendsCityStats.FormattingEnabled = true;
            this.ListBoxFriendsCityStats.ItemHeight = 26;
            this.ListBoxFriendsCityStats.Location = new System.Drawing.Point(726, 133);
            this.ListBoxFriendsCityStats.Name = "ListBoxFriendsCityStats";
            this.ListBoxFriendsCityStats.Size = new System.Drawing.Size(395, 316);
            this.ListBoxFriendsCityStats.TabIndex = 11;
            this.ListBoxFriendsCityStats.SelectedIndexChanged += new System.EventHandler(this.ListBoxFriendsCityStats_SelectedIndexChanged);
            // 
            // labelAvgFemales
            // 
            this.labelAvgFemales.AutoSize = true;
            this.labelAvgFemales.Location = new System.Drawing.Point(342, 423);
            this.labelAvgFemales.Name = "labelAvgFemales";
            this.labelAvgFemales.Size = new System.Drawing.Size(0, 26);
            this.labelAvgFemales.TabIndex = 10;
            // 
            // labelAvgMales
            // 
            this.labelAvgMales.AutoSize = true;
            this.labelAvgMales.Location = new System.Drawing.Point(189, 421);
            this.labelAvgMales.Name = "labelAvgMales";
            this.labelAvgMales.Size = new System.Drawing.Size(0, 26);
            this.labelAvgMales.TabIndex = 9;
            // 
            // labelFemaleCounter
            // 
            this.labelFemaleCounter.AutoSize = true;
            this.labelFemaleCounter.Location = new System.Drawing.Point(342, 364);
            this.labelFemaleCounter.Name = "labelFemaleCounter";
            this.labelFemaleCounter.Size = new System.Drawing.Size(0, 26);
            this.labelFemaleCounter.TabIndex = 8;
            // 
            // labelMaleCounter
            // 
            this.labelMaleCounter.AutoSize = true;
            this.labelMaleCounter.Location = new System.Drawing.Point(189, 364);
            this.labelMaleCounter.Name = "labelMaleCounter";
            this.labelMaleCounter.Size = new System.Drawing.Size(0, 26);
            this.labelMaleCounter.TabIndex = 7;
            // 
            // buttonCalculateStats
            // 
            this.buttonCalculateStats.Location = new System.Drawing.Point(206, 484);
            this.buttonCalculateStats.Name = "buttonCalculateStats";
            this.buttonCalculateStats.Size = new System.Drawing.Size(151, 36);
            this.buttonCalculateStats.TabIndex = 6;
            this.buttonCalculateStats.Text = "Calculate";
            this.buttonCalculateStats.UseVisualStyleBackColor = true;
            this.buttonCalculateStats.Click += new System.EventHandler(this.buttonCalculateStats_Click);
            // 
            // labelAvgAge
            // 
            this.labelAvgAge.AutoSize = true;
            this.labelAvgAge.Location = new System.Drawing.Point(3, 421);
            this.labelAvgAge.Name = "labelAvgAge";
            this.labelAvgAge.Size = new System.Drawing.Size(141, 26);
            this.labelAvgAge.TabIndex = 4;
            this.labelAvgAge.Text = "Average age:";
            // 
            // labelGenderCount
            // 
            this.labelGenderCount.AutoSize = true;
            this.labelGenderCount.Location = new System.Drawing.Point(6, 362);
            this.labelGenderCount.Name = "labelGenderCount";
            this.labelGenderCount.Size = new System.Drawing.Size(95, 26);
            this.labelGenderCount.TabIndex = 3;
            this.labelGenderCount.Text = "Counter:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(266, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 226);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(97, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 227);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Gender Stats";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(87)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(1246, 743);
            this.Controls.Add(this.tabControlOurFeatures);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControlOurFeatures.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebook_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.TabControl tabControlOurFeatures;
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
        private System.Windows.Forms.PictureBox pictureBoxAlbum;
        private System.Windows.Forms.ListBox listBoxPostComments;
        private System.Windows.Forms.LinkLabel FetchPosts;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.PictureBox pictureBoxEvents;
        private System.Windows.Forms.PictureBox pictureBoxGroups;
        private System.Windows.Forms.PictureBox pictureBoxLikes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelAvgAge;
        private System.Windows.Forms.Label labelGenderCount;
        private System.Windows.Forms.Label labelAvgFemales;
        private System.Windows.Forms.Label labelAvgMales;
        private System.Windows.Forms.Label labelFemaleCounter;
        private System.Windows.Forms.Label labelMaleCounter;
        private System.Windows.Forms.Button buttonCalculateStats;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.PictureBox pictureBoxCloseFriend;
        private System.Windows.Forms.LinkLabel FetchCityStats;
        private System.Windows.Forms.ListBox ListBoxFriendsCityStats;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

