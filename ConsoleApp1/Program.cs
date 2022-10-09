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
            Kata.Assemble(new string[0]);
        }
    }

    public class Kata
    {
        public static string Assemble(string[] copies)
        {
            
            if (copies.Length==0)
            {
                return "";
            }
            else
            {
                char[] charsResult = new char[copies.Max().Length];
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
                return new string(charsResult);
            }
            
        }
    }
}
