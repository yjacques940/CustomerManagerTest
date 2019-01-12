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

namespace CustomerManager.View
{
    public partial class AddCustomerForm : Form
    {
        private AddCustomerViewModel viewModel;

        public AddCustomerForm()
        {
            InitializeComponent();
            viewModel = new AddCustomerViewModel();
            viewModelBindingSource.DataSource = viewModel;
            viewModel.GetAllCustomers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewModel.SearchCustomerByName(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            viewModel.SearchCustomerInAllCustomerList(textBox2.Text);
        }
    }
}
