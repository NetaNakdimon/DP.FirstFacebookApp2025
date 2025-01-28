using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FBLogic;

namespace FBLogic
{
    public class FetchFriendsByLastNameStrategy : IFriendFetchStrategy
    {
        private readonly string m_LastName;

        public FetchFriendsByLastNameStrategy(string i_LastName)
        {
            m_LastName = i_LastName;
        }

        public List<User> FetchFriends(List<User> friends)
        {
            return friends.Where(friend => friend.Name.Split(' ').Last().StartsWith(m_LastName, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
