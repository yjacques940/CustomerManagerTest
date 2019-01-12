using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerManager.ViewModel;

namespace CustomerManager
{
    public partial class LoginForm : Form
    {
        private LoginViewModel viewModel;
        public LoginForm()
        {
            InitializeComponent();
            viewModel = new LoginViewModel();
            versionNumerLabel.Text = "Version - " + Global.VersionNumber;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (viewModel.Connect(usernameTextbox.Text,passwordTextbox.Text))
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Aucun utilisateur trouvé!");
            }

        }
    }
}
