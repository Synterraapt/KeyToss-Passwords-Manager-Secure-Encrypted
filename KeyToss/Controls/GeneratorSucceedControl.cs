using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager_WF.Controls
{
    public partial class GeneratorSucceedControl: UserControl
    {
        public GeneratorSucceedControl(byte[] aesKey, string generatedPassword)
        {
            InitializeComponent();
            passwordBox.Text = generatedPassword;
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void SetGeneratedPassword(string password)
        {
            passwordBox.Text = password;
        }

        private void CopyToClipboard(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(passwordBox.Text))
            {
                Clipboard.SetText(passwordBox.Text);
                toastNotificationsManager1.ShowNotification("a5a040b7-e4d6-4682-8ed2-9b49b008c996");
            }
        }
    }
}
