using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vigenère_cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string Question;
            do
            {
                Console.WriteLine("Encrypt or Decrypt?:");
                Question = Console.ReadLine();
                Question = Question.ToLower();

                //Encryption
                if (Question == ("encrypt") || Question == ("e"))
                {
                    Console.WriteLine("Enter code word:");
                    string CodeWord = Console.ReadLine();

                    //Only letters accepted
                    if (System.Text.RegularExpressions.Regex.IsMatch(CodeWord, @"^[a-zA-Z]+$"))
                    {
                        Console.WriteLine("Enter phrase to encrypt:");
                        string Phrase = Console.ReadLine();

                        //Only letters accepted
                        if (System.Text.RegularExpressions.Regex.IsMatch(Phrase, @"^[a-zA-Z]+$"))
                        {
                            //Encrypts phrase and displays
                            string EncryptedPhrase = Encrypt.ProcessString(CodeWord, Phrase).ToLower();
                            Console.WriteLine($"Your encrypted phrase: {EncryptedPhrase}");
                        }
                        else
                        {
                            Console.WriteLine("Please only use regular letters");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please only use regular letters");
                    }
                }

                //Decryption
                else if (Question == ("decrypt") || Question == ("d"))
                {
                    Console.WriteLine("Enter code word:");
                    string CodeWord = Console.ReadLine();

                    //Only letters accepted
                    if (System.Text.RegularExpressions.Regex.IsMatch(CodeWord, @"^[a-zA-Z]+$"))
                    {
                        Console.WriteLine("Enter phrase to decrypt:");
                        string Phrase = Console.ReadLine();

                        //Only letters accepted
                        if (System.Text.RegularExpressions.Regex.IsMatch(CodeWord, @"^[a-zA-Z]+$"))
                        {
                            //Decrypts phrase and displays
                            string DecryptedPhrase = Decrypt.ProcessString(CodeWord, Phrase).ToLower();
                            Console.WriteLine($"Your decrypted phrase: {DecryptedPhrase}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid format");
                }
            }

            //Loops
            while (
                Question != ("encrypt") ||
                Question != ("e") ||
                Question != ("decrypt") ||
                Question != ("d"));


        }
    }
}
