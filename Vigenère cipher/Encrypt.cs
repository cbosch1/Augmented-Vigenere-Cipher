using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vigenère_cipher
{
    static class Encrypt
    {
        //Calls private decryption method
        static public string ProcessString(string a, string b)
        {
            string EncryptedString = processString(a, b);
            return EncryptedString;
        }

        //Encrypts based on inputed code word and phrase
        static private string processString(string w, string p)
        {
            //Input to uppercase
            string word = w.ToUpper();
            string phrase = p.ToUpper();

            //Input to array
            char[] wordArray = word.ToCharArray();
            char[] phraseArray = phrase.ToCharArray();

            //Defines array length
            int wordInt = wordArray.Length;
            int phraseInt = phraseArray.Length;

            //Initializes variables
            int x = 0;
            int y = 0;
            string encodedPhrase = ("");

            //Initializes code grid
            char[][] Grid = CipherGrid.Initialize();
            
            //Encryption starts
            for (int i = 0; i < phraseInt; i++)
            {
                //Picks out character
                char wordChar = wordArray[x];
                char phraseChar = phraseArray[y];

                //Sets character to numerical value (0-25)
                int wordCharInt = wordChar - 65;
                int phraseCharInt = phraseChar - 65;

                //Finds character's ecrypted equivalent
                char encode = Grid[wordCharInt][phraseCharInt];

                //Adds encrypted character to output string
                encodedPhrase += ($"{encode}");

                //Repeats code word through phrase to encrypt
                x++;
                y++;
                if (x == wordInt) { x = 0; }
            }

            //Initiates 2nd encryption using code word "difficult"
            string extra = ("difficult");
            string encodedPhrase2 = processString2(extra, encodedPhrase);

            //Returns final encrypted phrase to program
            return encodedPhrase2;
        }

        static private string processString2(string w, string p)
        {
            //Input to uppercase
            string word = w.ToUpper();
            string phrase = p.ToUpper();

            //Input to array
            char[] wordArray = word.ToCharArray();
            char[] phraseArray = phrase.ToCharArray();

            //Defines array length
            int wordInt = wordArray.Length;
            int phraseInt = phraseArray.Length;

            //Initializes variables
            int x = 0;
            int y = 0;
            string encodedPhrase = ("");

            //Initializes reverse code grid
            char[][] Grid = CipherGrid.Initialize2();

            //2nd encryption starts
            for (int i = 0; i < phraseInt; i++)
            {
                //Picks out character
                char wordChar = wordArray[x];
                char phraseChar = phraseArray[y];

                //Sets character to numerical value (0-25)
                int wordCharInt = wordChar - 65;
                int phraseCharInt = phraseChar - 65;

                //Finds character's ecrypted equivalent
                char encode = Grid[wordCharInt][phraseCharInt];

                //Adds encrypted character to output string
                encodedPhrase += ($"{encode}");

                //Repeats code word through phrase to encrypt
                x++;
                y++;
                if (x == wordInt) { x = 0; }
            }

            //Returns final phrase to 1st method
            return encodedPhrase;
        }

    }
}
