/*
 * Programming 101 - Fall 2021
 * Code By : Leo Hazou
 * Date: 10/16/2021
 * Group #
 * Members:
 * */


using System;


namespace Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Simple Cipher Encryption/Decryption";

            Cipher cipher = new Cipher();
            string choice = "";
            string message;

            while (choice != "3")
            {

                Console.WriteLine(""); // This just prints a blank line to make the text less congested
                Console.WriteLine($"Welcome 007! Do you need to Encrypt or Decrypt a secret message?");
                Console.WriteLine($"1- Encrypt");
                Console.WriteLine($"2- Decrypt");
                Console.WriteLine($"3- Exit");
                Console.Write($"Enter your choice: ");

                choice = Console.ReadLine();

                //TODO Use a switch statement on the variable 'choice' to perform the appropriate action depending on input
                //Hint: Your default action should let the user know that they entered the wrong choice
                
                // <<<<< Start code here >>>>>
            }

            Console.ReadKey();
        }
    }
}
