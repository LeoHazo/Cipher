using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Simple Cipher Encryption/Decryption";

            Cipher cipher = new Cipher();
            string choice = "";
            string message = "";

            while (choice != "3")
            {

                Console.WriteLine(""); // This just prints a blank line to make the test less cramped
                Console.WriteLine($"Welcome 007! Do you need to Encrypt or Decrypt a secret message?");
                Console.WriteLine($"1- Encrypt");
                Console.WriteLine($"2- Decrypt");
                Console.WriteLine($"3- Exit");
                Console.Write($"Enter your choice: ");

                choice = Console.ReadLine();

                //TODO Use a switch statement on the variable 'choice' to perform the appropriate action depedning on input
                //Hint: Your default action should let the user know that they entered the wrong choice
                switch (choice)
                {
                    case "1":
                        //TODO Get the input form the user
                        Console.Write("Please type your unecrypted message: ");
                        message = Console.ReadLine();

                        //TODO Call the Encrypt method
                        string encyptedMessage = cipher.Encrypt(message.ToLower());

                        //TODO Display the encrypted (or error ) message 
                        //Hint Pass in an all lower case string
                        Console.WriteLine(encyptedMessage);
                        break;

                    case "2":
                        //TDOD Get the input form the user
                        Console.Write("Please type your ecrypted message: ");
                        message = Console.ReadLine();

                        //TODO Call the Decrypt Method
                        //Hint Pass in an all lower case string
                        string decyptedMessage = cipher.Decrypt(message.ToLower());

                        //TODO Display the decrypted (or error ) message 
                        Console.WriteLine(decyptedMessage);

                        break;

                    case "3":
                        Console.WriteLine("Farewell 007!");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice. Please Try again.");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;

                }
            }

            Console.ReadKey();
        }
    }
}
