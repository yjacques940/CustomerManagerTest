using CustomerManager.Model.ModelMapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerManager.Repositories;

namespace CustomerManager.ViewModel
{
    public class AddCustomerViewModel
    {
        private CustomerRepository repository;
        public BindingList<Customer> CustomerList { get; set; }
        public BindingList<Customer> CustomerListToShow { get; set; }

        public AddCustomerViewModel()
        {
              CustomerList = new BindingList<Customer>();
            CustomerListToShow = new BindingList<Customer>();
            repository = new CustomerRepository();
        }

        internal void SearchCustomerByName(string name)
        {
            var list = repository.SearchCustomerByName(name);
            var newlist = new BindingList<Customer>();
            foreach (var customer in list)
            {
                newlist.Add(customer);
            }
            
            CustomerList = newlist;
            CustomerListToShow = CustomerListToShow;
        }

        internal void GetAllCustomers()
        {
            var list = repository.GetAllCustomers();
            foreach (var customer in list)
            {
                CustomerList.Add(customer);
            }

            CustomerListToShow = CustomerList;
        }
        internal void SearchCustomerInAllCustomerList(string searchText)
        {
            var list = new BindingList<Customer>();
            foreach (var customer in CustomerListToShow)
            {
                if (customer.Name == searchText || customer.LastName == searchText|| customer.Comments == searchText||customer.Email == searchText)
                {
                    list.Add(customer);
                }
            }

            CustomerList = null;
            CustomerList = list;
        }
    }
}
