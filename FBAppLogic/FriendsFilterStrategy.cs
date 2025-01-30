using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FBLogic
{
    public class FriendsFilterStrategy
    {
        public virtual bool Filter(User i_Friend)
        {
            return true;
        }

        internal int CalculateAge(DateTime birthDate)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - birthDate.Year;

            if (now < birthDate.AddYears(age))
            {
                age--;
            }

            return age;
        }
    }

    public class Over10FilterStrategy : FriendsFilterStrategy
    {
        public override bool Filter(User i_Friend)
        {
            return DateTime.TryParse(i_Friend.Birthday, out DateTime birthday) && CalculateAge(birthday) > 10; ;
        }
    }

    public class Over18FilterStrategy : FriendsFilterStrategy
    {
        public override bool Filter(User i_Friend)
        {
            return DateTime.TryParse(i_Friend.Birthday, out DateTime birthday) && CalculateAge(birthday) > 18; ;
        }
    }

    public class Over25FilterStrategy : FriendsFilterStrategy
    {
        public override bool Filter(User i_Friend)
        {
            return DateTime.TryParse(i_Friend.Birthday, out DateTime birthday) && CalculateAge(birthday) > 25; ;
        }
    }

    public class Over50FilterStrategy : FriendsFilterStrategy
    {
        public override bool Filter(User i_Friend)
        {
            return DateTime.TryParse(i_Friend.Birthday, out DateTime birthday) && CalculateAge(birthday) > 50; ;
        }
    }
}
