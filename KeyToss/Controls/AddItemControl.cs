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
    public partial class AddItemControl : UserControl
    {
        private readonly byte[] _aesKey;
        private readonly PasswordService _passwordService;

        public AddItemControl(byte[] aesKey)
        {
            InitializeComponent();
            _aesKey = aesKey;
            _passwordService = new PasswordService();
        }

        private void addNewItemOnClick(object sender, EventArgs e)
        {
            if(WebsiteInput.Text == "" || UsernameInput.Text == "" || PasswordInput.Text == "")
            {
                toastNotificationsManager1.ShowNotification("e995d5b6-2454-4240-95ad-0c17cd14f948");
                return;
            } else if (GetSelectedCategory() == string.Empty)
            {
                toastNotificationsManager1.ShowNotification("4fe2dba8-b7e6-4e73-95f7-3d18e9d85bae");
                return;
            } else
            {
                int newId = _passwordService.GetNextId();
                string website = WebsiteInput.Text;
                string username = UsernameInput.Text;
                string password = PasswordInput.Text;
                string category = GetSelectedCategory();

                _passwordService.AddPassword(newId, website, username, password, category, _aesKey);
                toastNotificationsManager1.ShowNotification("e32a33ac-9493-4aac-9502-71f3d5d106fc");
                ShowControl(new AllItemsControl(_aesKey));
            }
        }

        private string GetSelectedCategory()
        {
            foreach (RadioButton radioButton in CategoryPanel.Controls)
            {
                if (radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }
            return string.Empty;
        }

        private void ShowControl(UserControl newControl)
        {
            Controls.Clear();
            newControl.Dock = DockStyle.Fill;
            Controls.Add(newControl);
        }
    }
}
