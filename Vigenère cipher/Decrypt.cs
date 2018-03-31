using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vigenère_cipher
{
    class Decrypt
    {
        static public string ProcessString(string a, string b)
        {
            string DecryptedString = processString(a, b);
            return DecryptedString;
        }

        static private string processString(string w, string p)
        {
            //Calls 2nd level decryption method
            string extra = ("difficult");
            string decodedPhrase2 = processString2(extra, p);

            //Input to uppercase
            string word = w.ToUpper();
            string phrase = decodedPhrase2.ToUpper();

            //Input to array
            char[] wordArray = word.ToCharArray();
            char[] phraseArray = phrase.ToCharArray();

            //Defines array length
            int wordInt = wordArray.Length;
            int phraseInt = phraseArray.Length;

            //Initializes variables
            int x = 0;
            int y = 0;
            string decodedPhrase = ("");

            //Initializes code grid
            char[][] Grid = CipherGrid.Initialize();

            //Decryption starts
            for (int i = 0; i < phraseInt; i++)
            {
                int decodeInt;

                //Picks out the next character
                char wordChar = wordArray[x];
                char phraseChar = phraseArray[y];

                //Sets character to numerical value (0-25)
                int wordCharInt = wordChar - 65;
                int phraseCharInt = phraseChar - 65;

                //Finds encrypted character's decryption address
                if (wordCharInt > phraseCharInt)
                {
                    decodeInt = (26 - wordCharInt) + phraseCharInt;
                }
                else if (wordCharInt <= phraseCharInt)
                {
                    decodeInt = phraseCharInt - wordCharInt;
                }
                else
                {
                    Console.WriteLine("An error occured!");
                    break;
                }

                //Add's decrypted character to output string
                char decode = Grid[0][decodeInt];
                decodedPhrase += ($"{decode}");

                x++;
                y++;

                //Repeats code word through encrypted phrase
                if (x == wordInt) { x = 0; }
            }

            return decodedPhrase;

        }

        //2nd level decryption method (goes first)
        static private string processString2(string w, string p)
        {
            //Initial converstions
            string word = w.ToUpper();
            string phrase = p.ToUpper();
            char[] wordArray = word.ToCharArray();
            char[] phraseArray = phrase.ToCharArray();
            int wordInt = wordArray.Length;
            int phraseInt = phraseArray.Length;

            //Set needed variables
            int x = 0;
            int y = 0;
            string decodedPhrase = ("");

            //Initialize Grid
            char[][] Grid = CipherGrid.Initialize2();

            //Finds encrypted character address
            for (int i = 0; i < phraseInt; i++)
            {
                char wordChar = wordArray[x];
                char phraseChar = phraseArray[y];

                int wordCharInt = wordChar - 65;
                int phraseCharInt = phraseChar - 65;

                char decode = Grid[wordCharInt][phraseCharInt];

                //Adds character to phrase
                decodedPhrase += ($"{decode}");

                x++;
                y++;
                
                //Repeats code word through encrypted phrase
                if (x == wordInt) { x = 0; }
            }
            return decodedPhrase;
        }

    }
}
