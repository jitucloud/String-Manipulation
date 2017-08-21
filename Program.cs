using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartA
{
    class Program
    {
        /// <summary>
        /// Reverse a string without using inbuilt methods
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            String sentence = "cat; and dog";
            StringBuilder sb = new StringBuilder();
            char[] msg = sentence.ToCharArray();

            int i = 0, j = 0;
            int stringLength = FindStringLength(sentence);

            char[] str = new char[stringLength];
            while (i <= stringLength)
            {
                if (i == stringLength)
                {
                    sb.Append(ReverseGivenWord(str));
                }
                else if (msg[i] != ' ')
                {
                    str[j] = msg[i];
                    j++;
                }
                else
                {
                    str[j] = ' ';
                    sb.Append(ReverseGivenWord(str) + ' ');
                    j = 0;
                }
                i++;
            }
            Console.WriteLine(sb.ToString().Trim());
            Console.ReadLine();
        }

        /// <summary>
        /// Reverse given word
        /// </summary>
        /// <param name="word"></param>
        /// <returns>String</returns>
        public static string ReverseGivenWord(char[] word)
        {
            char[] text = word;
            string reverse = string.Empty;
            foreach (char ch in text)
            {
                if (ch != '\0')
                {
                    reverse = ch + reverse;
                }
            }
            return reverse.ToString().Trim();

        }
        /// <summary>
        /// Find length of String
        /// </summary>
        /// <param name="str"></param>
        /// <returns>Int</returns>
        public static int FindStringLength(String str)
        {
            int numberOfLetters = 0;
            foreach (var c in str)
            {
                numberOfLetters++;
            }
            return numberOfLetters;
        }
    }
}
