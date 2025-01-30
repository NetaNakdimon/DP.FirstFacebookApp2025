using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using System.Collections;

namespace FBLogic
{


    public class PostCollection : IEnumerable<Post>
    {
        private readonly List<Post> r_Posts;

        public PostCollection(List<Post> i_Posts)
        {
            r_Posts = i_Posts;
        }

        public IPostIterator CreateIterator(bool i_IsReverse = false)
        {
            return new PostIterator(r_Posts, i_IsReverse);
        }

        public IEnumerator<Post> GetEnumerator()
        {
            return r_Posts.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
