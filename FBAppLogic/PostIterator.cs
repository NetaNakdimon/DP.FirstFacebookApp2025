using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;


namespace FBLogic
{

    public class PostIterator : IPostIterator
    {
        private readonly List<Post> r_Posts;
        private int m_CurrentPosition;
        private bool m_IsReverse;

        public PostIterator(List<Post> i_Posts, bool i_IsReverse = false)
        {
            r_Posts = i_Posts;
            m_IsReverse = i_IsReverse;
            m_CurrentPosition = i_IsReverse ? r_Posts.Count - 1 : 0;
        }

        public bool HasNext()
        {
            return m_IsReverse ? m_CurrentPosition >= 0 : m_CurrentPosition < r_Posts.Count;
        }

        public Post GetNext()
        {
            if (HasNext())
            {
                Post post = r_Posts[m_CurrentPosition];
                m_CurrentPosition += m_IsReverse ? -1 : 1;
                return post;
            }
            return null;
        }

        public void Reset()
        {
            m_CurrentPosition = m_IsReverse ? r_Posts.Count - 1 : 0;
        }
    }

}
