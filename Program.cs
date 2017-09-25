using System;
using System.Collections.Generic;
using System.Linq;

using GroceryPOS.Data.DB;
using GroceryPOS.Data.BLL;

namespace GroceryPOSConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add a product
            AddSamepleProduct();

            // Search
            SearchForaProduct("apple");
        }

        static void AddSamepleProduct()
        {
            ProductBLL.Add("D003", "Coke", 20, "noimage.jpg");
        }

        static void SearchForaProduct(string text)
        {
            var items = ProductBLL.GetProductsBySearchString("fruit");
            Console.WriteLine("Search for '{0}' - {1} items Found", text, items.Count());
        }
    }
}
