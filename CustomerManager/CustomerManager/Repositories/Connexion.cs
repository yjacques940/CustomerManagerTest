﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager.Repositories
{
    class Connexion
    {
        static public String BD { get; set; }
        static public String User { get; set; }
        static public String Password { get; set; }
        static MySqlConnection connexion = null;

        Connexion()
        {
            try
            {
                connexion = new MySqlConnection();
                //MConnexion->ConnectionString="Database=biblio;Data Source=localhost;User Id=root;Password=root";
                connexion.ConnectionString = "Database=" + BD + ";Data Source=localhost;User Id=" + User + ";Password=" + Password;
                connexion.Open();
            }
            catch (System.ApplicationException e)
            {
                throw e;
            }
        }
        ~Connexion()
        {
            if (connexion != null)
            {
                connexion.Close();
            }
        }

        public static MySqlConnection getInstance()
        {
            if (connexion == null)
            {
                new Connexion();
            }
            return connexion;
        }
    }
}
