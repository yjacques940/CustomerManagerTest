using CustomerManager.Model.ModelMapping;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager.Repositories
{
    public class CustomerRepository
    {
        MySqlConnection connexion;

        public CustomerRepository()
        {
            Connexion.BD = "db_customerManager";
            Connexion.User = "root";
            Connexion.Password = "";
            connexion = Connexion.getInstance();
        }

        public List<Customer> SearchCustomerByName(string name)
        {
            MySqlCommand commandCourse;
            MySqlDataReader readerCourse;

             var customerList = new List<Customer>();
            if (connexion != null)
            {
                commandCourse = connexion.CreateCommand();
                commandCourse.CommandText = "Select * from tbl_customer where name='" + name + "'";
                readerCourse = commandCourse.ExecuteReader();
                //on place les valeurs de l'enregistrement trouvé à l'intérieur d'un objet métier (notre classe TEditeur)
                while (readerCourse.Read())
                {
                    Customer customer = new Customer();
                    customer.Name     = readerCourse["name"].ToString();
                    customer.Email    = readerCourse["email"].ToString();
                    customer.LastName = readerCourse["lastname"].ToString();
                    customer.Id       = readerCourse["id_customer"].ToString();
                    customer.Comments = readerCourse["comments"].ToString();
                    customerList.Add(customer);
                }
                readerCourse.Close();
            }
            return customerList;
        }

        internal List<Customer> GetAllCustomers()
        {
            MySqlCommand commandCourse;
            MySqlDataReader readerCourse;

            var customerList = new List<Customer>();
            if (connexion != null)
            {
                commandCourse = connexion.CreateCommand();
                commandCourse.CommandText = "Select * from tbl_customer";
                readerCourse = commandCourse.ExecuteReader();
                //on place les valeurs de l'enregistrement trouvé à l'intérieur d'un objet métier (notre classe TEditeur)
                while (readerCourse.Read())
                {
                    Customer customer = new Customer();
                    customer.Name = readerCourse["name"].ToString();
                    customer.Email = readerCourse["email"].ToString();
                    customer.LastName = readerCourse["lastname"].ToString();
                    customer.Id = readerCourse["id_customer"].ToString();
                    customer.Comments = readerCourse["comments"].ToString();
                    customerList.Add(customer);
                }
                readerCourse.Close();
            }
            return customerList;
        }
    }
}
