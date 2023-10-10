
public class Program2
{
    static void Main(string[] args)
    {
        manager managerinstance = new manager();
        managerinstance.init();

        while (true)
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1 / Login");
            Console.WriteLine("2 / Sign up new user");
            string option = Console.ReadLine();
            if (option == "1")
            {
                // Log in function
                managerinstance.login();
                Console.Clear();
                managerinstance.loggedinUser(); 

            }
            else if (option == "2")
            {
                managerinstance.register();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please pick 1 or 2");
                continue;
            }
            break;

        }

    }

}