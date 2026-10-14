using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

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
        private readonly string filepath;
        private readonly List<ComicStock> comics = new List<ComicStock>();

        public ComicRepo(string filepath)
        {
            this.filepath = filepath;
            string[] lines = File.ReadAllLines(filepath);
            foreach (string line in lines)
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
        public bool SellComic(string themeName)
        {
            ComicStock comic = comics.Find(
                c => c.ThemeName.Equals(
                    themeName,
                    StringComparison.OrdinalIgnoreCase
                )
            );
            if (comic == null || comic.Stock <= 0)
            {
                return false;
            }
            comic.Stock--;
            string[] lines = comics.ConvertAll(
                c => $"{c.ThemeName},{c.Price},{c.Stock}"
            ).ToArray();
            File.WriteAllLines(filepath, lines);
            return true;
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
