using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FBLogic;

namespace BasicFacebookFeatures
{
    public partial class LoginForm : Form
    {
        AppManagment m_appManagment;
        public LoginForm()
        {
            InitializeComponent();
            m_appManagment = AppManagment.Instance;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            while (m_appManagment.LoggedInUser == null)
            {
                m_appManagment.Login();

                if (m_appManagment.LoggedInUser != null)
                {
                    FormMain formMain = new FormMain(m_appManagment);
                    this.Hide();
                    formMain.ShowDialog();
                    this.Close();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Do you want to try again?","Login Failed",MessageBoxButtons.YesNo,MessageBoxIcon.Error);

                    if (result == DialogResult.No)
                    {
                        this.Close();
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
