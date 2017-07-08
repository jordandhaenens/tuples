using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();
            transactions.Add(("Yo-yo", 9.94, 1));
            transactions.Add(("screw", 0.0214, 100));
            transactions.Add(("hammer", 19.95, 3));
            transactions.Add(("Tape Measure", 9.95, 5));
            transactions.Add(("bullfrog", 6.00, 1));
            
            double total = 0.0;
            int qty = 0;
            foreach((string product, double amount, int quantity) t in transactions){
                total = total + (t.quantity * t.amount);
                qty = qty + t.quantity;
            }
            Console.WriteLine($"Total inv moved is {qty} items");
            Console.WriteLine($"Revenue for day is {total}");
        }
    }
}
