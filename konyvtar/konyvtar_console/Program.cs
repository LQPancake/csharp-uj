using MySql.Data.MySqlClient;
using System;

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
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.ReadKey();

            //------------------------------------------------
            // SELECT
            //------------------------------------------------

            string parancsSelect = "SELECT * FROM kolcsonzok";
            MySqlConnection listaConn = new MySqlConnection(connectionString);
            listaConn.Open();
            MySqlCommand commandSelect = new MySqlCommand(parancsSelect, listaConn);
            MySqlDataReader adatok = commandSelect.ExecuteReader();

            while (adatok.Read())
            {
                Console.WriteLine("" +
                    $"{adatok["kolcsonzokID"]}\t" +
                    $"{adatok["kolcsonzoNev"]}\t" +
                    $"{adatok["kolcsonzoTelefonSzam"]}\t" +
                    $"{adatok["kolcsonzoCime"]}\t" +
                    $"{adatok["kolcsonzoEmail"]}");
            }
            listaConn.Close();
            Console.ReadKey();

            //------------------------------------------------
            // UPDATE
            //------------------------------------------------

            while (true)
            {
                Console.Write("Melyik sort szeretnéd módosítani? ");
                int modositando = int.Parse(Console.ReadLine());
                if (modositando == 0) break;
                Console.Write("Kölcsönző neve (*): ");
                string updateNev = Console.ReadLine();
                Console.Write("Kölcsönző telefonszáma: ");
                string updateTelefonSzam = Console.ReadLine();
                Console.Write("Kölcsönző címe: ");
                string updateCime = Console.ReadLine();
                Console.Write("Kölcsönző email címe: ");
                string updateEmail = Console.ReadLine();

                string parancsUpdate = "UPDATE kolcsonzok " +
                $"SET kolcsonzoNev='{updateNev}', " +
                $"kolcsonzoTelefonSzam='{updateTelefonSzam}', " +
                $"kolcsonzoCime='{updateCime}', " +
                $"kolcsonzoEmail='{updateEmail}' " +
                $"WHERE kolcsonzokID={modositando}";

                try
                {
                    MySqlConnection connUpdate = new MySqlConnection(connectionString);
                    connUpdate.Open();
                    MySqlCommand cmdUpdate = new MySqlCommand(parancsUpdate, connUpdate);
                    int siker = cmdUpdate.ExecuteNonQuery();
                    Console.WriteLine($"Státusz: {siker}");
                    connUpdate.Close();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }



            Console.ReadKey();

            //------------------------------------------------
            // DELETE
            //------------------------------------------------

            while (true)
            {
                Console.Write("Melyik sort szeretnéd törölni? ");
                int torlendo = int.Parse(Console.ReadLine());
                if (torlendo == 0) break;
                string parancsDelete = $"DELETE FROM kolcsonzok WHERE kolcsonzokID={torlendo}";

                try
                {
                    MySqlConnection connDelete = new MySqlConnection(connectionString);
                    connDelete.Open();
                    MySqlCommand cmdDelete = new MySqlCommand(parancsDelete, connDelete);
                    int siker = cmdDelete.ExecuteNonQuery();
                    Console.WriteLine($"Státusz: {siker}");
                    connDelete.Close();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.ReadKey();
        }
    }
}