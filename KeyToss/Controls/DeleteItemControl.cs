using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.IO;
using PasswordManager.Components;
using PasswordManager.Model;
using PasswordManager.Services;


namespace Password_Manager_WF.Controls
{
    public partial class DeleteItemControl : UserControl
    {
        private byte[] _aesKey;
        private PasswordService _passwordService;

        public DeleteItemControl(byte[] aesKey)
        {
            InitializeComponent();
            _aesKey = aesKey;
            _passwordService = new PasswordService();
            LoadEntries();
        }

        private void LoadEntries()
        {
            var passwordList = _passwordService.GetPasswords(_aesKey);
            ActualizeView(passwordList);
        }

        private void ActualizeView(List<PasswordEntry> passwordList)
        {
            allItems.Items.Clear();

            foreach (var entry in passwordList)
            {
                ListViewItem item = new ListViewItem(entry.Id);
                item.SubItems.Add(entry.Website);
                item.SubItems.Add(entry.Username);
                item.SubItems.Add(entry.EncryptedPassword);
                item.SubItems.Add(entry.Category);

                allItems.Items.Add(item);
            }
        }

        private void deleteOnClick(object sender, EventArgs e)
        {
            if (IdInput.Text == "")
            {
                toastNotificationsManager1.ShowNotification("78696c86-325f-42cc-83e2-1db09312d82c");
                return;
            }
            else if (int.Parse(IdInput.Text) > _passwordService.GetNextId() - 1 ||int.Parse(IdInput.Text) < 0)
            {
                toastNotificationsManager1.ShowNotification("4c22e3fd-4146-4a1f-84f7-189275a7fbd3");
                return;
            }
            else
            {
                int idInput = int.Parse(IdInput.Text);
                _passwordService.DeletePassword(_aesKey, idInput);
                toastNotificationsManager1.ShowNotification("df6a9ad8-7ad2-41f1-b8aa-1610c00c13ae");
                ShowControl(new AllItemsControl(_aesKey));
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
