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
        public static Form CreateForm(String i_form)
        {
            Form newForm = null;
            switch (i_form)
            {
                case "LoginForm":
                    newForm = new LoginForm();
                    break;
                case "MainForm":
                    newForm = new FormMain();
                    break;
                case "AlbumDetailsForm":
                    newForm = new AlbumDetailsForm();
                    break;
            }
            return newForm;
        }
    }
}
