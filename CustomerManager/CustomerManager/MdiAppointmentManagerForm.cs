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
    public partial class MdiAppointmentManagerForm : Form
    {
        public MdiAppointmentManagerForm()
        {
            InitializeComponent();
            OpenAppointmentForm();
        }

        private void OpenAppointmentForm()
        {
            using (var form = new AppointmentManagerForm())
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        private void MdiAppointmentManagerForm_Load(object sender, EventArgs e)
        {
            AppointmentManagerForm form = new AppointmentManagerForm();
            form.MdiParent = this;
            form.Show();
        }
    }
}
