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
using FBLogic;



namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            m_AppManagment = AppManagment.Instance;
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


        private void buttonLogout_Click(object sender, EventArgs e)
        {
            m_AppManagment.Logout();
            EraseWhenLogOut();


        }

        private void EraseWhenLogOut()
        {
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
            m_AppManagment.LoginResult = null;
            m_AppManagment.LoggedInUser = null;
            pictureBoxProfile.Image = null;
            listBoxPosts.Items.Clear();
            listBoxPostComments.Items.Clear();
            ListBoxAlbums.Items.Clear();
            ListBoxLikes.Items.Clear();
            ListBoxEvents.Items.Clear();
            ListBoxGroups.Items.Clear();
            pictureBoxAlbum.Image = null;
            pictureBoxEvents.Image = null;
            pictureBoxGroups.Image = null;
            pictureBoxLikes.Image = null;
            labelMaleCounter.Text = "";
            labelFemaleCounter.Text = "";
            labelAvgMales.Text = "";
            labelAvgFemales.Text = "";
        }
        //Album methods:
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
            if (m_AppManagment.LoggedInUser.Albums.Count == 0)
            {
                listBoxPosts.Items.Add("No albums to show");
            }
        }

        private void ListBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayAlbumPicture();
        }

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

        //posts methods:

        private void FetchPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisplayPosts();
        }

        private void DisplayPosts()
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

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayPostComments();
        }

        private void DisplayPostComments()
        {
            listBoxPostComments.Items.Clear();
            Post selectedPost = m_AppManagment.LoggedInUser.Posts[listBoxPosts.SelectedIndex];
            foreach (Comment comment in selectedPost.Comments)
            {
                listBoxPostComments.Items.Add(comment.Message);
            }
            if (selectedPost.Comments.Count == 0)
            {
                listBoxPostComments.Items.Add("No Comments to show");
            }
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

        private void ListBoxLikes_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayLikedPagePicture();
        }

        private void DisplayLikedPagePicture()
        {
            Page selectedPage = ListBoxLikes.SelectedItem as Page;
            if (selectedPage.PictureNormalURL != null)
            {
                pictureBoxLikes.LoadAsync(selectedPage.PictureNormalURL);
            }
            else
            {
                pictureBoxLikes.Image = pictureBoxLikes.ErrorImage;
            }
        }

        private void LinkEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisplayEvents();
        }
        //todo- check why not working
        private void DisplayEvents()
        {
            ListBoxEvents.Items.Clear();
            ListBoxEvents.DisplayMember = "Name";

            foreach (Event fbEvent in m_AppManagment.LoggedInUser.Events)
            {
                if (fbEvent.Name != null)
                {
                    ListBoxEvents.Items.Add(fbEvent.Name);
                }
                else
                {
                    ListBoxEvents.Items.Add("No Name");
                }


            }
            if (m_AppManagment.LoggedInUser.Events.Count == 0)
            {

                ListBoxEvents.Items.Add("No Events to show");
            }
        }

        private void ListBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayEventPicture();
        }

        private void DisplayEventPicture()
        {
            Event selectedEvent = ListBoxEvents.SelectedItem as Event;
            if (selectedEvent.PictureNormalURL != null)
            {
                pictureBoxEvents.LoadAsync(selectedEvent.PictureNormalURL);
            }
            else
            {
                pictureBoxEvents.Image = pictureBoxEvents.ErrorImage;
            }
        }

        private void LinkGroups_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchUsersGroups();
        }
        //todo- check why not working
        private void fetchUsersGroups()
        {
            ListBoxGroups.Items.Clear();
            ListBoxGroups.DisplayMember = "Name";
            foreach (Group group in m_AppManagment.LoggedInUser.Groups)
            {
                ListBoxGroups.Items.Add(group);
            }
            if (m_AppManagment.LoggedInUser.Groups.Count == 0)
            {
                ListBoxGroups.Items.Add("No Groups to show");
            }
        }
        private void ListBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayGroupPicture();
        }
        //todo- try-catch
        private void DisplayGroupPicture()
        {
            Group selectedGroup = ListBoxGroups.SelectedItem as Group;
            if (selectedGroup.PictureNormalURL != null)
            {
                pictureBoxGroups.LoadAsync(selectedGroup.PictureNormalURL);
            }
            else
            {
                pictureBoxGroups.Image = pictureBoxGroups.ErrorImage;
            }
        }


        private void ListBoxFriendsBirthdays_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxFriendsBirthdays.Items.Clear();

            if (m_AppManagment.LoggedInUser != null)
            {
                ListBoxFriendsBirthdays.DisplayMember = "Text";

                foreach (User friend in m_AppManagment.LoggedInUser.Friends)
                {
                    // string birthdayInfo = friend.Name + " - " + friend.Birthday.ToString("MMM dd");
                    // ListBoxFriendsBirthdays.Items.Add(birthdayInfo);
                }

                if (m_AppManagment.LoggedInUser.Friends.Count == 0)
                {
                    ListBoxFriendsBirthdays.Items.Add("No friends with birthdays to show.");
                }
            }
            else
            {
                ListBoxFriendsBirthdays.Items.Add("No user is logged in. Please log in first.");
            }
        }

        private void buttonCalculateStats_Click(object sender, EventArgs e)
        {
           
            GenderStatsCalculator genderStats = new GenderStatsCalculator(m_AppManagment);
            try
            {
                genderStats.CalculateGenderStats();
            }
            catch (Exception InvalidOperationException)
            {
                return;
            }
            DisplayGenderStats(genderStats);
        }

        private void DisplayGenderStats(GenderStatsCalculator genderStats)
        {
            labelMaleCounter.Text= genderStats.Males.ToString();
            labelFemaleCounter.Text = genderStats.Female.ToString();
            labelAvgMales.Text = genderStats.MaleAgeAvg().ToString();
            labelAvgFemales.Text = genderStats.FemaleAgeAvg().ToString();

        }
    }
}

