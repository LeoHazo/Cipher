using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{
    class Cipher
    {
        private string Alphabet = "abcdefghijklmnopqrstuvwxyz";
        private string Subsitute = "qwertyuiopasdfghjklzxcvbnm";

        public Cipher()
        {

        }

        public string Encrypt(string message)
        {
            string encryptedMessage = "";
            foreach ( char c in message)
            {
               
                    var alphabetIndex = Alphabet.IndexOf(c);
                    encryptedMessage += Subsitute[alphabetIndex];
                
            }
            return encryptedMessage;
        }

        public string Decrypt(string message)
        {

            string decryptedMessage = "";
            foreach (char c in message)
            {

                var subsituteIndex = Subsitute.IndexOf(c);
                decryptedMessage += Alphabet[subsituteIndex];

            }
            return decryptedMessage;
        }
    }
}
