using System.IO;
using System.Xml.Linq;
using test33;
public class manager
{
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

            using (StreamWriter sw = File.AppendText("D:\\siktergit\\test33\\users.csv"))
            {

                sw.WriteLine(userinputname + ";" + passwordinput);
            }
            break;
        }
        return true;

    }
    public bool usernameExists(string username)
    {
        if (loginlist.ContainsKey(username))
        {
            return true;
        }
        return false;
    }
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
    public void init()
    {
        string[] filen = File.ReadAllLines("D:\\siktergit\\test33\\users.csv");


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

    private Dictionary<string, string> loginlist = new Dictionary<string, string>();


}