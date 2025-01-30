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
        public event EventHandler LoggedInSuccessfully;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Subscribe to UserLoggedIn before calling Login()
            AppManagment.Instance.UserLoggedIn += (s, args) =>
            {
                Console.WriteLine("UserLoggedIn event triggered! Now creating FormMain...");

                // Open the main application form upon successful login
                this.Hide();
                FacebookFormFactory.CreateForm("MainForm").ShowDialog();
                this.Close();
            };

            while (AppManagment.Instance.LoggedInUser == null)
            {
                AppManagment.Instance.Login();

                if (AppManagment.Instance.LoggedInUser != null)
                {
                    LoggedInSuccessfully?.Invoke(this, EventArgs.Empty);
                    break; // Exit loop since login succeeded
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
                        this.Close();
                        break;
                    }
                }
            }
        }

    }
}