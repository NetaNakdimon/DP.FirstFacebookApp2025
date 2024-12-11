using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FBAppLogic
{
    public class BirthdayManager
    {
        private readonly User m_LoggedInUser;

        public BirthdayManager(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
        }

        public List<User> GetTodayBirthdays()
        {
            List<User> friendsWithBirthdaysToday = new List<User>();

            if (m_LoggedInUser?.Friends != null)
            {
                foreach (User friend in m_LoggedInUser.Friends)
                {
                    if (IsBirthdayToday(friend))
                    {
                        friendsWithBirthdaysToday.Add(friend);
                    }
                }
            }

            return friendsWithBirthdaysToday;
        }

        public bool SendBirthdayMessage(User i_Friend, string i_Message)
        {
            if (i_Friend == null || string.IsNullOrEmpty(i_Message))
            {
                throw new ArgumentNullException("Friend or message cannot be null.");
            }

            try
            {
                i_Friend.PostStatus(i_Message);
                return true;
            }
            catch (Exception)
            {
                return false; // Could not send the message
            }
        }

        private bool IsBirthdayToday(User i_Friend)
        {
            if (i_Friend == null || string.IsNullOrEmpty(i_Friend.Birthday))
            {
                return false;
            }

            if (DateTime.TryParse(i_Friend.Birthday, out DateTime birthday))
            {
                return birthday.Month == DateTime.Now.Month && birthday.Day == DateTime.Now.Day;
            }

            return false;
        }
    }
}
