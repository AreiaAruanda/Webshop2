using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics;

public class Admin
{
    public void AdminMenu()
    {
        Console.WriteLine("Log in as Admin");

        while (true)
        {
            Console.WriteLine("Enter the password");
            string adminpswd = Console.ReadLine();

            if (adminpswd == "123")
            {
                Console.WriteLine("Admin has logged in");
                Console.WriteLine("Admin Menu:");
                Console.WriteLine("1. Add product");
                Console.WriteLine("2. Remove product");
                Console.WriteLine("3. View and edit customer information");
                Console.WriteLine("4. Overview of orders and transactions");
                Console.WriteLine("5. Log out");
                break;
            }
            else
            {
                Console.WriteLine("The password was wrong");
                continue;
            }
        }
    }
}
