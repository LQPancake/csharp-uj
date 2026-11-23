using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using konyvtar_classLibrary;
using MySql.Data.MySqlClient;

namespace konyvtar_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Felhasználó: ");
            string username = Console.ReadLine();
            Console.Write("Jelszó: ");
            string password = Console.ReadLine();

            string connectionString = "server=localhost;database=konyvtar;uid=" + username + ";pwd = " + password + ";";

            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                connection.Close();
                Console.WriteLine("A kapcsolat működik");
            }
            catch(MySqlException ex)
            {
                Console.WriteLine("Hiba a MySQL kapcsolat létrehozásakor: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
