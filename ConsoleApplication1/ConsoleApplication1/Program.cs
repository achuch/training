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

            Client nowy;
            nowy = new Client();
            nowy.Email = "aa@aa.pl";
            nowy.Id = 1;
        }
    }
}
