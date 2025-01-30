using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;


namespace FBLogic
{

    public interface IPostIterator
    {
        bool HasNext();
        Post GetNext();
        void Reset();
    }
}