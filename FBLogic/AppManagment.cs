using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FBLogic
{

    
        public class AppManagment
        {
            private LoginResult m_LoginResult;
            private User m_LoggedInUser;
            public AppManagment m_AppManagmentInstance = null;

        private AppManagment()
        {
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


            public static AppManagment Instance { get; } = new AppManagment();

            public void Login()
            {
                m_LoginResult = FacebookService.Login(
                    //App ID
                    "1834076264004728",
                        /// requested permissions:
                        "email",
                        "public_profile",
                        "user_age_range",
                        "user_birthday",
                        "user_events",
                        "user_friends",
                        "user_gender",
                        "user_hometown",
                        "user_likes",
                        "user_link",
                        "user_location",
                        "user_photos",
                        "user_posts",
                        "user_videos"
                        
                    );
                if (m_LoginResult != null && string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
                {
                    m_LoggedInUser = m_LoginResult.LoggedInUser;
                }


            }


            public void Logout()
            {
                FacebookService.LogoutWithUI();
            }

        }
    }

