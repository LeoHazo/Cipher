using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{
    class Cipher
    {
        private string Alphabet =  "abcdefghijklmnopqrstuvwxyz";
        private string Subsitute = "qwertyuiopasdfghjklzxcvbnm";

        public Cipher()
        {

        }

        public string Encrypt(string messageToEncrypt)
        {
            //TODO Create a variable to store the resulting encrypted message and give it a blank initial value
            string encryptedMessage = "";

            /* TODO Create a loop that traverses through every character in the message you want to encrypt
              In the body of the loop ( between the { and } ) perform the following:
              1- find the index location of the current character in the Alphabet string and save it to a variable
              2- Using the index you found retrieve the subsitution charachter from Subsitute and save it to a variable
              3- Concatenate the value of the variable in step 2 to the first variable you created to save the encrypted message
            */
            foreach (char c in messageToEncrypt)
            {

                var alphabetIndex = Alphabet.IndexOf(c);
                var subsituteChar = Subsitute[alphabetIndex];
                encryptedMessage = encryptedMessage + subsituteChar;

            }
            return encryptedMessage;
        }

        public string Decrypt(string messageToDecrypt)
        {
            //TODO perform the opposite subsitution of Encrypt

            string decryptedMessage = "";
            foreach (char c in messageToDecrypt)
            {

                var subsituteIndex = Subsitute.IndexOf(c);
                decryptedMessage += Alphabet[subsituteIndex];

            }
            return decryptedMessage;
        }
    }
}
