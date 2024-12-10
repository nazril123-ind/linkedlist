using System;
using System.Collections.Generic;
namespace Project03_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {
 "Konbu", "Tofu",
 "Pavlova", "Chocolate",
 "Ikura" };
            LinkedList<string> list =
            new LinkedList<string>(words);

            Console.WriteLine("Enter product to find:");
            Console.WriteLine(
            "Type <end> to end the program");
            string searchText = Console.ReadLine();
            while (searchText != "<end>")
            {
                if (list.Contains(searchText))
                {
                    Console.WriteLine(
                    "The search text was found");
                }
                else
                {
                    Console.WriteLine(
                    "The search text was NOT found");
                }
                Console.WriteLine("Enter product to find:");
                Console.WriteLine(
                "Type <end> to end the program\n");
                searchText = Console.ReadLine();
            }
        }
    }
}