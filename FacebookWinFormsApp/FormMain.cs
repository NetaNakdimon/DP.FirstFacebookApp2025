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
using System.Media;
using FBLogic;
using System.Diagnostics.Eventing.Reader;
using System.Deployment.Application;



namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public FormMain(AppManagment i_appManagment)
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            m_AppManagment = i_appManagment;
            displayUserInfoWhenLogin();
        }


        private AppManagment m_AppManagment;
        private GenderStatsCalculator m_genderStats;


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");
            if (m_AppManagment.LoginResult == null)
            {
                m_AppManagment.Login();
                displayUserInfoWhenLogin();
            }

        }

        private void displayUserInfoWhenLogin()
        {
            if (string.IsNullOrEmpty(m_AppManagment.LoginResult.ErrorMessage))
            {
                buttonLogin.Text = $"Logged in as {m_AppManagment.LoginResult.LoggedInUser.Name}";
                buttonLogin.BackColor = Color.LightGreen;
                buttonLogout.BackColor = Color.Red;
                pictureBoxProfile.ImageLocation = m_AppManagment.LoginResult.LoggedInUser.PictureNormalURL;
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;
                displayUserInfo();
            }
        }

        private void displayUserInfo()
        {
            labelUserName.Text = m_AppManagment.LoginResult.LoggedInUser.Name;
            labelBirthday.Text = m_AppManagment.LoggedInUser.Birthday;
            labelCity.Text = m_AppManagment.LoggedInUser.Hometown?.Name;
            labelEmail.Text = m_AppManagment.LoggedInUser.Email;
            linkNumOfFriends.Text = m_AppManagment.LoggedInUser.Friends.Count.ToString() + " (click to see them)";

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            m_AppManagment.Logout();
            eraseWhenLogOut();

        }

        private void eraseWhenLogOut()
        {
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonCalculateStats.BackColor;
            buttonLogout.BackColor = buttonCalculateStats.BackColor;
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
            listBoxFriends.Items.Clear();
            ListBoxFriendsCityStats.Items.Clear();
            pictureBoxCloseFriend.Image = null;
            pictureBoxFriends.Image = null;
            pictureBoxAlbum.Image = null;
            pictureBoxEvents.Image = null;
            pictureBoxGroups.Image = null;
            pictureBoxLikes.Image = null;
            labelMaleCounter.Text = "";
            labelFemaleCounter.Text = "";
            labelAvgMales.Text = "";
            labelAvgFemales.Text = "";
            labelUserName.Text = "";
            labelBirthday.Text = "";
            labelCity.Text = "";
            labelEmail.Text = "";
            labelUserName.Text = "";
            linkNumOfFriends.Text = "0";
        }
        //Album methods:
        private void linkAlbums_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (m_AppManagment.LoggedInUser != null)
            {
                displaySelectedAlbums();
            }
            else
            {
                MessageBox.Show("Please log in for this option");
                return;
            }

        }

        private void displaySelectedAlbums()
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
            if (m_AppManagment.LoggedInUser != null)
            {
                DisplayPosts();
            }
            else
            {
                MessageBox.Show("Please log in for this option");
                return;
            }
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
            displayPostComments();
        }


        private void displayPostComments()
        {
            listBoxPostComments.Items.Clear();

            if (listBoxPosts.SelectedIndex < 0 || listBoxPosts.SelectedIndex >= m_AppManagment.LoggedInUser.Posts.Count)
            {
                listBoxPostComments.Items.Add("No post selected");
                return;
            }

            Post selectedPost = m_AppManagment.LoggedInUser.Posts[listBoxPosts.SelectedIndex];

            if (selectedPost.Comments.Count > 0)
            {
                foreach (Comment comment in selectedPost.Comments)
                {
                    listBoxPostComments.Items.Add(comment.Message);
                }
            }
            else
            {
                listBoxPostComments.Items.Add("No Comments to show");
            }
        }


        private void LinkLikes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (m_AppManagment.LoginResult != null)
            {
                fetchLikedPages();
            }
            else
            {
                MessageBox.Show("Please log in for this option");
                return;
            }


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
            displayLikedPagePicture();
        }

        private void displayLikedPagePicture()
        {
            Page selectedPage = ListBoxLikes.SelectedItem as Page;

            if (selectedPage == null || string.IsNullOrEmpty(selectedPage.PictureNormalURL))
            {
                pictureBoxLikes.Image = pictureBoxLikes.ErrorImage;
                return;
            }

            try
            {
                pictureBoxLikes.LoadAsync(selectedPage.PictureNormalURL);
            }
            catch
            {
                pictureBoxLikes.Image = pictureBoxLikes.ErrorImage;
            }
        }

        private void LinkEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (m_AppManagment.LoggedInUser != null)
            {
                displayEvents();
            }

            else
            {
                MessageBox.Show("Please log in for this option");
                return;
            }


        }
        private void displayEvents()
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
            displayPicture(pictureBoxEvents, ListBoxEvents);
        }


        private void LinkGroups_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (m_AppManagment.LoggedInUser != null)
            {
                fetchUsersGroups();
            }

            else
            {
                MessageBox.Show("Please log in for this option");
                return;
            }

        }

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
            displayPicture(pictureBoxGroups, ListBoxGroups);
        }


        private void buttonCalculateStats_Click(object sender, EventArgs e)
        {

            m_genderStats = new GenderStatsCalculator(m_AppManagment);
            try
            {
                m_genderStats.CalculateGenderStats();
            }
            catch (Exception)
            {
                return;
            }
            displayGenderStats(m_genderStats);
        }

        private void displayGenderStats(GenderStatsCalculator i_genderStats)
        {
            labelMaleCounter.Text = i_genderStats.Males.ToString();
            labelFemaleCounter.Text = i_genderStats.Female.ToString();
            labelAvgMales.Text = i_genderStats.MaleAgeAvg().ToString();
            labelAvgFemales.Text = i_genderStats.FemaleAgeAvg().ToString();

        }

        private void fetchCityStats_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchFriendsCityStats();
        }

        private void fetchFriendsCityStats()
        {
            if (m_AppManagment.LoggedInUser == null)
            {
                MessageBox.Show("Please log in to fetch city statistics.");
                return;
            }

            ListBoxFriendsCityStats.Items.Clear();
            ListBoxFriendsCityStats.DisplayMember = "Name";
            Dictionary<string, int> cityStatistics = DistanceCalculator.GetCityStatistics(m_AppManagment.LoggedInUser.Friends.ToList());

            if (cityStatistics.Count == 0)
            {
                ListBoxFriendsCityStats.Items.Add("No city statistics to display.");
            }

            else
            {
                foreach (KeyValuePair<string, int> cityStat in cityStatistics)
                {
                    ListBoxFriendsCityStats.Items.Add($"{cityStat.Key}: {cityStat.Value} friends");
                }
            }
        }

        private void ListBoxFriendsCityStats_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayPicture(pictureBoxCloseFriend, ListBoxFriendsCityStats);
        }

        private void linkNumOfFriends_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (m_AppManagment.LoggedInUser != null)
            {
                displayFriends();
            }
            else
            {
                MessageBox.Show("Please log in for this option");
                return;
            }
        }

        private void displayFriends()
        {
            listBoxFriends.Items.Clear();
            listBoxFriends.DisplayMember = "Name";


            foreach (User friend in m_AppManagment.LoggedInUser.Friends)
            {
                listBoxFriends.Items.Add(friend);

            }
            if (m_AppManagment.LoggedInUser.Friends.Count == 0)
            {
                listBoxFriends.Items.Add("No Friends to show");
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayPicture(pictureBoxFriends, listBoxFriends);
        }

        private void displayPicture(PictureBox i_pictureBox, ListBox i_listBox)
        {
            OwnerObject selectedObject = i_listBox.SelectedItem as OwnerObject;
            if (selectedObject == null || selectedObject.PictureNormalURL == null)
            {
                i_pictureBox.Image = pictureBoxEvents.ErrorImage;
            }
            else
            {
                i_pictureBox.LoadAsync(selectedObject.PictureNormalURL);

            }
        }

        private void comboBoxBGColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxBGColor.SelectedIndex)
            {

                case 0:
                    this.tabPage1.BackColor = Color.LightBlue;
                    this.tabPage2.BackColor = Color.LightBlue;
                    break;
                case 1:
                    this.tabPage1.BackColor = Color.LightGreen;
                    this.tabPage2.BackColor = Color.LightGreen;
                    break;
                case 2:
                    this.tabPage1.BackColor = Color.LightPink;
                    this.tabPage2.BackColor = Color.LightPink;
                    break;
                case 3:
                    this.tabPage1.BackColor = Color.LightYellow;
                    this.tabPage2.BackColor = Color.LightYellow;
                    break;
                case 4:
                    this.tabPage1.BackColor = Color.White;
                    this.tabPage2.BackColor = Color.White;
                    break;
                default:
                    this.tabPage1.BackColor = Color.LightBlue;
                    this.tabPage2.BackColor = Color.LightBlue;
                    break;
            }

        }

        private void buttonFetchBirthdays_Click(object sender, EventArgs e)
        {
            fetchAndDisplayBirthdays();
        }
        List<User> m_friendsWithBirthdays;
        private void fetchAndDisplayBirthdays()
        {
            if (m_AppManagment.LoggedInUser == null)
            {
                MessageBox.Show("Please log in to fetch birthdays.");
                return;
            }
            listBoxBirthdays.Items.Clear();
            BirthdayManager birthdayManager = new BirthdayManager(m_AppManagment.LoggedInUser);
            m_friendsWithBirthdays = birthdayManager.GetTodayBirthdays();

            if (m_friendsWithBirthdays.Count == 0)
            {
                listBoxBirthdays.Items.Add("No friends have birthdays today. :(");
                return;
            }

            foreach (User friend in m_friendsWithBirthdays)
            {
                listBoxBirthdays.Items.Add(friend.Name); 
            }
        }
        private void listBoxBirthdays_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayPicture(pictureBoxBirthdays, listBoxBirthdays);
        }

        //TODO- FIX THE SONG PLAYING BY FINDING THE RIGHT PATH
        private void PlayHappyBirthdaySong(object sender, EventArgs e)
        {
            try
            {

                string soundFilePath = "..\\sounds\\happybirthday.wav";


                using (SoundPlayer player = new SoundPlayer(soundFilePath))
                {
                    player.Play();
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }
        private void buttonPost_Click(object sender, EventArgs e)
        {
            try 
            { 
                sendBirthdayMessage(getThisFriend(listBoxBirthdays.SelectedIndex), comboBoxOptionalMsg.Text);
            }
            catch (Exception ex)
            {
                return;
            }
        }
        private void buttonAddMassage_Click(object sender, EventArgs e)
        {
            try
            {
                sendBirthdayMessage(getThisFriend(listBoxBirthdays.SelectedIndex), textBoxAddedMassage.Text);
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private User getThisFriend(int i_Index)
        {
            if (m_friendsWithBirthdays.Count == 0)
            {
                return null;
            }
            return m_friendsWithBirthdays[i_Index];
        }
        
        private void sendBirthdayMessage(User i_Friend, string i_Message)
        {
            if (i_Message.Length == 0 || i_Message== "Write here your costumized massage")
            {
                MessageBox.Show("Please enter a massage");
            }
            
            try
            {
                if (m_friendsWithBirthdays.Count == 0)
                {
                    MessageBox.Show("No Friend selected");
                    return;
                }
                BirthdayManager birthdayManager = new BirthdayManager(m_AppManagment.LoggedInUser);

                if (birthdayManager.SendBirthdayMessage(i_Friend, i_Message))
                {
                    MessageBox.Show($"Successfully sent a birthday message to {i_Friend.Name}!");
                }
                else
                {
                    MessageBox.Show($"Failed to send a birthday message to {i_Friend.Name}.");
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

       
    }
}

