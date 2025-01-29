using System;
using System.Collections.Generic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Threading.Tasks;

namespace FBAppLogic
{
    public sealed class AppManagment
    {
        private LoginResult m_LoginResult;
        private User m_LoggedInUser;
        private static AppManagment m_AppManagmentInstance = null;
        private static object s_LockObj = new Object();
        private static object s_LockObj2 = new Object();
        private static object s_GlobaLock = new Object();
        private BirthdayManager m_BirthdayManager;
        private List<User> m_FriendsWithBirthdaysToday;
        private GenderStatsCalculator m_GenderStatsCalculator;
        private DistanceCalculator m_DistanceCalculator;
        private Album m_ChosenAlbum = null;
        // Action delegate to notify observers
        public Action<User> OnLoggedInUserChanged { get; set; }

        private AppManagment() { }

        public static AppManagment Instance
        {
            get
            {
                if (m_AppManagmentInstance == null)
                {
                    lock (s_LockObj)
                    {
                        if (m_AppManagmentInstance == null)
                        {
                            m_AppManagmentInstance = new AppManagment();
                        }
                    }
                }
                return m_AppManagmentInstance;
            }
        }

        public LoginResult LoginResult
        {
            get { return m_LoginResult; }
            set
            {
                m_LoginResult = value;
            }
        }

        public User LoggedInUser
        {
            get => m_LoggedInUser;
            set
            {
                if (m_LoggedInUser != value)
                {
                    m_LoggedInUser = value;
                    NotifyObservers();
                }
            }
        }

        private void NotifyObservers()
        {
            OnLoggedInUserChanged?.Invoke(m_LoggedInUser);
        }

        public void Login()
        {
            m_LoginResult = FacebookService.Login(
                // App ID
                "1834076264004728",
                // Requested permissions
                "email",
                "public_profile",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_location",
                "user_likes",
                "user_link",
                "user_photos",
                "user_posts"
            );
            if (m_LoginResult.AccessToken != null && string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser; // Set the logged-in user if login is successful
                activateSubSystmes();

            }
        }

        public void Logout()
        {
            FacebookService.LogoutWithUI(); // Logs out the user using Facebook's UI
            deactivateSubSystmes();
            m_LoggedInUser = null; // Automatically notifies observers
            m_LoginResult = null;
        }

        public T GetSubsystem<T>() where T : class
        {
            if (typeof(T) == typeof(BirthdayManager))
            {
                if (m_BirthdayManager == null)
                {
                    m_BirthdayManager = new BirthdayManager(m_LoggedInUser);
                }
                return m_BirthdayManager as T;
            }
            else if (typeof(T) == typeof(GenderStatsCalculator))
            {
                if (m_GenderStatsCalculator == null)
                {
                    m_GenderStatsCalculator = new GenderStatsCalculator();
                }
                return m_GenderStatsCalculator as T;
            }
            else if (typeof(T) == typeof(DistanceCalculator))
            {
                if (m_DistanceCalculator == null)
                {
                    m_DistanceCalculator = new DistanceCalculator();
                }
                return m_DistanceCalculator as T;
            }
            else
            {
                throw new Exception("This is not a subsystem in this system");
            }
        }

        private void activateSubSystmes()
        {
            if (m_LoggedInUser != null)
            {
                m_BirthdayManager = new BirthdayManager(m_LoggedInUser);
                m_GenderStatsCalculator = new GenderStatsCalculator();
                m_DistanceCalculator = new DistanceCalculator();
            }
            else
            {
                throw new Exception("User is not logged in");
            }
        }

        private void deactivateSubSystmes()
        {
            m_BirthdayManager = null;
            m_GenderStatsCalculator = null;
            m_DistanceCalculator = null;
        }

        public void CalculateGenderStats()
        {
            m_GenderStatsCalculator.CalculateGenderStats();
        }

        public String GetMalesCountAsString()
        {
            return m_GenderStatsCalculator.Males.ToString();
        }

        public String GetFemalesCountAsString()
        {
            return m_GenderStatsCalculator.Female.ToString();
        }

        public String GetMaleAgeAvgAsString()
        {
            return m_GenderStatsCalculator.MaleAgeAvg().ToString();
        }

        public String GetFemaleAgeAvgAsString()
        {
            return m_GenderStatsCalculator.FemaleAgeAvg().ToString();
        }

        public Dictionary<string, int> GetCityStatistics(List<User> i_Friends)
        {
            Dictionary<string, int> cityStatistics = m_DistanceCalculator.GetCityStatistics(i_Friends);
            return cityStatistics;
        }

        public Dictionary<string, int> GetSimulatedCityStatistics()
        {
            Dictionary<string, int> simulatedStats = m_DistanceCalculator.GetSimulatedCityStatistics();
            return simulatedStats;
        }

        public string GetCityWithMostFriends(Dictionary<string, int> i_CityStatistics)
        {
            return m_DistanceCalculator.GetCityWithMostFriends(i_CityStatistics);
        }

        public double CalculateSimulatedAverageDistance()
        {
            double averageDistance = m_DistanceCalculator.CalculateSimulatedAverageDistance();
            return averageDistance;
        }

        public DistanceCalculator.eCity? ConvertToeCity(City i_City)
        {
            return m_DistanceCalculator.ConvertToECity(i_City);
        }

        public List<User> GetCloseFriends(List<User> i_FriendsList, DistanceCalculator.eCity i_UserCity)
        {
            List<User> closeFriends = m_DistanceCalculator.GetCloseFriends(i_FriendsList, i_UserCity);
            return closeFriends;
        }

        public List<User> GetTodayBirthdaysList()
        {
            if (m_FriendsWithBirthdaysToday == null)
            {
                lock (s_LockObj2)
                {
                    if (m_FriendsWithBirthdaysToday == null)
                    {
                        m_FriendsWithBirthdaysToday = m_BirthdayManager.GetTodayBirthdays();
                    }
                }
            }
            return m_FriendsWithBirthdaysToday;
        }

        public object GlobalLock()
        {
            return s_GlobaLock;
        }

        public Album ChosenAlbum
        {
            get { return m_ChosenAlbum; }
            set
            {
                m_ChosenAlbum = value;
            }
        }
    }
}
