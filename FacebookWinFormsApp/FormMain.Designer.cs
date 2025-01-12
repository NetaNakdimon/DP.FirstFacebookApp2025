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
            this.buttonAlbumdetails = new System.Windows.Forms.Button();
            this.linklabelPhotosMemories = new System.Windows.Forms.LinkLabel();
            this.pictureBoxSlideshow = new System.Windows.Forms.PictureBox();
            this.comboBoxBGColor = new System.Windows.Forms.ComboBox();
            this.pictureBoxFriends = new System.Windows.Forms.PictureBox();
            this.linkNumOfFriends = new System.Windows.Forms.LinkLabel();
            this.labelNumOfFriends = new System.Windows.Forms.Label();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
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
            this.listBoxCloseFriends = new System.Windows.Forms.ListBox();
            this.buttonFindCloseFriends = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAverageDistanceToFriends = new System.Windows.Forms.Label();
            this.labelTopCity = new System.Windows.Forms.Label();
            this.listBoxFriendsByCity = new System.Windows.Forms.ListBox();
            this.labelCityStats = new System.Windows.Forms.Label();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonAddMassage = new System.Windows.Forms.Button();
            this.textBoxAddedMassage = new System.Windows.Forms.TextBox();
            this.comboBoxOptionalMsg = new System.Windows.Forms.ComboBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.labelSendMsg = new System.Windows.Forms.Label();
            this.buttonFetchBirthdays = new System.Windows.Forms.Button();
            this.pictureBoxBirthdays = new System.Windows.Forms.PictureBox();
            this.listBoxBirthdays = new System.Windows.Forms.ListBox();
            this.labelTodayIs = new System.Windows.Forms.Label();
            this.labelCloseFriend = new System.Windows.Forms.Label();
            this.tabControlOurFeatures.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlideshow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebook_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBirthdays)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(1015, 7);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(128, 45);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(1144, 7);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(87, 45);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // tabControlOurFeatures
            // 
            this.tabControlOurFeatures.Controls.Add(this.tabPage1);
            this.tabControlOurFeatures.Controls.Add(this.tabPage2);
            this.tabControlOurFeatures.Controls.Add(this.tabPage3);
            this.tabControlOurFeatures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlOurFeatures.Location = new System.Drawing.Point(0, 0);
            this.tabControlOurFeatures.Name = "tabControlOurFeatures";
            this.tabControlOurFeatures.SelectedIndex = 0;
            this.tabControlOurFeatures.Size = new System.Drawing.Size(1246, 780);
            this.tabControlOurFeatures.TabIndex = 54;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.Controls.Add(this.buttonAlbumdetails);
            this.tabPage1.Controls.Add(this.linklabelPhotosMemories);
            this.tabPage1.Controls.Add(this.pictureBoxSlideshow);
            this.tabPage1.Controls.Add(this.comboBoxBGColor);
            this.tabPage1.Controls.Add(this.pictureBoxFriends);
            this.tabPage1.Controls.Add(this.linkNumOfFriends);
            this.tabPage1.Controls.Add(this.labelNumOfFriends);
            this.tabPage1.Controls.Add(this.listBoxFriends);
            this.tabPage1.Controls.Add(this.labelCity);
            this.tabPage1.Controls.Add(this.labelBirthday);
            this.tabPage1.Controls.Add(this.labelEmail);
            this.tabPage1.Controls.Add(this.labelName);
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
            this.tabPage1.Size = new System.Drawing.Size(1238, 741);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Profile";
            // 
            // buttonAlbumdetails
            // 
            this.buttonAlbumdetails.Location = new System.Drawing.Point(325, 289);
            this.buttonAlbumdetails.Name = "buttonAlbumdetails";
            this.buttonAlbumdetails.Size = new System.Drawing.Size(182, 35);
            this.buttonAlbumdetails.TabIndex = 88;
            this.buttonAlbumdetails.Text = "Album details";
            this.buttonAlbumdetails.UseVisualStyleBackColor = true;
            this.buttonAlbumdetails.Click += new System.EventHandler(this.buttonAlbumdetails_Click);
            // 
            // linklabelPhotosMemories
            // 
            this.linklabelPhotosMemories.AutoSize = true;
            this.linklabelPhotosMemories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.linklabelPhotosMemories.Location = new System.Drawing.Point(8, 403);
            this.linklabelPhotosMemories.Name = "linklabelPhotosMemories";
            this.linklabelPhotosMemories.Size = new System.Drawing.Size(195, 32);
            this.linklabelPhotosMemories.TabIndex = 87;
            this.linklabelPhotosMemories.TabStop = true;
            this.linklabelPhotosMemories.Text = "Fetch Memories";
            this.linklabelPhotosMemories.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.pictureBoxPhotosMemories_LinkClicked);
            // 
            // pictureBoxSlideshow
            // 
            this.pictureBoxSlideshow.Location = new System.Drawing.Point(13, 447);
            this.pictureBoxSlideshow.Name = "pictureBoxSlideshow";
            this.pictureBoxSlideshow.Size = new System.Drawing.Size(113, 122);
            this.pictureBoxSlideshow.TabIndex = 85;
            this.pictureBoxSlideshow.TabStop = false;
            // 
            // comboBoxBGColor
            // 
            this.comboBoxBGColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.comboBoxBGColor.FormattingEnabled = true;
            this.comboBoxBGColor.Items.AddRange(new object[] {
            "Light Blue(default)",
            "Light Green",
            "Pink",
            "Yellow",
            "White"});
            this.comboBoxBGColor.Location = new System.Drawing.Point(1056, 59);
            this.comboBoxBGColor.Name = "comboBoxBGColor";
            this.comboBoxBGColor.Size = new System.Drawing.Size(174, 23);
            this.comboBoxBGColor.TabIndex = 84;
            this.comboBoxBGColor.Text = "Choose Background Color";
            this.comboBoxBGColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxBGColor_SelectedIndexChanged);
            // 
            // pictureBoxFriends
            // 
            this.pictureBoxFriends.Location = new System.Drawing.Point(209, 633);
            this.pictureBoxFriends.Name = "pictureBoxFriends";
            this.pictureBoxFriends.Size = new System.Drawing.Size(122, 100);
            this.pictureBoxFriends.TabIndex = 83;
            this.pictureBoxFriends.TabStop = false;
            // 
            // linkNumOfFriends
            // 
            this.linkNumOfFriends.AutoSize = true;
            this.linkNumOfFriends.Location = new System.Drawing.Point(204, 592);
            this.linkNumOfFriends.Name = "linkNumOfFriends";
            this.linkNumOfFriends.Size = new System.Drawing.Size(24, 26);
            this.linkNumOfFriends.TabIndex = 82;
            this.linkNumOfFriends.TabStop = true;
            this.linkNumOfFriends.Text = "0";
            this.linkNumOfFriends.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNumOfFriends_LinkClicked);
            // 
            // labelNumOfFriends
            // 
            this.labelNumOfFriends.AutoSize = true;
            this.labelNumOfFriends.Location = new System.Drawing.Point(3, 592);
            this.labelNumOfFriends.Name = "labelNumOfFriends";
            this.labelNumOfFriends.Size = new System.Drawing.Size(192, 26);
            this.labelNumOfFriends.TabIndex = 81;
            this.labelNumOfFriends.Text = "Number of friends-";
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 26;
            this.listBoxFriends.Location = new System.Drawing.Point(3, 633);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(192, 108);
            this.listBoxFriends.TabIndex = 80;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelCity.ForeColor = System.Drawing.Color.Green;
            this.labelCity.Location = new System.Drawing.Point(22, 394);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(0, 32);
            this.labelCity.TabIndex = 79;
            this.labelCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.ForeColor = System.Drawing.Color.Blue;
            this.labelBirthday.Location = new System.Drawing.Point(22, 359);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(0, 26);
            this.labelBirthday.TabIndex = 78;
            this.labelBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelEmail.ForeColor = System.Drawing.Color.Blue;
            this.labelEmail.Location = new System.Drawing.Point(22, 324);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(0, 38);
            this.labelEmail.TabIndex = 77;
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelName.ForeColor = System.Drawing.Color.Blue;
            this.labelName.Location = new System.Drawing.Point(22, 283);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 38);
            this.labelName.TabIndex = 76;
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.listBoxPostComments.Location = new System.Drawing.Point(285, 173);
            this.listBoxPostComments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxPostComments.Name = "listBoxPostComments";
            this.listBoxPostComments.Size = new System.Drawing.Size(771, 62);
            this.listBoxPostComments.TabIndex = 71;
            // 
            // FetchPosts
            // 
            this.FetchPosts.AutoSize = true;
            this.FetchPosts.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.FetchPosts.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.FetchPosts.Location = new System.Drawing.Point(285, 21);
            this.FetchPosts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FetchPosts.Name = "FetchPosts";
            this.FetchPosts.Size = new System.Drawing.Size(751, 115);
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
            this.listBoxPosts.Location = new System.Drawing.Point(285, 82);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(771, 91);
            this.listBoxPosts.TabIndex = 69;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // pictureBoxEvents
            // 
            this.pictureBoxEvents.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxEvents.Location = new System.Drawing.Point(1144, 626);
            this.pictureBoxEvents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxEvents.Name = "pictureBoxEvents";
            this.pictureBoxEvents.Size = new System.Drawing.Size(80, 82);
            this.pictureBoxEvents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEvents.TabIndex = 68;
            this.pictureBoxEvents.TabStop = false;
            // 
            // pictureBoxGroups
            // 
            this.pictureBoxGroups.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxGroups.Location = new System.Drawing.Point(1144, 492);
            this.pictureBoxGroups.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxGroups.Name = "pictureBoxGroups";
            this.pictureBoxGroups.Size = new System.Drawing.Size(80, 82);
            this.pictureBoxGroups.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGroups.TabIndex = 67;
            this.pictureBoxGroups.TabStop = false;
            // 
            // pictureBoxLikes
            // 
            this.pictureBoxLikes.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxLikes.Location = new System.Drawing.Point(1144, 379);
            this.pictureBoxLikes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxLikes.Name = "pictureBoxLikes";
            this.pictureBoxLikes.Size = new System.Drawing.Size(80, 82);
            this.pictureBoxLikes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLikes.TabIndex = 66;
            this.pictureBoxLikes.TabStop = false;
            // 
            // pictureBoxAlbum
            // 
            this.pictureBoxAlbum.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxAlbum.Location = new System.Drawing.Point(1144, 268);
            this.pictureBoxAlbum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxAlbum.Name = "pictureBoxAlbum";
            this.pictureBoxAlbum.Size = new System.Drawing.Size(80, 82);
            this.pictureBoxAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbum.TabIndex = 65;
            this.pictureBoxAlbum.TabStop = false;
            // 
            // LinkGroups
            // 
            this.LinkGroups.AutoSize = true;
            this.LinkGroups.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LinkGroups.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.LinkGroups.Location = new System.Drawing.Point(523, 464);
            this.LinkGroups.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkGroups.Name = "LinkGroups";
            this.LinkGroups.Size = new System.Drawing.Size(161, 38);
            this.LinkGroups.TabIndex = 64;
            this.LinkGroups.TabStop = true;
            this.LinkGroups.Text = "Fetch Groups";
            this.LinkGroups.UseCompatibleTextRendering = true;
            this.LinkGroups.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkGroups_LinkClicked);
            // 
            // LinkEvents
            // 
            this.LinkEvents.AutoSize = true;
            this.LinkEvents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LinkEvents.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.LinkEvents.Location = new System.Drawing.Point(523, 592);
            this.LinkEvents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkEvents.Name = "LinkEvents";
            this.LinkEvents.Size = new System.Drawing.Size(153, 38);
            this.LinkEvents.TabIndex = 63;
            this.LinkEvents.TabStop = true;
            this.LinkEvents.Text = "Fetch Events";
            this.LinkEvents.UseCompatibleTextRendering = true;
            this.LinkEvents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkEvents_LinkClicked);
            // 
            // LinkLikes
            // 
            this.LinkLikes.AutoSize = true;
            this.LinkLikes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LinkLikes.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.LinkLikes.Location = new System.Drawing.Point(523, 353);
            this.LinkLikes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkLikes.Name = "LinkLikes";
            this.LinkLikes.Size = new System.Drawing.Size(135, 38);
            this.LinkLikes.TabIndex = 62;
            this.LinkLikes.TabStop = true;
            this.LinkLikes.Text = "Fetch Likes";
            this.LinkLikes.UseCompatibleTextRendering = true;
            this.LinkLikes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLikes_LinkClicked);
            // 
            // LinkAlbums
            // 
            this.LinkAlbums.AutoSize = true;
            this.LinkAlbums.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LinkAlbums.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.LinkAlbums.Location = new System.Drawing.Point(523, 237);
            this.LinkAlbums.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkAlbums.Name = "LinkAlbums";
            this.LinkAlbums.Size = new System.Drawing.Size(166, 38);
            this.LinkAlbums.TabIndex = 61;
            this.LinkAlbums.TabStop = true;
            this.LinkAlbums.Text = "Fetch Albums";
            this.LinkAlbums.UseCompatibleTextRendering = true;
            this.LinkAlbums.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAlbums_LinkClicked);
            // 
            // ListBoxGroups
            // 
            this.ListBoxGroups.FormattingEnabled = true;
            this.ListBoxGroups.ItemHeight = 26;
            this.ListBoxGroups.Location = new System.Drawing.Point(523, 492);
            this.ListBoxGroups.Name = "ListBoxGroups";
            this.ListBoxGroups.Size = new System.Drawing.Size(591, 82);
            this.ListBoxGroups.TabIndex = 60;
            this.ListBoxGroups.SelectedIndexChanged += new System.EventHandler(this.ListBoxGroups_SelectedIndexChanged);
            // 
            // ListBoxEvents
            // 
            this.ListBoxEvents.FormattingEnabled = true;
            this.ListBoxEvents.ItemHeight = 26;
            this.ListBoxEvents.Location = new System.Drawing.Point(523, 626);
            this.ListBoxEvents.Name = "ListBoxEvents";
            this.ListBoxEvents.Size = new System.Drawing.Size(591, 82);
            this.ListBoxEvents.TabIndex = 59;
            this.ListBoxEvents.SelectedIndexChanged += new System.EventHandler(this.ListBoxEvents_SelectedIndexChanged);
            // 
            // ListBoxLikes
            // 
            this.ListBoxLikes.FormattingEnabled = true;
            this.ListBoxLikes.ItemHeight = 26;
            this.ListBoxLikes.Location = new System.Drawing.Point(523, 379);
            this.ListBoxLikes.Name = "ListBoxLikes";
            this.ListBoxLikes.Size = new System.Drawing.Size(591, 82);
            this.ListBoxLikes.TabIndex = 58;
            this.ListBoxLikes.SelectedIndexChanged += new System.EventHandler(this.ListBoxLikes_SelectedIndexChanged);
            // 
            // ListBoxAlbums
            // 
            this.ListBoxAlbums.FormattingEnabled = true;
            this.ListBoxAlbums.ItemHeight = 26;
            this.ListBoxAlbums.Location = new System.Drawing.Point(523, 268);
            this.ListBoxAlbums.Name = "ListBoxAlbums";
            this.ListBoxAlbums.Size = new System.Drawing.Size(591, 82);
            this.ListBoxAlbums.TabIndex = 57;
            this.ListBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.ListBoxAlbums_SelectedIndexChanged);
            // 
            // facebook_logo
            // 
            this.facebook_logo.Image = ((System.Drawing.Image)(resources.GetObject("facebook_logo.Image")));
            this.facebook_logo.Location = new System.Drawing.Point(-86, -13);
            this.facebook_logo.Name = "facebook_logo";
            this.facebook_logo.Size = new System.Drawing.Size(226, 155);
            this.facebook_logo.TabIndex = 56;
            this.facebook_logo.TabStop = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(8, 157);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(112, 111);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage2.Controls.Add(this.listBoxCloseFriends);
            this.tabPage2.Controls.Add(this.buttonFindCloseFriends);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.labelAverageDistanceToFriends);
            this.tabPage2.Controls.Add(this.labelTopCity);
            this.tabPage2.Controls.Add(this.listBoxFriendsByCity);
            this.tabPage2.Controls.Add(this.labelCityStats);
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
            this.tabPage2.Size = new System.Drawing.Size(1238, 741);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "FriendsStatistics";
            // 
            // listBoxCloseFriends
            // 
            this.listBoxCloseFriends.FormattingEnabled = true;
            this.listBoxCloseFriends.ItemHeight = 26;
            this.listBoxCloseFriends.Location = new System.Drawing.Point(682, 599);
            this.listBoxCloseFriends.Name = "listBoxCloseFriends";
            this.listBoxCloseFriends.Size = new System.Drawing.Size(454, 134);
            this.listBoxCloseFriends.TabIndex = 21;
            // 
            // buttonFindCloseFriends
            // 
            this.buttonFindCloseFriends.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonFindCloseFriends.Location = new System.Drawing.Point(805, 503);
            this.buttonFindCloseFriends.Name = "buttonFindCloseFriends";
            this.buttonFindCloseFriends.Size = new System.Drawing.Size(210, 67);
            this.buttonFindCloseFriends.TabIndex = 20;
            this.buttonFindCloseFriends.Text = "Find Close Friends";
            this.buttonFindCloseFriends.UseVisualStyleBackColor = true;
            this.buttonFindCloseFriends.Click += new System.EventHandler(this.buttonFindCloseFriends_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(730, 557);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 26);
            this.label2.TabIndex = 19;
            // 
            // labelAverageDistanceToFriends
            // 
            this.labelAverageDistanceToFriends.AutoSize = true;
            this.labelAverageDistanceToFriends.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelAverageDistanceToFriends.Location = new System.Drawing.Point(730, 448);
            this.labelAverageDistanceToFriends.Name = "labelAverageDistanceToFriends";
            this.labelAverageDistanceToFriends.Size = new System.Drawing.Size(343, 32);
            this.labelAverageDistanceToFriends.TabIndex = 18;
            this.labelAverageDistanceToFriends.Text = "Average Distance To Friends:";
            // 
            // labelTopCity
            // 
            this.labelTopCity.AutoSize = true;
            this.labelTopCity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelTopCity.Location = new System.Drawing.Point(730, 399);
            this.labelTopCity.Name = "labelTopCity";
            this.labelTopCity.Size = new System.Drawing.Size(275, 32);
            this.labelTopCity.TabIndex = 16;
            this.labelTopCity.Text = "Top City: Not Available";
            // 
            // listBoxFriendsByCity
            // 
            this.listBoxFriendsByCity.ItemHeight = 26;
            this.listBoxFriendsByCity.Location = new System.Drawing.Point(0, 0);
            this.listBoxFriendsByCity.Name = "listBoxFriendsByCity";
            this.listBoxFriendsByCity.Size = new System.Drawing.Size(120, 82);
            this.listBoxFriendsByCity.TabIndex = 17;
            // 
            // labelCityStats
            // 
            this.labelCityStats.AutoSize = true;
            this.labelCityStats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelCityStats.Location = new System.Drawing.Point(726, 100);
            this.labelCityStats.Name = "labelCityStats";
            this.labelCityStats.Size = new System.Drawing.Size(190, 32);
            this.labelCityStats.TabIndex = 15;
            this.labelCityStats.Text = "Friends by City:";
            // 
            // pictureBoxCloseFriend
            // 
            this.pictureBoxCloseFriend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCloseFriend.Location = new System.Drawing.Point(1050, 251);
            this.pictureBoxCloseFriend.Name = "pictureBoxCloseFriend";
            this.pictureBoxCloseFriend.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxCloseFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCloseFriend.TabIndex = 13;
            this.pictureBoxCloseFriend.TabStop = false;
            // 
            // FetchCityStats
            // 
            this.FetchCityStats.AutoSize = true;
            this.FetchCityStats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.FetchCityStats.Location = new System.Drawing.Point(730, 50);
            this.FetchCityStats.Name = "FetchCityStats";
            this.FetchCityStats.Size = new System.Drawing.Size(276, 32);
            this.FetchCityStats.TabIndex = 12;
            this.FetchCityStats.TabStop = true;
            this.FetchCityStats.Text = "Fetch Friends City Stats";
            this.FetchCityStats.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FetchCityStats_LinkClicked_1);
            // 
            // ListBoxFriendsCityStats
            // 
            this.ListBoxFriendsCityStats.FormattingEnabled = true;
            this.ListBoxFriendsCityStats.ItemHeight = 26;
            this.ListBoxFriendsCityStats.Location = new System.Drawing.Point(730, 133);
            this.ListBoxFriendsCityStats.Name = "ListBoxFriendsCityStats";
            this.ListBoxFriendsCityStats.Size = new System.Drawing.Size(395, 238);
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
            this.buttonCalculateStats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
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
            this.labelAvgAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelAvgAge.Location = new System.Drawing.Point(3, 421);
            this.labelAvgAge.Name = "labelAvgAge";
            this.labelAvgAge.Size = new System.Drawing.Size(162, 32);
            this.labelAvgAge.TabIndex = 4;
            this.labelAvgAge.Text = "Average age:";
            // 
            // labelGenderCount
            // 
            this.labelGenderCount.AutoSize = true;
            this.labelGenderCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelGenderCount.Location = new System.Drawing.Point(6, 362);
            this.labelGenderCount.Name = "labelGenderCount";
            this.labelGenderCount.Size = new System.Drawing.Size(114, 32);
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
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(201, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Gender Stats";
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.Controls.Add(this.buttonAddMassage);
            this.tabPage3.Controls.Add(this.textBoxAddedMassage);
            this.tabPage3.Controls.Add(this.comboBoxOptionalMsg);
            this.tabPage3.Controls.Add(this.buttonPost);
            this.tabPage3.Controls.Add(this.labelSendMsg);
            this.tabPage3.Controls.Add(this.buttonFetchBirthdays);
            this.tabPage3.Controls.Add(this.pictureBoxBirthdays);
            this.tabPage3.Controls.Add(this.listBoxBirthdays);
            this.tabPage3.Controls.Add(this.labelTodayIs);
            this.tabPage3.Location = new System.Drawing.Point(4, 35);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1238, 741);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Birthdays";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonAddMassage
            // 
            this.buttonAddMassage.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonAddMassage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonAddMassage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAddMassage.Location = new System.Drawing.Point(1019, 544);
            this.buttonAddMassage.Name = "buttonAddMassage";
            this.buttonAddMassage.Size = new System.Drawing.Size(179, 107);
            this.buttonAddMassage.TabIndex = 8;
            this.buttonAddMassage.Text = "Post your message!";
            this.buttonAddMassage.UseVisualStyleBackColor = false;
            this.buttonAddMassage.Click += new System.EventHandler(this.buttonAddMassage_Click);
            // 
            // textBoxAddedMassage
            // 
            this.textBoxAddedMassage.Location = new System.Drawing.Point(92, 547);
            this.textBoxAddedMassage.Multiline = true;
            this.textBoxAddedMassage.Name = "textBoxAddedMassage";
            this.textBoxAddedMassage.Size = new System.Drawing.Size(921, 104);
            this.textBoxAddedMassage.TabIndex = 7;
            this.textBoxAddedMassage.Text = "Write here your costumized massage";
            // 
            // comboBoxOptionalMsg
            // 
            this.comboBoxOptionalMsg.FormattingEnabled = true;
            this.comboBoxOptionalMsg.Items.AddRange(new object[] {
            "🎉 Happy Birthday! Wishing you endless joy, love, and laughter today and always! " +
                "🎂",
            "🎈",
            "",
            "🎁 May your special day be as amazing as you are! Cheers to another fabulous year" +
                "! 🥳",
            "✨",
            "",
            "🌟 Happy Birthday! Here’s to a year full of adventures, dreams come true, and hap" +
                "piness! 🎉🎂",
            "",
            "",
            "🎈 Wishing you a day filled with cake, smiles, and all your favorite things! 🥳",
            "🍰",
            "",
            "🥂 Happy Birthday! Let’s celebrate you and all the amazing moments ahead! 🎁🎊"});
            this.comboBoxOptionalMsg.Location = new System.Drawing.Point(92, 504);
            this.comboBoxOptionalMsg.Name = "comboBoxOptionalMsg";
            this.comboBoxOptionalMsg.Size = new System.Drawing.Size(977, 34);
            this.comboBoxOptionalMsg.TabIndex = 6;
            this.comboBoxOptionalMsg.Text = "Choose your massage";
            // 
            // buttonPost
            // 
            this.buttonPost.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonPost.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonPost.Location = new System.Drawing.Point(1075, 504);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(123, 34);
            this.buttonPost.TabIndex = 5;
            this.buttonPost.Text = "Post!";
            this.buttonPost.UseVisualStyleBackColor = false;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // labelSendMsg
            // 
            this.labelSendMsg.AutoSize = true;
            this.labelSendMsg.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelSendMsg.Location = new System.Drawing.Point(399, 456);
            this.labelSendMsg.Name = "labelSendMsg";
            this.labelSendMsg.Size = new System.Drawing.Size(424, 45);
            this.labelSendMsg.TabIndex = 4;
            this.labelSendMsg.Text = "Let\'s send them a message!";
            // 
            // buttonFetchBirthdays
            // 
            this.buttonFetchBirthdays.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonFetchBirthdays.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonFetchBirthdays.Location = new System.Drawing.Point(527, 195);
            this.buttonFetchBirthdays.Name = "buttonFetchBirthdays";
            this.buttonFetchBirthdays.Size = new System.Drawing.Size(211, 48);
            this.buttonFetchBirthdays.TabIndex = 3;
            this.buttonFetchBirthdays.Text = "Show me!";
            this.buttonFetchBirthdays.UseVisualStyleBackColor = false;
            this.buttonFetchBirthdays.Click += new System.EventHandler(this.buttonFetchBirthdays_Click);
            // 
            // pictureBoxBirthdays
            // 
            this.pictureBoxBirthdays.Location = new System.Drawing.Point(661, 249);
            this.pictureBoxBirthdays.Name = "pictureBoxBirthdays";
            this.pictureBoxBirthdays.Size = new System.Drawing.Size(192, 186);
            this.pictureBoxBirthdays.TabIndex = 2;
            this.pictureBoxBirthdays.TabStop = false;
            // 
            // listBoxBirthdays
            // 
            this.listBoxBirthdays.FormattingEnabled = true;
            this.listBoxBirthdays.ItemHeight = 26;
            this.listBoxBirthdays.Location = new System.Drawing.Point(309, 249);
            this.listBoxBirthdays.Name = "listBoxBirthdays";
            this.listBoxBirthdays.Size = new System.Drawing.Size(356, 186);
            this.listBoxBirthdays.TabIndex = 1;
            this.listBoxBirthdays.SelectedIndexChanged += new System.EventHandler(this.listBoxBirthdays_SelectedIndexChanged);
            // 
            // labelTodayIs
            // 
            this.labelTodayIs.AutoSize = true;
            this.labelTodayIs.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelTodayIs.Location = new System.Drawing.Point(329, 41);
            this.labelTodayIs.Name = "labelTodayIs";
            this.labelTodayIs.Size = new System.Drawing.Size(695, 54);
            this.labelTodayIs.TabIndex = 0;
            this.labelTodayIs.Text = "Wish Your Friends Happy Birthday!!";
            // 
            // labelCloseFriend
            // 
            this.labelCloseFriend.AutoSize = true;
            this.labelCloseFriend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelCloseFriend.Location = new System.Drawing.Point(1050, 170);
            this.labelCloseFriend.Name = "labelCloseFriend";
            this.labelCloseFriend.Size = new System.Drawing.Size(140, 26);
            this.labelCloseFriend.TabIndex = 14;
            this.labelCloseFriend.Text = "Close Friend Image";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(87)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(1246, 780);
            this.Controls.Add(this.tabControlOurFeatures);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControlOurFeatures.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlideshow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebook_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBirthdays)).EndInit();
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
        private System.Windows.Forms.Label labelNumOfFriends;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.LinkLabel linkNumOfFriends;
        private System.Windows.Forms.PictureBox pictureBoxFriends;
        private System.Windows.Forms.Label labelCityStats;
        private System.Windows.Forms.ComboBox comboBoxBGColor;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelTodayIs;
        private System.Windows.Forms.ListBox listBoxBirthdays;
        private System.Windows.Forms.PictureBox pictureBoxBirthdays;
        private System.Windows.Forms.Button buttonFetchBirthdays;
        private System.Windows.Forms.Label labelSendMsg;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.ComboBox comboBoxOptionalMsg;
        private System.Windows.Forms.Button buttonAddMassage;
        private System.Windows.Forms.TextBox textBoxAddedMassage;
        private System.Windows.Forms.PictureBox pictureBoxSlideshow;
        private System.Windows.Forms.LinkLabel linklabelPhotosMemories;
        private System.Windows.Forms.Label labelCloseFriend;
        private System.Windows.Forms.Label labelTopCity;
        private System.Windows.Forms.ListBox listBoxFriendsByCity;
        private System.Windows.Forms.Label labelAverageDistanceToFriends;
        private System.Windows.Forms.ListBox listBoxCloseFriends;
        private System.Windows.Forms.Button buttonFindCloseFriends;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAlbumdetails;
    }
}

