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

        Console.WriteLine("Enter the password");
        string adminpswd = Console.ReadLine();

        if (adminpswd == "123") {
            while (true) {
                Console.WriteLine("Admin has logged in");
                Console.WriteLine("Admin Menu:");
                Console.WriteLine("1. Add product");
                Console.WriteLine("2. Remove product");
                Console.WriteLine("3. View and edit customer information");
                Console.WriteLine("4. Overview of orders and transactions");
                Console.WriteLine("5. Log out");

                string? choice = (Console.ReadLine());

                if (choice == "1") {
                    AddProduct();
                    continue;
                } else if (choice == "2") {
                    RemoveProduct();
                    continue;
                } else if (choice == "3") {
                    continue;
                } else if (choice == "4") {
                    continue;
                } else if (choice == "5") {
                    break;
                } else {
                    continue;
                }
            }
        } else {
            Console.WriteLine("The password was wrong");
        }
    }

    private void AddProduct()
    {
        while (true) {
            Console.WriteLine("You are creating a new product.");
            Console.WriteLine("Enter !exit to exit this mode.");
            Console.Write("Please Enter the product's name: ");
            string name = Console.ReadLine();
            if (name.Length == 0) {
                Console.WriteLine("You have successfully failed to enter a product name.");
                continue;
            }

            if (name == "!exit") {
                return;
            }

            Console.Write("Please Enter the product's price: ");
            float price;
            if (!float.TryParse(Console.ReadLine(), out price)) {
                Console.WriteLine("You have successfully failed to enter a product price.");
                continue;
            }

            Product product = new Product { name = name, price = price };
            Products.RegisterProduct(product);

            Console.WriteLine(product.name + " added to the shop's product list :)");
            break;
        }
    }

    private void RemoveProduct()
    {
        while (true) {
            Console.WriteLine("You are deleting a product.");
            Console.WriteLine("Here's a list of all products.");

            int n = 0;
            foreach (var product in Products.productList) {
                Console.WriteLine((++n).ToString() + ": " + product.name + ", "+ product.price);
            }

            Console.WriteLine("Enter a product's number to remove that product.");
            Console.WriteLine("Enter !exit to exit this mode.");

            string id = Console.ReadLine();
            if (id.Length == 0) {
                Console.WriteLine("You have successfully failed to enter a product number.");
                continue;
            }

            if (id == "!exit") {
                return;
            }

            int intId;
            if (int.TryParse(id, out intId)) {
                Product product = Products.productList[(intId - 1)];
                Products.UnregisterProduct(product);
                Console.WriteLine("You have successfully removed " + product.name + "!");
            }
        }
    }
}

public class Option
{
    public string name;
    public Action action;

    public Option(string name, Action action)
    {
        this.name = name;
        this.action = action;
    }
}