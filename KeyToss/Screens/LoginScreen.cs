using PasswordManager.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Manager_WF
{
    public partial class LoginScreen: Form
    {
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        private readonly MasterPasswordHelper _masterPasswordHelper;
        private const int dp = 0x00020000;

        public LoginScreen()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(Form_MouseDown); // Event hinzufügen
            _masterPasswordHelper = new MasterPasswordHelper();
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= dp;
                return cp;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string masterpassword = textBox1.Text;
            bool isVerified = _masterPasswordHelper.VerifyMasterPassword(masterpassword);

            if (isVerified)
            {
                byte[] aesKey = AesEncryptionHelper.DeriveKeyFromPassword(masterpassword);
                if (aesKey == null | aesKey.Length == 0)
                {
                    return;
                }
                Hide();
                toastNotificationsManager1.ShowNotification("e684be6c-17a2-4546-a57f-84f939ced806");
                MainMenuScreen mainMenuScreen = new MainMenuScreen(aesKey);
                mainMenuScreen.ShowDialog();
            }
            else
            {
                toastNotificationsManager1.ShowNotification("6c225351-02ba-403f-bbf1-9ab0ebddfe1f");
            }
        }

        private void closeOnClick(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
