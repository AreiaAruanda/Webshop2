using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace basics;

public class User
{
    ViewHistory viewHistory = new ViewHistory();

    public Dictionary<string, string> loginlistUser = new Dictionary<string, string>();
    // Dictionary csv for user login and password
    public void Init()
    {
        string[] filen = File.ReadAllLines("../../../users.csv");

        foreach (string line in filen)
        {
            if (line == "")
            {
                continue;
            }
            filen = line.Split(';');
            string name2 = filen[0];
            string password2 = filen[1];
            loginlistUser.Add(name2, password2);
        }
    }
    string? realusername;
    public bool Login()
    {
        Init();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Please enter your username");
            string userinputname = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            string passwordinput = Console.ReadLine();
            if (loginlistUser.ContainsKey(userinputname) && passwordinput == loginlistUser[userinputname])
            {
                realusername = userinputname;
                Console.WriteLine(userinputname + " has logged in");
                Console.Clear();
                UserLoggedin();
                break;
            }
            else
            {
                Console.WriteLine("Your credentials do not exist");
                Console.WriteLine("Please try again");
                Console.ReadKey();
            }
        }
        return true;
    }
    List<Product> shoppingList = new List<Product>();

    public void UserLoggedin()
    {
        while (true)
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1 / Buy items");
            Console.WriteLine("2 / View purchase history");
            Console.WriteLine("3 / View cart");
            Console.WriteLine("4 / Checkout");
            string userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                Console.Clear();
                Products.ShopItems(ref shoppingList);
            }
            else if (userChoice == "2")
            {
                Console.Clear();
                Console.WriteLine(realusername + " Buyhistory:\n");

                viewHistory.ViewBuyHistory(realusername);

                Console.ReadKey();
                Console.Clear();
            }
            else if (userChoice == "3")
            {
                Console.Clear();
                Console.WriteLine("Cart contains: \n");
                for (int i = 0; i < shoppingList.Count; i++)
                {
                    Console.WriteLine(shoppingList[i].name + " " + shoppingList[i].price);
                }
                Console.ReadKey();
                Console.Clear();
            }
            else if (userChoice == "4")
            {
                float totalAmount = 0;
                using (StreamWriter sw = File.AppendText("../../../buyHistory.csv"))
                {
                    for (int i = 0; i < shoppingList.Count; i++)
                    {
                        totalAmount += shoppingList[i].price;
                        sw.WriteLine(realusername + ";" + shoppingList[i].name + ";" + shoppingList[i].price + ";" + DateTime.Now.ToString());
                    }
                }
                Console.Clear();
                Console.WriteLine("Your purchase was successful! Total amount paid: " + totalAmount + "$");
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Pick something valid");
                continue;
            }
        }
    }
}
