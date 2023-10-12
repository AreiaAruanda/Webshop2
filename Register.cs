using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
<<<<<<< Updated upstream
    public class Register
    {
=======

    public class Register
    {
        // calls main menu class
         
>>>>>>> Stashed changes
        User user = new User();
        public bool UsernameExists(string username)
        {
            if (user.loginlistUser.ContainsKey(username))
            {
                return true;
            }
            return false;
        }
        public bool RegisterUser()
        {
            user.Init();

            string? passwordinput;
            while (true)
            {
                Console.WriteLine("Please enter your username");
                string userinputname = Console.ReadLine();
                if (UsernameExists(userinputname))
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
                user.loginlistUser.Add(userinputname, passwordinput);
                // Adds the user to the CSV file
                using (StreamWriter sw = File.AppendText("../../../users.csv"))
                {

                    sw.WriteLine(userinputname + ";" + passwordinput);
                }
<<<<<<< Updated upstream
                break;
            }
            return true;
        }
=======
                
                
                break;
            }

            
            return true;
            
        }
        
>>>>>>> Stashed changes
    }
}
