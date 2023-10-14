using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace basics;
public struct Product
{
    public string price;
    public string name;
}
public class Products
{
    List<Product> productList = new List<Product>();

    public void ReadProducts()
    {
        string[] filen = File.ReadAllLines("../../../products.csv");
        string productname = string.Empty;

        foreach (string line in filen)
        {
            if (line == "")
            {
                continue;
            }
            filen = line.Split(';');
            productname = filen[0];
            string productprice = filen[1];
            productList.Add(new Product
            {
                price = productprice,
                name = productname
            });
            //productList.Add(productname);

            //Console.WriteLine($"{productname} kostar {productprice} SEK");
        }
    }
    public void ShopItems(ref List<Product> shoppinglist)
    {
        while (true)
        {
            Console.WriteLine("What would you like to buy? \n");

            for (int i = 0; i < productList.Count; i++)
            {
                Console.WriteLine(productList[i].name + " kostar" + " " + productList[i].price + " SEK ");

            }
            Console.WriteLine();
            Console.WriteLine("Press 0 to go back to menu");

            string userpick = Console.ReadLine();
            bool validitem = false;
            for (int i = 0; i < productList.Count; i++)
            {

                if (userpick == productList[i].name)
                {
                    Console.Clear();
                    Console.WriteLine("You picked " + productList[i].name);
                    Console.WriteLine("Press enter to proceed");
                    Console.ReadKey();
                    Console.Clear();
                    validitem = true;
                    shoppinglist.Add(productList[i]);
                    continue;

                }
            }
            if (userpick == "0")
            {
                Console.Clear();
                break;
            }
            if (!validitem)
            {
                Console.Clear();
                Console.WriteLine("Invalid item, try again ");
                Console.ReadKey();
                Console.Clear();
                continue;
            }
        }
    }
    /*while (true) { 
        Console.WriteLine("What would you like to buy? ");
        Console.WriteLine($"{productname} kostar {productprice} SEK");

        string userBuyItem = Console.ReadLine();

        if (userBuyItem==productname)
        {
            Console.WriteLine("You picked" + productname);
                break;
        } 
        else
        {
            Console.WriteLine("Item not valid");
                continue;
        }
      */
}
