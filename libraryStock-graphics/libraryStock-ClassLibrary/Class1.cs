using System.Collections.Generic;

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
    class Processor
    {

        private List<ComicStock> comics = new List<ComicStock>();

        public void Process()
        {
            // Starting data
            comics.Add(new ComicStock("Joker", 13, 398));
            comics.Add(new ComicStock("Batman", 22, 1203));
            comics.Add(new ComicStock("Cat", 11, 452));
            comics.Add(new ComicStock("Riddler", 15, 100));
            comics.Add(new ComicStock("Penguin", 19, 201));
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
