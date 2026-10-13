using System.Collections.Generic;
using System.IO;

namespace ComicLibrary
{
    public class ComicStock
    {
        public string ThemeName { get; set; }
        public int Price { get; set; }   // $ per book
        public int Stock { get; set; }   // books currently in stock

        public ComicStock(string themeName, int price, int stock)
        {
            ThemeName = themeName;
            Price = price;
            Stock = stock;
        }

        public int TotalValue()
        {
            return Stock * Price;
        }
    }
    public class ComicRepo
    {

        private List<ComicStock> comics = new List<ComicStock>();
        public ComicRepo(string filepath)
        {
            string[] lines = File.ReadAllLines(filepath);
            foreach(string line in lines)
            {
                string[] parts = line.Split(',');
                ComicStock comic = new ComicStock(
                    parts[0],
                    int.Parse(parts[1]),
                    int.Parse(parts[2])
                );
                comics.Add(comic);
            }
        }
        public List<ComicStock> GetAllComics()
        {
            return comics;
        }


    }
    public class LoginSystem
    {
        public bool Login(string username, string password)
        {
            if (username == "admin" && password == "adminpass")
            {
                return true;
            }

            return false;
        }
    }
}
