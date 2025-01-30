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
using FBAppLogic;
using System.Threading;
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
            AppManagment.Instance.UserLoggedIn += Instance_UserLoggedIn;
            AppManagment.Instance.UserLoggedOut += Instance_UserLoggedOut;
            if (AppManagment.Instance.LoggedInUser != null)
            {
                Console.WriteLine("User is already logged in. Updating UI.");
                displayUserInfoWhenLogin();
            }
    }

        private void Instance_UserLoggedIn(object sender, EventArgs e)
        {
            this.Invoke(new Action(() => displayUserInfoWhenLogin()));
        }

        private void Instance_UserLoggedOut(object sender, EventArgs e)
        {
            eraseWhenLogOut();
        }


        private List<Photo> m_CachedPhotos = new List<Photo>();
        private Random m_Random = new Random();
        public Album m_ChosenAlbum = null;



        // Login methods
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");
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

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppManagment.Instance.ChosenAlbum = ListBoxAlbums.SelectedItem as Album;
            displayAlbumPicture();
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
            listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Clear()));


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
            listBoxPosts.Invoke(new Action(() =>
            {
                if (listBoxPosts.SelectedIndex < 0 || listBoxPosts.SelectedIndex >= AppManagment.Instance.LoggedInUser.Posts.Count)
                {
                    listBoxPostComments.Invoke(new Action(() => listBoxPostComments.Items.Add("No post selected")));
                    return; // Exit if no valid post is selected
                }

                listBoxPostComments.Invoke(new Action(() => listBoxPostComments.Items.Clear()));
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
                    listBoxPostComments.Invoke(new Action(() => listBoxPostComments.Items.Add("No comments to show")));
                }
            }));
        }


        // Likes methods
        private void linkLikes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
            ListBoxLikes.Invoke(new Action(() => ListBoxLikes.Items.Clear()));
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

        private void listBoxLikes_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayLikedPagePicture();
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
        private void linkEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
            ListBoxEvents.Invoke(new Action(() => ListBoxEvents.Items.Clear()));
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

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayPicture(pictureBoxEvents, ListBoxEvents);
        }


        // Groups methods
        private void linkGroups_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
            ListBoxGroups.Invoke(new Action(() => ListBoxGroups.Items.Clear()));
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
            labelMaleCounter.Invoke(new Action(() =>
            {
                labelMaleCounter.Text = AppManagment.Instance.GetMalesCountAsString();
            }));

            labelFemaleCounter.Invoke(new Action(() =>
            {
                labelFemaleCounter.Text = AppManagment.Instance.GetFemalesCountAsString();
            }));

            labelAvgMales.Invoke(new Action(() =>
            {
                labelAvgMales.Text = AppManagment.Instance.GetMaleAgeAvgAsString();
            }));

            labelAvgFemales.Invoke(new Action(() =>
            {
                labelAvgFemales.Text = AppManagment.Instance.GetFemaleAgeAvgAsString();
            }));


        }

        // City statistics methods
        private void listBoxFriendsCityStats_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayPicture(pictureBoxCloseFriend, ListBoxFriendsCityStats);
        }

        private void linkNumOfFriends_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (AppManagment.Instance.LoggedInUser != null)
            {
                new Thread(() => displayFriendsFilter(friend => true)).Start();
            }
            else
            {
                MessageBox.Show("Please log in for this option");
                return;
            }
        }

 
        private void comboBoxFriendsFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Default: Show all friends
            Func<User, bool> filterCriteria = friend => true; 

            switch (comboBoxFriendsFilter.SelectedIndex)
            {
                case 1:
                    filterCriteria = friend => DateTime.TryParse(friend.Birthday, out DateTime birthday) && CalculateAge(birthday) > 10;
                    break;
                case 2:
                    filterCriteria = friend => DateTime.TryParse(friend.Birthday, out DateTime birthday) && CalculateAge(birthday) > 18;
                    break;
                case 3:
                    filterCriteria = friend => DateTime.TryParse(friend.Birthday, out DateTime birthday) && CalculateAge(birthday) > 25;
                    break;
                case 4:
                    filterCriteria = friend => DateTime.TryParse(friend.Birthday, out DateTime birthday) && CalculateAge(birthday) > 50;
                    break;
            }

            displayFriendsFilter(filterCriteria);
        }

        // Helper function to calculate age from Birthday
        private int CalculateAge(DateTime birthDate)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - birthDate.Year;

            if (now < birthDate.AddYears(age))
            {
                age--;
            }

            return age;
        }

        private void displayFriendsFilter(Func<User, bool> i_Test)
        {
            listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Clear()));
            listBoxFriends.Invoke(new Action(() => listBoxFriends.DisplayMember = "Name"));
            foreach (User friend in AppManagment.Instance.LoggedInUser.Friends)
            {
                if (i_Test(friend))
                {
                    listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add(friend)));
                }
            }
            if (listBoxFriends.Items.Count == 0)
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
            listBoxBirthdays.Invoke(new Action(() => listBoxBirthdays.Items.Clear()));

            if (AppManagment.Instance.GetTodayBirthdaysList().Count == 0)
            {
                listBoxBirthdays.Invoke(new Action(() => listBoxBirthdays.Items.Add("No friends have birthday today")));
                return;
            }

            foreach (User friend in AppManagment.Instance.GetTodayBirthdaysList())
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
            SendBirthdayMessageAdaptor(comboBoxOptionalMsg.Text);
        }

        private void buttonAddMassage_Click(object sender, EventArgs e)
        {
            SendBirthdayMessageAdaptor(textBoxAddedMassage.Text);
        }


        private void SendBirthdayMessageAdaptor(String i_Message)
        {
            try
            {
                sendBirthdayMessage(getThisFriend(listBoxBirthdays.SelectedIndex), i_Message);
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private User getThisFriend(int i_Index)
        {
            if (AppManagment.Instance.GetTodayBirthdaysList().Count == 0)
            {
                return null;
            }
            return AppManagment.Instance.GetTodayBirthdaysList()[i_Index];
        }

        private void sendBirthdayMessage(User i_Friend, string i_Message)
        {
            if (i_Message.Length == 0 || i_Message == "Write here your costumized massage")
            {
                MessageBox.Show("Please enter a massage");
            }

            try
            {
                if (AppManagment.Instance.GetTodayBirthdaysList().Count == 0)
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
                lock (m_CachedPhotos)
                {
                    m_CachedPhotos.Clear();
                }
                // Fetch all albums and their photos
                foreach (Album album in AppManagment.Instance.LoggedInUser.Albums)
                {
                    if (album.Photos != null)
                    {
                        lock (m_CachedPhotos)
                        {
                            m_CachedPhotos.AddRange(album.Photos);
                        }

                    }
                }

                if (m_CachedPhotos.Count == 0)
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
            if (m_CachedPhotos.Count == 0)
            {
                MessageBox.Show("No photos available. Please log in and try again.");
                return;
            }

            try
            {
                // Pick a random photo
                int randomIndex = m_Random.Next(m_CachedPhotos.Count);
                Photo randomPhoto = m_CachedPhotos[randomIndex];

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
            new Thread(prefetchPhotos).Start();
            displayRandomPhoto(); // Display the first random photo
            // A timer to change the photo every few seconds
            System.Windows.Forms.Timer slideshowTimer = new System.Windows.Forms.Timer();
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
            ListBoxFriendsCityStats.Invoke(new Action(() => ListBoxFriendsCityStats.Items.Clear()));
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
            labelTopCity.Invoke(new Action(() =>
            {
                labelTopCity.Text = $"Top City: {topCity}";
            }));

            labelAverageDistanceToFriends.Invoke(new Action(() =>
            {
                double averageDistance = AppManagment.Instance.CalculateSimulatedAverageDistance();
                labelAverageDistanceToFriends.Text = $"Average Distance To Friends: {averageDistance:F1} km";
            }));
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
                listBoxCloseFriends.Invoke(new Action(() => listBoxCloseFriends.Items.Clear()));
                foreach (User friend in closeFriends)
                {
                    listBoxCloseFriends.Invoke(new Action(() => listBoxCloseFriends.Items.Add(friend.Name)));
                }
            }
            else
            {
                MessageBox.Show("You have no close friends nearby.");
            }
        }

        private void buttonAlbumDetails_Click(object sender, EventArgs e)
        {
            this.Invoke(new Action(() => {
                if (AppManagment.Instance.ChosenAlbum != null)
                {
                    FacebookFormFactory.CreateForm("AlbumDetailsForm").ShowDialog();
                }
            }));
        }

    
    }
}

