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

        internal int CalculateAge(DateTime i_birthDate)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - i_birthDate.Year;

            if (now < i_birthDate.AddYears(age))
            {
                age--;
            }

            return age;
        }
    }
}
