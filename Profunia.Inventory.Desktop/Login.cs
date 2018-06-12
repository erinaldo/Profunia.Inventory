using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profunia.Inventory.Desktop
{
    public partial class Login : Form
    {
        private string UserNames;

        private string Passwords;

        public Login(string UserName, string Password)
        {
            InitializeComponent();
            UserNames = UserName;
            Passwords = Password;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
            base.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserNames != null && Passwords != null)
            {
                if (textBox1.Text == UserNames && Passwords == textBox2.Text)
                {
                    base.DialogResult = DialogResult.OK;
                    base.Close();
                }
                else
                {
                    MessageBox.Show("Sorry, password mismatch.", "Openmiracle");
                }
            }
        }
    }
}
