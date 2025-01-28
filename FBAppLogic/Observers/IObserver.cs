using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBLogic.Observers
{
    public interface IObserver
    {
        void Update(); // Called when the state of the subject changes
    }
}
