using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationSystem
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUsername.Text == String.Empty)
            {
                MessageBox.Show("Enter username","Username required",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (TxtPassword.Text == String.Empty)
            {
                MessageBox.Show("Enter password","Password required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
               // Validate Login Credentials
                if (TxtUsername.Text == "admin" && TxtPassword.Text == "admin")
                {
                    Form _mainform = new MainForm();
                    _mainform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login", "Invalid login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
