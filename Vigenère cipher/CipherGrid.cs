using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vigenère_cipher
{
    static class CipherGrid
    {
        //Calls private grid generation
        public static char[][] Initialize()
        {
            char[][] CipherGrid = drawCipherGrid();
            return CipherGrid;
        }

        //Generates a standard Vigenere Cipher grid
        private static char[][] drawCipherGrid()
        {
            //Initializes empty grid with 26 rows
            char[][] grid = new char[26][];
            try
            {
                int n = 0;
                char[] code = new char[26];

                //Assigns each row it's respective array
                for (int i = 0; i < 26; i++)
                {
                    //Calls for a generated array
                    code = charGen(n);
                    grid[n] = code;

                    //Changes array's starting character + next row
                    n++;
                }
            }
            catch
            {
                throw new Exception("drawCipherGrid");
            }

            //Returns completed grid
            return grid;
        }

        //Retreves array of characters based on {int x}
        private static char[] charGen(int x)
        {
            char[] arrayChar = new char[26];

            if (x > 0 || x < 27) //<-- Accounts for array starting at a different letter. (I.E. {B,C,D...Z,A})
            {
                arrayChar = charAlphabet(x); //<-- Calls for array
            }
            else  
            {
                x = 1;
                arrayChar = charAlphabet(x);
            }

            return arrayChar; 
        }

        //Generates array of characters, starting character based on {int x}
        private static char[] charAlphabet(int x) 
        {
            char[] arrayChar = new char[26];

            //Interprets X to it's int/char equivalent
            int c = x + 65;

            //Loops through array for each character 
            for (int i = 0; i < 26; i++)
            {
                //If character would go out of bounds, resets at 65(A) and adds character to array
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


        //Calls private grid generation for reverse grid
        public static char[][] Initialize2()
        {
            char[][] CipherGrid = drawCipherGrid2();
            return CipherGrid;
        }

        //Reverse grid generation
        private static char[][] drawCipherGrid2()
        {
            //Initializes empty grid with 26 rows
            char[][] grid = new char[26][];
            try
            {
                //Sets starting letter to Z(25)
                int n = 25;
                int p = 0;

                //Initializes array of 26 characters
                char[] code = new char[26];

                //Adds each array to master grid
                for (int i = 0; i < 26; i++)
                {
                    //Calls for generated array
                    code = charGen2(n);
                    grid[p] = code;

                    //Assigns next grid and next character(character in reverse order)
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

        //Retreves array of characters based on {int x}
        private static char[] charGen2(int x)
        {
            char[] arrayChar = new char[26];

            if (x > 0 || x < 27) //<-- Accounts for array starting at a different letter. (I.E. {B,C,D...Z,A})
            {
                arrayChar = charAlphabet2(x); //<-- Calls for reverse array
            }
            else
            {
                x = 1;
                arrayChar = charAlphabet2(x);
            }
            return arrayChar;
        }

        //Generates reverse array of characters, starting character based on {int x}
        private static char[] charAlphabet2(int x)
        {
            char[] arrayChar = new char[26];

            //Interprets X to it's int/char equivalent
            int c = x + 65;

            //Loops through array for each character 
            for (int i = 0; i < 26; i++)
            {
                //If character would go out of bounds, resets at 90(Z) and adds character to array
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
