string[] filen = File.ReadAllLines("users.csv");
String name;
String password;
Dictionary<string, string> loginlist = new Dictionary<string, string>();

foreach (string line in filen)
{
    filen = line.Split(';');
    string name2 = filen[0];
    string password2 = filen[1];
    loginlist.Add(name2, password2);
}
 while  (true) {
    Console.WriteLine("Please enter your username");
    string userinputname = Console.ReadLine();
    Console.WriteLine("Please enter your password");
    string passwordinput = Console.ReadLine();


     if (loginlist.ContainsKey(userinputname) && passwordinput == loginlist[userinputname])
        {

            Console.WriteLine(userinputname+ " has logged in");

        break;
    }
    else
    {
        Console.WriteLine("Your credentials do not exist");
        Console.WriteLine("Please try again");
            
            
    }
}
 

