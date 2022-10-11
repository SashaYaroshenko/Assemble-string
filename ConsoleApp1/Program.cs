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
                int len = copies.Max(x => x.Length);
                char[] charsResult = new char[len];
                for (int i = 0; i < copies.Length; i++)
                {

                    for (int j = 0; j < copies[i].Length; j++)
                    {
                        if (copies[i][j] != '*' && charsResult[j] == 0)
                        {
                            charsResult[j] = (char)copies[i][j];
                        }

                    }
                }
                for (int i = 0; i < charsResult.Length; i++)
                {
                    if (charsResult[i] == '*' || charsResult[i] == 0)
                    {
                        charsResult[i] = '#';
                    }

                }
                for (int i = charsResult.Length - 1; i >= 0; i--)
                {
                    if (charsResult[i] == '*')
                    {
                        charsResult[i] = ' ';
                        continue;
                    }
                    break;
                }
                return new string(charsResult);
            }

        }
    }
}
