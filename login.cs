using System.IO;
using System.Xml.Linq;
public class manager
{
    // Register new user
    public bool register()
    {
        string? passwordinput;
        while (true)
        {
            Console.WriteLine("Please enter your username");
            string userinputname = Console.ReadLine();
            if (usernameExists(userinputname))
            {
                Console.Clear();
                Console.WriteLine("Username already exists");
                continue;
            }
            while (true)
            {
                Console.WriteLine("Please enter your password");
                passwordinput = Console.ReadLine();

                if (passwordinput == "")
                {
                    Console.WriteLine("No empty password");
                    continue;

                }
                break;
            }
            Console.WriteLine(userinputname + " Sucessfully created new user");
            loginlist.Add(userinputname, passwordinput);
            // Adds the user to the CSV file
            using (StreamWriter sw = File.AppendText("../../../users.csv"))
            {

                sw.WriteLine(userinputname + ";" + passwordinput);
            }
            break;
        }
        return true;

    }
    // Checks for duplicate usernames
    public bool usernameExists(string username)
    {
        if (loginlist.ContainsKey(username))
        {
            return true;
        }
        return false;
    }
    // log in function with csv
    public bool login()
    {
        while (true)
        {
            Console.WriteLine("Please enter your username");
            string userinputname = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            string passwordinput = Console.ReadLine();
            if (loginlist.ContainsKey(userinputname) && passwordinput == loginlist[userinputname])
            {

                Console.WriteLine(userinputname + " has logged in");
                break;
            }
            else
            {
                Console.WriteLine("Your credentials do not exist");
                Console.WriteLine("Please try again");
            }
        }
        return true;
    }
    // Dictionary csv for user login and password
    public void init()
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
            loginlist.Add(name2, password2);

        }
    }


    public void loggedinUser()
    {
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("1 / Buy");
        Console.WriteLine("2 / View purchase history");
        Console.WriteLine("3 / View cart");
        Console.WriteLine("4 / Checkout");



        string option2 = Console.ReadLine();
        if (option2 == "1")
        {
            Console.WriteLine("What would you like to buy ? ");
            Console.WriteLine();
            //buy();
        }
        else if (option2 == "2")
        {

        }
        else if (option2 == "3")
        {
            //viewcart();

        }
        else if (option2 == "4" ) {

        }
        else
        {
            Console.Clear();
            Console.WriteLine("Please pick something valid");
            //continue;
        }

    }
    public Dictionary<string, string> loginlist = new Dictionary<string, string>();
}