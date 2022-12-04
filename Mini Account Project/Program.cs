using Service.Services;
using Service.Services.Interfaces;
using System;

namespace Mini_Account_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the email:");
            string email = Console.ReadLine();

            Console.WriteLine("enter the password:");
            string password = Console.ReadLine();

            int role = 0;

            IAccount account = new Account();
            Console.WriteLine(account.Login(email, password, role)); 
            
        }
    }
}
