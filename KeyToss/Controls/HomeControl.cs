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
    public partial class HomeControl: UserControl
    {
        private byte[] _aeskey;

        public HomeControl(byte[] aesKey)
        {
            InitializeComponent();
            this._aeskey = aesKey;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ibrazqrj");
        }
    }
}
