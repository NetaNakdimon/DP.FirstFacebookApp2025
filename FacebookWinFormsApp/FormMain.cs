using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Drawing.Text;
using FBAppLog;


namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }


        private AppManagment m_AppManagment;


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            if (m_AppManagment.LoginResult == null)
            {
                m_AppManagment.Login();

                if (string.IsNullOrEmpty(m_AppManagment.LoginResult.ErrorMessage))
                {
                    buttonLogin.Text = $"Logged in as {m_AppManagment.LoginResult.LoggedInUser.Name}";
                    buttonLogin.BackColor = Color.LightGreen;
                    pictureBoxProfile.ImageLocation = m_AppManagment.LoginResult.LoggedInUser.PictureNormalURL;
                    buttonLogin.Enabled = false;
                    buttonLogout.Enabled = true;
                }
            }
        }

        //TODO- when logout remove the profile picture

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            m_AppManagment.Logout();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
            m_AppManagment.LoginResult = null;
        }

        private void linkAlbums_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisplaySelectedAlbums();
        }

        private void DisplaySelectedAlbums()
        {
            ListBoxAlbums.Items.Clear();
            ListBoxAlbums.DisplayMember = "Name";
            foreach (Album album in m_AppManagment.LoggedInUser.Albums)
            {
                ListBoxAlbums.Items.Add(album);
            }
        }

        private void ListBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayAlbumPicture();
        }

        //Todo- add a picture box to display the selected album picture
        private void displayAlbumPicture()
        {
            Album selectedAlbum = ListBoxAlbums.SelectedItem as Album;
            if (selectedAlbum.PictureAlbumURL != null)
            {
                pictureBoxAlbum.LoadAsync(selectedAlbum.PictureAlbumURL);
            }
            else
            {
                pictureBoxAlbum.Image = pictureBoxAlbum.ErrorImage;
            }
        }

        private void pictureBoxAlbum_Click(object sender, EventArgs e)
        {
            displayAlbumPicture();

        }


        private void FetchPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            displayPosts();
        }
        //Todo- add a list box to display the posts
        private void displayPosts()
        {
            listBoxPosts.Items.Clear();

            foreach (Post post in m_AppManagment.LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBoxPosts.Items.Add(post.Caption);
                }
                else
                {
                    listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                }
            }
            if (m_AppManagment.LoggedInUser.Posts.Count == 0)
            {
                listBoxPosts.Items.Add("No Posts to show");
            }

        }


        //Todo-checkwhatthisis
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void LinkLikes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchLikedPages();
        }

        private void fetchLikedPages()
        {
            ListBoxLikes.Items.Clear();
            ListBoxLikes.DisplayMember = "Name";
            foreach (Page page in m_AppManagment.LoggedInUser.LikedPages)
            {
                ListBoxLikes.Items.Add(page);
            }
            if (m_AppManagment.LoggedInUser.LikedPages.Count == 0)
            {
                ListBoxLikes.Items.Add("No Liked Pages to show");
            }
        }

        private void LinkEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            displayEvents();
        }

        private void displayEvents()
        {
            ListBoxEvents.Items.Clear();
            ListBoxEvents.DisplayMember = "Name";
            foreach (Event fbEvent in m_AppManagment.LoggedInUser.Events)
            {
                ListBoxEvents.Items.Add(fbEvent);
            }
            if (m_AppManagment.LoggedInUser.Events.Count == 0)
            {
                ListBoxEvents.Items.Add("No Events to show");
            }
        }

    
    }
}
