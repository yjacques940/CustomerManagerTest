using CustomerManager.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager.Repositories
{
    public class UserRepository
    {
        MySqlConnection connexion;

        public UserRepository()
        {
            Connexion.BD = "db_customerManager";
            Connexion.User = "root";
            Connexion.Password = "";
            connexion = Connexion.getInstance();
        }

        public User GetUserInfo(string username, string password)
        {
            MySqlCommand commandCourse;
            MySqlDataReader readerCourse;

            User course = new User();
            if (connexion != null)
            {
                commandCourse = connexion.CreateCommand();
                commandCourse.CommandText = "Select * from tbl_user where username='" + username + "' and password ='" + password +"'";
                readerCourse = commandCourse.ExecuteReader();
                //on place les valeurs de l'enregistrement trouvé à l'intérieur d'un objet métier (notre classe TEditeur)
                if (readerCourse.Read())
                {

                    course.username = readerCourse["username"].ToString();
                    course.Name     = readerCourse["name"].ToString();
                    course.LastName = readerCourse["lastname"].ToString();
                    course.Id       = readerCourse["id_user"].ToString();
                }
                readerCourse.Close();
            }
            return course;
        }
    }
}
