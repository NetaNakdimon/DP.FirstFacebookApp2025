using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FBAppLogic
{
    public class GenderStatsCalculator
    {
        private User m_LoggedInUser; // Logged-in user whose friends will be analyzed
        private int m_MaleCounter; // Count of male friends
        private int m_FemaleCounter; // Count of female friends
        private int m_MaleAgeSum; // Sum of ages of male friends
        private int m_FemaleAgeSum; // Sum of ages of female friends

        public GenderStatsCalculator()
        {
           
            m_LoggedInUser = AppManagment.Instance.LoggedInUser;
            m_MaleCounter = 0;
            m_FemaleCounter = 0;
            m_MaleAgeSum = 0;
            m_FemaleAgeSum = 0;
        }

        public int Males { get { return m_MaleCounter; } } // Property to access male count
        public int Female { get { return m_FemaleCounter; } } // Property to access female count

        public double MaleAgeAvg()
        {
            return m_MaleCounter > 0 ? (double)m_MaleAgeSum / m_MaleCounter : 0.0; // Calculate average male age
        }

        public double FemaleAgeAvg()
        {
            return m_FemaleCounter > 0 ? (double)m_FemaleAgeSum / m_FemaleCounter : 0.0; // Calculate average female age
        }

        public void CalculateGenderStats()
        {
            if (m_LoggedInUser?.Friends == null || m_LoggedInUser.Friends.Count == 0)
            {
                return; // Return early if no friends data is available
            }

            foreach (User friend in m_LoggedInUser.Friends)
            {
                int? age = GetUserAge(friend); // Get friend's age

                if (friend.Gender == User.eGender.male)
                {
                    m_MaleCounter++;

                    if (age.HasValue)
                    {
                        m_MaleAgeSum += age.Value; // Add to male age sum if age is available
                    }
                }
                else if (friend.Gender == User.eGender.female)
                {
                    m_FemaleCounter++;

                    if (age.HasValue)
                    {
                        m_FemaleAgeSum += age.Value; // Add to female age sum if age is available
                    }
                }
            }
        }

        private int? GetUserAge(User i_User)
        {
            if (DateTime.TryParse(i_User.Birthday, out DateTime birthDate))
            {
                int age = DateTime.Now.Year - birthDate.Year;
                if (DateTime.Now < birthDate.AddYears(age))
                {
                    age--; // Adjust age if birthday hasn't occurred yet this year
                }

                return age;
            }
            else
            {
                return null; // Return null if birthday is invalid or unavailable
            }
        }
    }
}