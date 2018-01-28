using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Models;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yes");

            Category newCategory = new Category()
            {
                ID = 1,
                Name = "Narzędzia"
            };

            Product newProduct = new Product()
            {
                ID = 1,
                Category = newCategory,
                Name = "Młotek"
            };

            Client newClient = new Client()
            {
                Id = 1,
                Email = "aa@aa.pl"
            };
        }
    }
}
