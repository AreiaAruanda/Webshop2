namespace test33;
enum fadisenum
{
    login
}
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
                managerinstance.login();

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