using System;
using System.Globalization;
using Course.Entities;
using Course.Entities.Enum;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");

        }
    }
}
