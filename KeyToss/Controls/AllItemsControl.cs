using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordManager.Model;
using PasswordManager.Services;
using DevExpress.XtraBars.Alerter;
using System.Web.Services.Description;

namespace Password_Manager_WF.Controls
{
    public partial class AllItemsControl: UserControl
    {
        private byte[] _aesKey;
        private List<ListViewItem> originalItems = new List<ListViewItem>();

        public AllItemsControl(byte[] aesKey)
        {
            InitializeComponent();
            InitializeContextMenu();
            _aesKey = aesKey;
            LoadEntries();
        }

        private void LoadEntries()
        {
            PasswordService service = new PasswordService();
            var passwordList = service.GetPasswords(_aesKey);

            ActualizeView(passwordList);
        }

        private void ActualizeView(List<PasswordEntry> passwordList)
        {
            allItems.Items.Clear();
            originalItems.Clear();

            foreach (var entry in passwordList)
            {
                ListViewItem item = new ListViewItem(entry.Website);
                item.SubItems.Add(entry.Username);
                item.SubItems.Add(entry.EncryptedPassword);
                item.SubItems.Add(entry.Category); 

                allItems.Items.Add(item);
                originalItems.Add((ListViewItem)item.Clone());
            }
        }

        private void AddButtonOnClick(object sender, EventArgs e)
        {
            ShowControl(new AddItemControl(_aesKey));
        }

        private void ShowControl(UserControl newControl)
        {
            Controls.Clear();
            newControl.Dock = DockStyle.Fill;
            Controls.Add(newControl);
        }

        private void CopySelectedItems()
        {
            if (allItems.SelectedItems.Count > 0)
            {
                StringBuilder sb = new StringBuilder();

                foreach (ListViewItem item in allItems.SelectedItems)
                {
                    for (int i = 0; i < item.SubItems.Count; i++)
                    {
                        sb.Append(item.SubItems[i].Text);
                        if (i < item.SubItems.Count - 1) sb.Append("\t");
                    }
                    sb.AppendLine();
                }

                Clipboard.SetText(sb.ToString());
            }
        }

        private void InitializeContextMenu()
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();

            ToolStripMenuItem copyItem = new ToolStripMenuItem("Copy");
            copyItem.Click += (sender, e) => CopySelectedItems();

            contextMenu.Items.Add(copyItem);

            allItems.ContextMenuStrip = contextMenu;
        }

        private void deleteItemOnClick(object sender, EventArgs e)
        {
            ShowControl(new DeleteItemControl(_aesKey));
        }

        private void FormLoad(object sender, EventArgs e)
        {
            foreach (ListViewItem item in allItems.Items)
            {
                originalItems.Add((ListViewItem)item.Clone());
            }
        }

        private void searchOnClick(object sender, EventArgs e)
        {
            string searchText = searchBar.Text.ToLower();
            allItems.Items.Clear();

            foreach (var item in originalItems)
            {
                bool match = item.Text.ToLower().Contains(searchText);

                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    if (subItem.Text.ToLower().Contains(searchText))
                    {
                        match = true;
                        break; 
                    }
                }

                if (match)
                {
                    allItems.Items.Add((ListViewItem)item.Clone());
                }
            }
        }
    }
}
