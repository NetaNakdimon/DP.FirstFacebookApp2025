using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FBAppLogic;

namespace BasicFacebookFeatures
{
    public partial class LoginForm : Form
    {
        AppManagment m_appManagment; // Instance of the application management class

        public LoginForm()
        {
            InitializeComponent();
            m_appManagment = AppManagment.Instance; // Initialize the singleton instance
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            while (m_appManagment.LoggedInUser == null) // Repeat until the user successfully logs in
            {
                m_appManagment.Login(); // Attempt to log in

                if (m_appManagment.LoggedInUser != null)
                {
                    // Open the main application form upon successful login
                    FormMain formMain = new FormMain(m_appManagment);
                    this.Hide(); // Hide the login form
                    formMain.ShowDialog(); // Show the main form
                    this.Close(); // Close the login form
                }
                else
                {
                    // Prompt the user to try logging in again or exit
                    DialogResult result = MessageBox.Show(
                        "Do you want to try again?",
                        "Login Failed",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Error);

                    if (result == DialogResult.No)
                    {
                        this.Close(); // Close the application if the user chooses not to retry
                        break;
                    }
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }
    }
}