using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Link to the google document of the assignment https://docs.google.com/document/d/1otwCTDo6YOFDEnK2N5ZzyC4sQ1GZfstuELzrpWovw_s/edit?tab=t.0#heading=h.j4omosrlssh
        /// </summary>
        [STAThread]
        static void Main()
        {
            Clipboard.SetText("design.patterns20cc");
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(FacebookFormFactory.CreateForm("LoginForm"));
        }
    }
}
