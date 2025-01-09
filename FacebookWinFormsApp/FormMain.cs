﻿using System;
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
using FBAppLogic;
using System.Threading;
using System.Timers;
using System.Diagnostics.Eventing.Reader;
using System.Deployment.Application;


namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            displayUserInfoWhenLogin();
        }
        
        
        private List<Photo> cachedPhotos = new List<Photo>();
        private Random random = new Random();
        List<User> m_friendsWithBirthdays;
        BirthdayManager m_birthdayManager;

        // Login methods
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");
            if (AppManagment.Instance.LoginResult == null)
            {
                new Thread(() => AppManagment.Instance.Login()).Start();
                displayUserInfoWhenLogin();
            }

        }

        private void displayUserInfoWhenLogin()
        {
            if (string.IsNullOrEmpty(AppManagment.Instance.LoginResult.ErrorMessage))
            {
                buttonLogin.Text = $"Logged in as {AppManagment.Instance.LoginResult.LoggedInUser.Name}";
                buttonLogin.BackColor = Color.LightGreen;
                buttonLogout.BackColor = Color.Red;
                pictureBoxProfile.ImageLocation = AppManagment.Instance.LoginResult.LoggedInUser.PictureNormalURL;
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;
                displayUserInfo();
            }
        }

        private void displayUserInfo()
        {
            labelUserName.Text = AppManagment.Instance.LoginResult.LoggedInUser.Name;
            labelBirthday.Text = AppManagment.Instance.LoggedInUser.Birthday;
            labelCity.Text = AppManagment.Instance.LoggedInUser.Hometown?.Name;
            labelEmail.Text = AppManagment.Instance.LoggedInUser.Email;
            linkNumOfFriends.Text = AppManagment.Instance.LoggedInUser.Friends.Count.ToString() + " (click to see them)";

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            AppManagment.Instance.Logout();
            eraseWhenLogOut();

        }

        private void eraseWhenLogOut()
        {
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonCalculateStats.BackColor;
            buttonLogout.BackColor = buttonCalculateStats.BackColor;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
            AppManagment.Instance.LoginResult = null;
            AppManagment.Instance.LoggedInUser = null;
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

        // Album methods
        private void linkAlbums_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (AppManagment.Instance.LoggedInUser != null)
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
            ListBoxAlbums.Invoke(new Action(() => ListBoxAlbums.DisplayMember = "Name"));
            foreach (Album album in AppManagment.Instance.LoggedInUser.Albums)
            {
                ListBoxAlbums.Invoke(new Action(() => ListBoxAlbums.Items.Add(album)));
            }

            if (AppManagment.Instance.LoggedInUser.Albums.Count == 0)
            {
                ListBoxAlbums.Invoke(new Action(() => ListBoxAlbums.Items.Add("no albums to show")));
            }
        }

        private void ListBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            new Thread(displayAlbumPicture).Start();
        }

        private void displayAlbumPicture()
        {
            Album selectedAlbum = ListBoxAlbums.SelectedItem as Album;
            if (selectedAlbum.PictureAlbumURL != null)
            {
                pictureBoxAlbum.Invoke(new Action(() => pictureBoxAlbum.LoadAsync(selectedAlbum.PictureAlbumURL)));
            }

            else
            {
                //how to invoke this
                pictureBoxAlbum.Image = pictureBoxAlbum.ErrorImage;
            }
        }

        // Posts methods
        private void FetchPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (AppManagment.Instance.LoggedInUser != null)
            {
                new Thread(displayPosts).Start();
            }
            else
            {
                MessageBox.Show("Please log in for this option");
                return;
            }
        }

        private void displayPosts()
        {
            listBoxPosts.Items.Clear();


            foreach (Post post in AppManagment.Instance.LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Message)));
                }

                else if (post.Caption != null)
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Caption)));
                }

                else
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(string.Format("[{0}]", post.Type))));
                }
            }

            if (AppManagment.Instance.LoggedInUser.Posts.Count == 0)
            {
                listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add("no posts to show")));
            }


        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            new Thread(displayPostComments).Start();
        }


        private void displayPostComments()
        {
            listBoxPostComments.Items.Clear();

            if (listBoxPosts.SelectedIndex < 0 || listBoxPosts.SelectedIndex >= AppManagment.Instance.LoggedInUser.Posts.Count)
            {

                listBoxPostComments.Invoke(new Action(() => listBoxPostComments.Items.Add("No post selected")));
                return;
            }

            Post selectedPost = AppManagment.Instance.LoggedInUser.Posts[listBoxPosts.SelectedIndex];

            if (selectedPost.Comments.Count > 0)
            {
                foreach (Comment comment in selectedPost.Comments)
                {

                    listBoxPostComments.Invoke(new Action(() => listBoxPostComments.Items.Add(comment.Message)));
                }
            }
            else
            {
                listBoxPostComments.Invoke(new Action(() => listBoxPosts.Items.Add("No Comments to show comments to show")));
            }
        }

        // Likes methods
        private void LinkLikes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (AppManagment.Instance.LoginResult != null)
            {
                new Thread(fetchLikedPages).Start();
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
            ListBoxLikes.Invoke(new Action(() => ListBoxLikes.DisplayMember = "Name"));
            foreach (Page page in AppManagment.Instance.LoggedInUser.LikedPages)
            {
                ListBoxLikes.Invoke(new Action(() => ListBoxLikes.Items.Add(page)));
            }

            if (AppManagment.Instance.LoggedInUser.LikedPages.Count == 0)
            {
                ListBoxLikes.Invoke(new Action(() => ListBoxLikes.Items.Add("No liked pages to show")));
            }
        }

        private void ListBoxLikes_SelectedIndexChanged(object sender, EventArgs e)
        {
            new Thread(displayLikedPagePicture).Start();
        }

        private void displayLikedPagePicture()
        {
            Page selectedPage = ListBoxLikes.SelectedItem as Page;

            if (selectedPage == null || string.IsNullOrEmpty(selectedPage.PictureNormalURL))
            {
                //how to invoke this
                pictureBoxLikes.Image = pictureBoxLikes.ErrorImage;
                return;
            }

            try
            {
                pictureBoxLikes.Invoke(new Action(() => pictureBoxLikes.LoadAsync(selectedPage.PictureNormalURL)));
            }
            catch
            {
                //invoke
                pictureBoxLikes.Image = pictureBoxLikes.ErrorImage;
            }
        }

        // Events methods
        private void LinkEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (AppManagment.Instance.LoggedInUser != null)
            {
                new Thread(displayEvents).Start();
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
            ListBoxEvents.Invoke(new Action(() => ListBoxEvents.DisplayMember = "Name"));

            foreach (Event fbEvent in AppManagment.Instance.LoggedInUser.Events)
            {
                if (fbEvent.Name != null)
                {
                    ListBoxEvents.Invoke(new Action(() => ListBoxEvents.Items.Add(fbEvent.Name)));
                }

                else
                {
                    ListBoxEvents.Invoke(new Action(() => ListBoxEvents.Items.Add("This event has no name")));
                }


            }

            if (AppManagment.Instance.LoggedInUser.Events.Count == 0)
            {

                ListBoxEvents.Invoke(new Action(() => ListBoxEvents.Items.Add("No events to show")));
            }
        }

        private void ListBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayPicture(pictureBoxEvents, ListBoxEvents);
        }


        // Groups methods
        private void LinkGroups_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (AppManagment.Instance.LoggedInUser != null)
            {
                new Thread(fetchUsersGroups).Start();
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
            ListBoxGroups.Invoke(new Action(() => ListBoxGroups.DisplayMember = "Name"));
            foreach (Group group in AppManagment.Instance.LoggedInUser.Groups)
            {
                ListBoxGroups.Invoke(new Action(() => ListBoxGroups.Items.Add(group)));
            }

            if (AppManagment.Instance.LoggedInUser.Groups.Count == 0)
            {
                ListBoxGroups.Invoke(new Action(() => ListBoxGroups.Items.Add("No groups to show")));
            }
        }
        private void ListBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayPicture(pictureBoxGroups, ListBoxGroups);
        }


        // Gender statistics methods
        private void buttonCalculateStats_Click(object sender, EventArgs e)
        { 
            try
            {
                AppManagment.Instance.CalculateGenderStats();
            }
            catch (Exception)
            {
                return;
            }
           new Thread(displayGenderStats).Start();
        }

        private void displayGenderStats()
        {
            
            labelMaleCounter.Text = AppManagment.Instance.GetSubsystem<GenderStatsCalculator>().Males.ToString();
            labelFemaleCounter.Text = AppManagment.Instance.GetSubsystem<GenderStatsCalculator>().Female.ToString();
            labelAvgMales.Text = AppManagment.Instance.GetSubsystem<GenderStatsCalculator>().MaleAgeAvg().ToString();
            labelAvgFemales.Text = AppManagment.Instance.GetSubsystem<GenderStatsCalculator>().FemaleAgeAvg().ToString();

        }

        // City statistics methods
        private void ListBoxFriendsCityStats_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayPicture(pictureBoxCloseFriend, ListBoxFriendsCityStats);
        }

        private void linkNumOfFriends_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (AppManagment.Instance.LoggedInUser != null)
            {
                new Thread(displayFriends).Start();
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
            listBoxFriends.Invoke(new Action(() => listBoxFriends.DisplayMember = "Name"));


            foreach (User friend in AppManagment.Instance.LoggedInUser.Friends)
            {
                listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add(friend)));

            }
            if (AppManagment.Instance.LoggedInUser.Friends.Count == 0)
            {
                listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add("No friends to show")));
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
                //invoke
                i_pictureBox.Image = pictureBoxEvents.ErrorImage;
            }
            else
            {
                i_pictureBox.Invoke(new Action(() => i_pictureBox.LoadAsync(selectedObject.PictureNormalURL)));

            }
        }

        // Background color methods
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

        // Birthday methods
        private void buttonFetchBirthdays_Click(object sender, EventArgs e)
        {
            fetchAndDisplayBirthdays();
        }

        
        private void fetchAndDisplayBirthdays()
        {
            if (AppManagment.Instance.LoggedInUser == null)
            {
                MessageBox.Show("Please log in to fetch birthdays.");
                return;
            }
            listBoxBirthdays.Items.Clear();
            m_birthdayManager = new BirthdayManager(AppManagment.Instance.LoggedInUser);
            m_friendsWithBirthdays = m_birthdayManager.GetTodayBirthdays();

            if (m_friendsWithBirthdays.Count == 0)
            {
                listBoxBirthdays.Invoke(new Action(() => listBoxBirthdays.Items.Add("No friends have birthday today")));
                return;
            }

            foreach (User friend in m_friendsWithBirthdays)
            {
                listBoxBirthdays.Invoke(new Action(() => listBoxBirthdays.Items.Add(friend.Name)));
            }
        }

        private void listBoxBirthdays_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayPicture(pictureBoxBirthdays, listBoxBirthdays);
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
            if (i_Message.Length == 0 || i_Message == "Write here your costumized massage")
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
                BirthdayManager birthdayManager = new BirthdayManager(AppManagment.Instance.LoggedInUser);

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

        // Photo slideshow methods
        private void prefetchPhotos()
        {
            try
            {
                cachedPhotos.Clear();

                // Fetch all albums and their photos
                foreach (Album album in AppManagment.Instance.LoggedInUser.Albums)
                {
                    if (album.Photos != null)
                    {
                        //need to invoke?
                        cachedPhotos.AddRange(album.Photos);
                    }
                }

                if (cachedPhotos.Count == 0)
                {
                    MessageBox.Show("No photos available to display.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fetching Memories...");
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void displayRandomPhoto()
        {
            if (cachedPhotos.Count == 0)
            {
                MessageBox.Show("No photos available. Please log in and try again.");
                return;
            }

            try
            {
                // Pick a random photo
                int randomIndex = random.Next(cachedPhotos.Count);
                Photo randomPhoto = cachedPhotos[randomIndex];

                // Display the photo in the PictureBox
                pictureBoxSlideshow.Invoke(new Action(() => pictureBoxSlideshow.LoadAsync(randomPhoto.PictureNormalURL)));
                pictureBoxSlideshow.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying the photo.");
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void pictureBoxPhotosMemories_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            prefetchPhotos();
            displayRandomPhoto(); // Display the first random photo
            // A timer to change the photo every few seconds
            Timer slideshowTimer = new Timer();
            slideshowTimer.Interval = 5000;
            slideshowTimer.Tick += (s, args) => displayRandomPhoto();
            slideshowTimer.Start();
        }

        // City statistics methods
        private void FetchCityStats_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Thread(fetchFriendsCityStats).Start();
        }

        private void fetchFriendsCityStats()
        {
            ListBoxFriendsCityStats.Items.Clear();
            ListBoxFriendsCityStats.Invoke(new Action(() => ListBoxFriendsCityStats.DisplayMember = "Name"));

            Dictionary<string, int> cityStatistics;

            try
            {
                // Attempt to fetch real city statistics
                cityStatistics = AppManagment.Instance.GetCityStatistics(AppManagment.Instance.LoggedInUser.Friends.ToList());
            }
            catch
            {
                // Use simulated data if permissions are missing
                MessageBox.Show("Using simulated data due to missing permissions.");
            }

            cityStatistics = AppManagment.Instance.GetSimulatedCityStatistics();
            foreach (KeyValuePair<string, int> cityStat in cityStatistics)
            {
                ListBoxFriendsCityStats.Invoke(new Action(() => ListBoxFriendsCityStats.Items.Add($"{cityStat.Key}: {cityStat.Value} friends")));
            }

            string topCity = AppManagment.Instance.GetCityWithMostFriends(cityStatistics);
            labelTopCity.Text = $"Top City: {topCity}";

            double averageDistance = AppManagment.Instance.CalculateSimulatedAverageDistance();
            //invoke?
            labelAverageDistanceToFriends.Text = $"Average Distance To Friends: {averageDistance:F1} km";
        }

        private void buttonFindCloseFriends_Click(object sender, EventArgs e)
        {
            new Thread(displayNearbyFriends).Start();
        }

        private void displayNearbyFriends()
        {
            if (AppManagment.Instance.LoggedInUser == null)
            {
                MessageBox.Show("Please log in to view nearby friends.");
                return;
            }
            //consult with joel
            DistanceCalculator.eCity? userCity = AppManagment.Instance.ConvertToeCity(AppManagment.Instance.LoggedInUser.Hometown);

            if (!userCity.HasValue)
            {
                MessageBox.Show("Your hometown is unavailable. Cannot calculate close friends.");
                return;
            }

            List<User> closeFriends = AppManagment.Instance.GetCloseFriends(
                AppManagment.Instance.LoggedInUser.Friends.ToList(),
                userCity.Value
            );

            if (closeFriends.Count > 0)
            {
                MessageBox.Show($"You have {closeFriends.Count} close friends nearby!");
                listBoxCloseFriends.Items.Clear();
                foreach (User friend in closeFriends)
                {
                    listBoxCloseFriends.Invoke(new Action(() => listBoxCloseFriends.Items.Add(friend.name)));
                }
            }
            else
            {
                MessageBox.Show("You have no close friends nearby.");
            }
        }


    }
}

