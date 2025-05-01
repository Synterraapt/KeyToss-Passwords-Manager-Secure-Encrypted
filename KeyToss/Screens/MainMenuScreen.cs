using Password_Manager_WF.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager_WF
{
    public partial class MainMenuScreen: Form
    {
        private byte[] _aesKey;
        private AllItemsControl _allItemsControl;
        public MainMenuScreen(byte[] aesKey)
        {
            InitializeComponent();
            this._aesKey = aesKey;
            ShowControl(new HomeControl(_aesKey));
            _allItemsControl = new AllItemsControl(_aesKey);
            _allItemsControl.Dock = DockStyle.Fill;
            Controls.Add(_allItemsControl);
        }

        private const int dp = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= dp;
                return cp;
            }
        }
        private void closeClick(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void homeButtonClick(object sender, EventArgs e)
        {
            ShowControl(new HomeControl(_aesKey));
        }

        private void allItemsButtonClick(object sender, EventArgs e)
        {
            ShowControl(new AllItemsControl(_aesKey));
        }

        private void generatorButtonClick(object sender, EventArgs e)
        {
            ShowControl(new GeneratorControl(_aesKey));
        }

        private void masterpasswordButtonClick(object sender, EventArgs e)
        {
            ShowControl(new MasterpasswordControl(_aesKey));
        }

        private void ShowControl(UserControl control)
        {
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }
    }
}
