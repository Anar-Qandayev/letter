using System;
using System.Text.RegularExpressions;

namespace Isletter_
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello World";
            char word = 'A';
            Console.WriteLine(HasLetter(text, word));
        }
        static bool HasLetter(string text,char word)
        {
            
            
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == word)
                {
                    return true;
                }
            }
            return false;
        }
    }
}