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
    public partial class AlbumDetailsForm : Form
    {
        public AlbumDetailsForm()
        {
            
            InitializeComponent();
            albumBindingSource.DataSource = AppManagment.Instance.ChosenAlbum;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
