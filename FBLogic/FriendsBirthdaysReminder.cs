using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook;
using FacebookWrapper.ObjectModel;


namespace FBLogic
{
    class FriendsBirthdaysReminder
    {
        private AppManagment m_AppManagment;
        public FriendsBirthdaysReminder()
        {

            m_AppManagment = AppManagment.Instance;
        }

        public List<string> GetFriendsBirthdays()
        {
            List<string> birthdaysList = new List<string>();

            if (m_AppManagment.LoggedInUser != null)
            {
                foreach (User friend in m_AppManagment.LoggedInUser.Friends)
                {
                    string birthdayInfo = friend.Name + " - " + friend.Birthday.ToString();
                    birthdaysList.Add(birthdayInfo);
                }
            }
            else
            {
                birthdaysList.Add("No user is logged in. Please log in first.");
            }

            return birthdaysList;
        }
    }

}