using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Exceptions
{
    class AdminModel
    {

        public static Admin findByUsernameAndPass(string username, string password)
        {

            Admin ad = null;
            string query = "select * from admins where username='" + username + "' and password = '" + password + "';";


            try {
                MySqlCommand cmd = new MySqlCommand(query, ConnDB.DBConnection());
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();


                if (reader.Read())
                {
                    ad = (new Admin
                    {
                        Username = Convert.ToString(reader["Username"]),
                        Password = Convert.ToString(reader["Password"]),
                        Status = Convert.ToInt32(reader["Status"])
                    });

                }
                else
                {
                    Console.WriteLine("Admin hasnot been found.");
                }

                reader.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            
            return ad;

        }

        public static void loginForm()
        {
            Console.WriteLine("Username : ");
            string username = Console.ReadLine();
            Console.WriteLine("Password : ");
            string password = Console.ReadLine();
            Admin ad = findByUsernameAndPass(username, password);
            if (ad != null)
            {
                Console.WriteLine("Login succeed.");
            }
            else
            {
                Console.WriteLine("Login failed");
            }
        }
    }
}
