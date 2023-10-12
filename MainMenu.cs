using basics;
public class MainMenu
{
    // Creates object of MainMenu from other file
    Admin admin = new Admin();
    User user = new User();
    Register Register = new Register();
<<<<<<< Updated upstream
=======
    
>>>>>>> Stashed changes
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
                break;
            }
            else if (choice == "2")
            {
                //user.init();
                user.Login();

                break;
            }
            else if (choice == "3")
            {
                Register.RegisterUser();
<<<<<<< Updated upstream
                break;
=======
                //break;
>>>>>>> Stashed changes
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