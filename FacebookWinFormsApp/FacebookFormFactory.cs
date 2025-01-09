using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal class FacebookFormFactory
    {
        public static Form createForm(String form)
        {
            Form newForm = null;
            switch (form)
            {
                case "LoginForm":
                    newForm = new LoginForm();
                    break;
                case "MainForm":
                    newForm = new FormMain();
                    break;
            }
            return newForm;
        }
    }
}
