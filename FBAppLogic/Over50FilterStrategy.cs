using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FBLogic
{
    public class Over50FilterStrategy : FriendsFilterStrategy
    {
        public override bool Filter(User i_Friend)
        {
            return DateTime.TryParse(i_Friend.Birthday, out DateTime birthday) && CalculateAge(birthday) > 50; ;
        }
    }
}
