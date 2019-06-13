
/*
 Name=Priyanka Dhakal
 Student ID=30001935
 */
 using System;

namespace LoginSystem
{
    class Program
    {
        //static variable for error displaying
        static int error = 0;
        static void Main(string[] args)
        {
            //displaying welcome message
            Console.WriteLine("Login System - Rotorua Thermal Holiday Park - Prototype \n");

            //fields to store values
            string username;
            string pass;
            string reppass;

            //loop unitl user enters valid username
            do
            {
                //check if error needs to be shown.
                if (error == 1)
                {
                    Console.WriteLine("Username needs to be 8 charachters long.\n");
                }
                Console.Write("Username: ");
                //accept username
                username = Console.ReadLine();
            }
            //check if username is valid
            while (!UsernameIsValid(username));

            //loop until user enters valid passwords
            do
            {
                //for error showing
                if (error == 1)
                {
                    Console.WriteLine("Passwords needs to be 8 charachters long and should be exactly same.");
                }
                Console.Write("\nPassword: ");
                //accepting first password
                pass = Console.ReadLine();

                Console.Write("Repeat Password: ");
                //accepting second password
                reppass = Console.ReadLine();

            }
            //checking if passwords are valid
            while (!PasswordsAreValid(pass, reppass));

            //display okay message
            Console.WriteLine("\nUsername and Password have been accepted and set.");

            Console.ReadKey();
        }

       
        private static bool PasswordsAreValid(string pass, string reppass)
        {
            //check passwords are same and length is more than 8
            if (pass == reppass && pass.Length >= 8)
            {
                //setting no error
                error = 0;
                return true;
            }
            else
            {
                //setting to show error
                error = 1;
                return false;
            }
        }

        
        private static bool UsernameIsValid(string username)
        {
            //check username length
            if (username.Length >= 8)
            {
                //set error to 0 for no error
                error = 0;
                return true;
            }
            else
            {
                //set error to 1 to show error
                error = 1;
                return false;
            }
        }
    }
}
