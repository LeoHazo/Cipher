/*
 * Programming 101 - Fall 2021
 * Code By : Leo Hazou
 * Date: 10/16/2021
 * Group #
 * Members:
 * */


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
            //Create a variable to store the resulting encrypted message and give it a blank initial value
            string encryptedMessage = "";

            /* TODO Create a loop that traverses through every character in the message you want to encrypt
              In the body of the loop ( between the { and } ) perform the following:
              1- find the index location of the current character in the Alphabet string and save it to a variable
              2- Using the index you found retrieve the substitution character from Substitute and save it to a variable
              3- Concatenate the value of the variable in step 2 to the first variable you created to save the encrypted message
            */
            
            // >>>>> Start code here <<<<<


            return encryptedMessage;
        }

        public string Decrypt(string messageToDecrypt)
        {
           
            //Create a variable to store the resulting decrypted message and give it a blank initial value
            string decryptedMessage = "";

            //TODO perform the opposite substitution of Encrypt

            // >>>>> Start code here <<<<< 
            
            return decryptedMessage;
        }
    }
}
