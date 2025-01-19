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
        public static Form CreateForm(String i_Form)
        {
            Form newForm = null;

            try

            {
                switch (i_Form)
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
        }
            catch
            {
                MessageBox.Show(@"Not a known form type, please try again");
            }
            return newForm;
        }
    }
}
