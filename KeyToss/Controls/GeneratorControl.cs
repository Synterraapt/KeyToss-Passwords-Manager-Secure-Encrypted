using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordManager.Services;

namespace Password_Manager_WF.Controls
{
    public partial class GeneratorControl: UserControl
    {
        private readonly PasswordService _passwordService;
        private readonly byte[] _aesKey;
        private AllItemsControl _allItemsControl;

        public GeneratorControl(byte[] aesKey)
        {
            _passwordService = new PasswordService();
            InitializeComponent();

            _aesKey = aesKey;
        }

        private void PwGeneratorOnClick(object sender, EventArgs e)
        {
            string passwordLength = passwordLengthBox.Text;
            if (string.IsNullOrWhiteSpace(passwordLength))
            {
                toastNotificationsManager1.ShowNotification("5eb34141-af71-4dc9-8c29-8088d241e3f0");
                return;
            }

            if (int.TryParse(passwordLength, out int length) && length > 0)
            {
                string password = _passwordService.GeneratePassword(length);
                toastNotificationsManager1.ShowNotification("093666e6-9f19-4f0c-a567-09a8e3c4eb69");
                ShowControl(new GeneratorSucceedControl(_aesKey, password));
            }
            else
            {
                toastNotificationsManager1.ShowNotification("fecb214d-7c99-441b-8eff-17b736f10735");
            }
        }
        private void ShowControl(UserControl newControl)
        {
            Controls.Clear();
            newControl.Dock = DockStyle.Fill;
            Controls.Add(newControl);
        }

    }
}
