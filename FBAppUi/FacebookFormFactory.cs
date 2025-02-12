using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal enum eFormType
    {
        LoginForm,
        MainForm,
        AlbumDetailsForm
    }

    internal class FacebookFormFactory
    {
        private static readonly Dictionary<eFormType, Func<Form>> formCreators = new Dictionary<eFormType, Func<Form>>
        {
            { eFormType.LoginForm, () => new LoginForm() },
            { eFormType.MainForm, () => new FormMain() },
            { eFormType.AlbumDetailsForm, () => new AlbumDetailsForm() }
        };

        public static Form CreateForm(eFormType i_FormType)
        {
            if (formCreators.TryGetValue(i_FormType, out Func<Form> createForm))
            {
                return createForm();
            }

            MessageBox.Show(@"Not a known form type, please try again");
            return null;
        }
    }
}
