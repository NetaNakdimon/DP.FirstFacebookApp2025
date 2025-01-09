using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBLogic
{
    public abstract class FacebookFormFactory
    {
        public static abstract Form CreateForm(string i_formType)
        {
            switch (i_formType)
            {
                case "LoginForm":
                    return new LoginForm();

                case "FormMain":
                    return new FormMain();
                default:
                    throw new InvalidOperationException("This is not an existing option for a form.");
            }
        }
    }
}
