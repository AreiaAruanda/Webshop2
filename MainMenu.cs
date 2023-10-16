using basics;
public class MainMenu
{
    // Creates object of MainMenu from other file
    Admin admin = new Admin();
    User user = new User();
    Register Register = new Register();
    
    public void mainMenu()
    {
        while (true)
        {
            Console.WriteLine("Welcome to the store system!");
            Console.WriteLine("1. Log in as Admin");
            Console.WriteLine("2. Log in as Customer");
            Console.WriteLine("3. Register New Customer");
            Console.WriteLine("4. Exit");

            string? choice = (Console.ReadLine());

            if (choice == "1")
            {
                admin.AdminMenu();
                continue;
            }
            else if (choice == "2")
            {
                //user.init();
                user.Login();
                continue;
            }
            else if (choice == "3")
            {
                Register.RegisterUser();
                continue;
            }
            else if (choice == "4")
            {
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