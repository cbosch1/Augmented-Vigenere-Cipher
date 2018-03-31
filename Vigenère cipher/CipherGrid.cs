using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vigenère_cipher
{
    static class CipherGrid
    {
        public static char[][] Initialize()
        {
            char[][] CipherGrid = drawCipherGrid();
            return CipherGrid;
        }

        private static char[][] drawCipherGrid()
        {
            char[][] grid = new char[26][];
            try
            {
                int n = 0;
                char[] code = new char[26];
                for (int i = 0; i < 26; i++)
                {
                    code = charGen(n);
                    grid[n] = code;
                    n++;
                }
            }
            catch
            {
                throw new Exception("drawCipherGrid");
            }

            return grid;
        }

        private static char[] charGen(int x)
        {
            char[] arrayChar = new char[26];
            if (x >= 1 || x <= 26)
            {
                arrayChar = charAlphabet(x);
            }
            else
            {
                x = 1;
                arrayChar = charAlphabet(x);
            }
            return arrayChar;
        }

        private static char[] charAlphabet(int x)
        {
            char[] arrayChar = new char[26];
            int c = x + 65;
            for (int i = 0; i < 26; i++)
            {
                if (c >= 91 || c <= 64)
                {
                    c = 65;
                    char digit = Convert.ToChar(c);
                    arrayChar[i] = digit;
                    c++;
                }
                else
                {
                    char digit = Convert.ToChar(c);
                    arrayChar[i] = digit;
                    c++;
                }
            }
            return arrayChar;
        }

        public static char[][] Initialize2()
        {
            char[][] CipherGrid = drawCipherGrid2();
            return CipherGrid;
        }

        private static char[][] drawCipherGrid2()
        {
            char[][] grid = new char[26][];
            try
            {
                int n = 25;
                int p = 0;
                char[] code = new char[26];
                for (int i = 0; i < 26; i++)
                {
                    code = charGen2(n);
                    grid[p] = code;
                    n--;
                    p++;
                }
            }
            catch
            {
                throw new Exception("drawCipherGrid2");
            }

            return grid;
        }

        private static char[] charGen2(int x)
        {
            char[] arrayChar = new char[26];
            if (x >= 1 || x <= 26)
            {
                arrayChar = charAlphabet2(x);
            }
            else
            {
                x = 1;
                arrayChar = charAlphabet2(x);
            }
            return arrayChar;
        }

        private static char[] charAlphabet2(int x)
        {
            char[] arrayChar = new char[26];
            int c = x + 65;
            for (int i = 0; i < 26; i++)
            {
                if (c >= 91 || c <= 64)
                {
                    c = 90;
                    char digit = Convert.ToChar(c);
                    arrayChar[i] = digit;
                    c--;
                }
                else
                {
                    char digit = Convert.ToChar(c);
                    arrayChar[i] = digit;
                    c--;
                }
            }
            return arrayChar;
        }



    }
}
