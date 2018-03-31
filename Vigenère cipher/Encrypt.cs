using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vigenère_cipher
{
    static class Encrypt
    {
        static public string ProcessString(string a, string b)
        {
            string EncryptedString = processString(a, b);
            return EncryptedString;
        }

        static private string processString(string w, string p)
        {
            string word = w.ToUpper();
            string phrase = p.ToUpper();

            char[] wordArray = word.ToCharArray();
            char[] phraseArray = phrase.ToCharArray();

            int wordInt = wordArray.Length;
            int phraseInt = phraseArray.Length;

            int x = 0;
            int y = 0;
            string encodedPhrase = ("");

            char[][] Grid = CipherGrid.Initialize();
            
            for (int i = 0; i < phraseInt; i++)
            {
                char wordChar = wordArray[x];
                char phraseChar = phraseArray[y];

                int wordCharInt = wordChar - 65;
                int phraseCharInt = phraseChar - 65;

                char encode = Grid[wordCharInt][phraseCharInt];

                encodedPhrase += ($"{encode}");

                x++;
                y++;

                if (x == wordInt) { x = 0; }
            }
            string extra = ("difficult");
            string encodedPhrase2 = processString2(extra, encodedPhrase);
            return encodedPhrase2;
        }

        static private string processString2(string w, string p)
        {
            string word = w.ToUpper();
            string phrase = p.ToUpper();

            char[] wordArray = word.ToCharArray();
            char[] phraseArray = phrase.ToCharArray();

            int wordInt = wordArray.Length;
            int phraseInt = phraseArray.Length;

            int x = 0;
            int y = 0;
            string encodedPhrase = ("");

            char[][] Grid = CipherGrid.Initialize2();

            for (int i = 0; i < phraseInt; i++)
            {
                char wordChar = wordArray[x];
                char phraseChar = phraseArray[y];

                int wordCharInt = wordChar - 65;
                int phraseCharInt = phraseChar - 65;

                char encode = Grid[wordCharInt][phraseCharInt];

                encodedPhrase += ($"{encode}");

                x++;
                y++;

                if (x == wordInt) { x = 0; }
            }

            return encodedPhrase;
        }

    }
}
