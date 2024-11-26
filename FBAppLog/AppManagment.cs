using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FBAppLog
{
    public class AppManagment
    {
        private LoginResult m_LoginResult;
        private User m_LoggedInUser;
        public AppManagment m_AppManagmentInstance=null;

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
         
        }

        private AppManagment()
        {
        }

        public static AppManagment Instance { get; } = new AppManagment();

        public void Login()
        {
            m_LoginResult = FacebookService.Login(
                /// (This is Desig Patter's App ID. replace it with your own)
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



            }
        

         public void Logout()
        {
            FacebookService.LogoutWithUI();
        }

    }
}
