using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FBAppLogic
{

    public sealed class AppManagment
    {
        private LoginResult m_LoginResult; // Holds the result of the Facebook login operation
        private User m_LoggedInUser; // The currently logged-in Facebook user
        private static AppManagment m_AppManagmentInstance = null; // Instance of the class (might be redundant due to singleton pattern)
        private static object s_LockObj = new Object();
        private BirthdayManager m_BirthdayManager;
        private GenderStatsCalculator m_GenderStatsCalculator;
        private DistanceCalculator m_DistanceCalculator;


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
            get
            {
                return m_LoginResult;
            }
            set
            {
                m_LoginResult = value;
            }
        }

        public User LoggedInUser
        {
            get
            {
                return m_LoggedInUser;
            }
            set
            {
                m_LoggedInUser = value;
            }
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

            if (m_LoginResult != null && string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser; // Set the logged-in user if login is successful
                activateSubSystmes();
            }
        }

        public void Logout()
        {
            FacebookService.LogoutWithUI(); // Logs out the user using Facebook's UI
            deactivateSubSystmes();
            m_LoggedInUser = null;
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


    }
}

