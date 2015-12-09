using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalcCost(DrawerCount(),woodType()).ToString("c0"));
        }

        private static int DrawerCount()
        {
            Console.Write("# of Drawers: ");
            int count = Convert.ToInt32(Console.ReadLine());
            return count;
        }
        private static string woodType()
        {
            Console.Write("m, o, or p?: ");
            char type = Convert.ToChar(Console.ReadLine());
            string wood = "";

            while (type != 'p' && type != 'o' && type != 'm')
            {
                Console.WriteLine("Please enter a valid letter (m, o, or p):");
                type = Convert.ToChar(Console.ReadLine());
            }

            if (type == 'p')
                wood = "pine";
            else if (type == 'o')
                wood = "oak";
            else if (type == 'm')
                wood = "mahogany";

            Console.WriteLine(("Type of wood: " + wood));
            return wood;
        }
        private static int CalcCost(int count, string type)
        {
            int price = 0;
            if (type == "pine")
                price = 100;
            else if (type == "oak")
                price = 140;
            else
                price = 180;

            int cost = (count * 30) + price;
            
            priceDetails(count, type, price, cost);
            return cost;
        }

        private static void priceDetails(int count, string type, int price, int cost)
        {
            Console.WriteLine();
            Console.WriteLine(count + " drawers at $30/drawer");
            Console.WriteLine("Price of drawers: " + (count * 30).ToString("c0"));
            Console.WriteLine("Price of wood (" + type + "): " + price.ToString("c0"));
            Console.WriteLine();
            Console.Write("Total cost: ");
        }
    }
}
