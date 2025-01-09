using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FBAppLogic
{
    public class BirthdayManager
    {
        private readonly User m_LoggedInUser; // The logged-in user whose friends will be checked for birthdays

        public BirthdayManager(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser; // Initialize the manager with the logged-in user
        }

        public List<User> GetTodayBirthdays()
        {
            List<User> friendsWithBirthdaysToday = new List<User>(); // List to store friends with birthdays today

            if (m_LoggedInUser?.Friends != null)
            {
                foreach (User friend in m_LoggedInUser.Friends)
                {
                    if (IsBirthdayToday(friend)) // Check if the friend's birthday is today
                    {
                        friendsWithBirthdaysToday.Add(friend);
                    }
                }
            }

            return friendsWithBirthdaysToday; // Return the list of friends with birthdays today
        }

        public bool SendBirthdayMessage(User i_Friend, string i_Message)
        {
            if (i_Friend == null || string.IsNullOrEmpty(i_Message))
            {
                throw new ArgumentNullException("Friend or message cannot be null."); // Validate inputs
            }

            try
            {
                i_Friend.PostStatus(i_Message); // Attempt to post the birthday message
                return true;
            }
            catch (Exception)
            {
                return false; // Return false if the message could not be sent
            }
        }

        private bool IsBirthdayToday(User i_Friend)
        {
            if (i_Friend == null || string.IsNullOrEmpty(i_Friend.Birthday))
            {
                return false; // Return false if the friend's birthday is unavailable
            }

            if (DateTime.TryParse(i_Friend.Birthday, out DateTime birthday))
            {
                return birthday.Month == DateTime.Now.Month && birthday.Day == DateTime.Now.Day; // Check if today is their birthday
            }

            return false; // Return false if the birthday could not be parsed
        }
    }
}