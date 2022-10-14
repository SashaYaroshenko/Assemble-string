using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kata.Assemble(new string[0]);
            Kata.Assemble(new string[] { "a*cde", "*bcde", "abc*e" });
        }
    }

    public class Kata
    {
        public static string Assemble(string[] copies)
        {
            if (copies.Length == 0)
            {
                return "";
            }
            else
            {
                int len = copies[0].Length; // I don't now why it`s right length
                char[] charsResult = new char[len];
                charsResult = charsResult.Select(x => x = '*').ToArray();

                for (int i = 0; i < len; i++)
                {
                    for (int j = 0; j < copies.Length; j++)
                    {
                        if (copies[j][i] != '*')
                        {
                            charsResult[i] = copies[j][i];
                            break;
                        }
                    }
                    if (charsResult[i] == '*') charsResult[i] = '#';
                }

                return new string(charsResult);
            }
        }
    }

}

