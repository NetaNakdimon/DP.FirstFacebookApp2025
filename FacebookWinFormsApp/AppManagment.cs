using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{ 
    public class AppManagment

    {
        private AppManagment()
        {

        }
     
        private LoginResult m_LoginResult;
        private User m_LoggedInUser;
        private static AppManagment m_AppMamgamentInstance = null;

        public User LoggedInUser {
            get {  return m_LoggedInUser; }}
        public LoginResult LoginResult {
            get { return m_LoginResult; }}

        public static AppManagment Instance
        {
            get
            {
                if (m_AppMamgamentInstance == null)
                {
                    m_AppMamgamentInstance = new AppManagment();
                }

                return m_AppMamgamentInstance;
            }
        }


        private void loginAndInit()
        {
            m_LoginResult = FacebookService.Login("1450160541956417",
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
                    "user_videos");

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;

                //DialogResult = DialogResult.OK;
                //TODO- ERASE AFTER TESTING
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login succeed");
            }
        
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }
        }
    }
}
