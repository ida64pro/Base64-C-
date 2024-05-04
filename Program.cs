using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        // Create function to hashing in base64
        public static string CreateBase64(string input)
        {
            // Standart convert method
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(input));
        }
        static void Main(string[] args)
        {
            // This example on an authorization system
            string password = "emFjYWRpbA=="; // this is base64 hash, decode string "zacadil"
            Console.WriteLine("Добро пожаловать в мой новый кряк ми!");
            // infinitely cycle
            for (;;)
            {
                // ask enter password
                Console.Write("Введите пароль: ");
                // write in variable
                string enterPassword = Console.ReadLine();
                // if, password (hashed) != string enterPassword(hashed)
                // go at line 33 and show in console "Password incorrect".
                // if it == go at 37 line and show password correct
                if (password != CreateBase64(enterPassword))
                {
                    Console.WriteLine("Неверный пароль.");
                }
                else
                {
                    // show password correct and break cycle
                    Console.WriteLine("Верный пароль.");
                    break;
                }
            }
        }
    }
}
