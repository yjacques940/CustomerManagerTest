using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerManager
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            welcolmeMessage.Text = "Bonjour " + Global.CurrentUserName + "!";
            dateTimeTimer.Start();
            dateLabel.Text = DateTime.Now.ToString();
        }

        private void dateTimeTimer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToString();
        }

        private void appointmentManagerButton_Click(object sender, EventArgs e)
        {
            using (var form = new MdiAppointmentManagerForm())
            {
                form.ShowDialog();
            }
        }
    }
}
