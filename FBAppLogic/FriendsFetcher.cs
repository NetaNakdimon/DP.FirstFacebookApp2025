using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FBLogic
{
    public class FriendsFetcher
    { 
    }
    public interface IFriendFetchStrategy
    {
        List<User> FetchFriends(List<User> friends);
    }

    public class FetchByFirstName : IFriendFetchStrategy
    {
        private readonly string m_FirstName;

        public FetchByFirstName(string i_FirstName)
        {
             m_FirstName = i_FirstName;
        }

        public List<User> FetchFriends(List<User> friends)
        {
            return friends.Where(friend => friend.Name.Split(' ')[0].StartsWith(m_FirstName, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }

    public class FetchByLastName : IFriendFetchStrategy
    {
        private readonly string m_LastName;

        public FetchByLastName(string i_LastName)
        {
            m_LastName = i_LastName;
        }

        public List<User> FetchFriends(List<User> friends)
        {
            return friends.Where(friend => friend.Name.Split(' ').Last().StartsWith(m_LastName, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }

    public class FetchByAge : IFriendFetchStrategy
    {
         private readonly int m_Age;

         public FetchByAge(int i_Age)
         {
             m_Age = i_Age;
         }

         public List<User> FetchFriends(List<User> friends)
         {
             return friends.Where(friend =>
             {
                 if (DateTime.TryParse(friend.Birthday, out DateTime birthDate))
                 {
                     int age = DateTime.Now.Year - birthDate.Year;
                     if (DateTime.Now < birthDate.AddYears(age)) age--;
                     return age == m_Age;
                 }
                 return false;
             }).ToList();
         }
     }
 }

