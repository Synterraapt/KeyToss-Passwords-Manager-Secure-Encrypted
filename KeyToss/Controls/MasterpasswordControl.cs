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

    public partial class MasterpasswordControl : UserControl
    {
        private readonly byte[] _aesKey;
        private readonly PasswordService _passwordService;

        public MasterpasswordControl(byte[] aesKey)
        {
            InitializeComponent();
            _aesKey = aesKey;
            _passwordService = new PasswordService();
        }

        private void MpChangedOnClick(object sender, EventArgs e)
        {
            string oldPassword = oldMasterPw.Text;
            string newPassword = newMasterPw.Text;
            string confirmPassword = newMasterPwConfirm.Text;

            if (newPassword != confirmPassword)
            {
                toastNotificationsManager1.ShowNotification("7f6a8153-3d9e-4d74-be66-2f13b6d196f0");
                return;
            }

            bool success = _passwordService.RenewMasterPassword(oldPassword, newPassword, _aesKey);
            if (success)
            {
                toastNotificationsManager1.ShowNotification("4a211faf-9d32-4cce-bcaf-4c8ade2cd07c");
                Application.Restart();
            } else if (string.IsNullOrWhiteSpace(oldPassword) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                toastNotificationsManager1.ShowNotification("345efb63-9e01-443c-b0cf-755278c4832d");
            }
            else
            {
                toastNotificationsManager1.ShowNotification("f419951b-a23d-4e9b-a3ca-cc0f32486652");
            }
        }
    }
}
