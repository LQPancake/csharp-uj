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
            catch (MySqlException ex)
            {
                Console.WriteLine("Hiba a MySQL kapcsolat létrehozásakor: " + ex.Message);
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Kölcsönző személyek adatainak felvitele");
            Console.WriteLine("---------------------------------------\n");
            while (true)
            {
                Console.Write("Kölcsönző neve (*): ");
                string kolcsonzoNev = Console.ReadLine();
                if (kolcsonzoNev == "") break;
                Console.Write("Kölcsönző telefonszáma: ");
                string kolcsonzoTelefonSzam = Console.ReadLine();
                Console.Write("Kölcsönző címe: ");
                string kolcsonzoCime = Console.ReadLine();
                Console.Write("Kölcsönző email címe: ");
                string kolcsonzoEmail = Console.ReadLine();
                string parancsString = "INSERT INTO " +
                    "kolcsonzok (kolcsonzoNev, kolcsonzoTelefonSzam, kolcsonzoCime, kolcsonzoEmail) " +
                    $"VALUES ('{kolcsonzoNev}', '{kolcsonzoTelefonSzam}', '{kolcsonzoCime}', '{kolcsonzoEmail}')";
                try
                {
                    MySqlConnection beszurasConn = new MySqlConnection(connectionString);
                    beszurasConn.Open();
                    MySqlCommand insertKolcsonzo = new MySqlCommand(parancsString, beszurasConn);
                    insertKolcsonzo.ExecuteNonQuery();
                    beszurasConn.Close();
                    Console.WriteLine("Adat bevitel sikeres");
                }
                catch(MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.ReadKey();
            }
        }
    }
}
