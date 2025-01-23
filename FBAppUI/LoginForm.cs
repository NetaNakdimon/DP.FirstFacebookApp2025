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
        

        public LoginForm()
        {
            InitializeComponent();
            

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
           
            while (AppManagment.Instance.LoggedInUser == null) 
            {
                AppManagment.Instance.Login(); 

                if (AppManagment.Instance.LoggedInUser != null)
                {
                    // Open the main application form upon successful login
                    
                    this.Hide(); 
                    FacebookFormFactory.CreateForm("MainForm").ShowDialog(); 
                    this.Close(); 
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