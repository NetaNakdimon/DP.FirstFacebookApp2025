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
        /// Link to the google document of the assignment https://docs.google.com/document/d/1BqRcuqV6XXml75Hrkiy6AvqS-GXjLySdlD8DccAkp_Y/edit?usp=sharing
        /// </summary>
        [STAThread]
        static void Main()
        {
            Clipboard.SetText("design.patterns20cc");
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
