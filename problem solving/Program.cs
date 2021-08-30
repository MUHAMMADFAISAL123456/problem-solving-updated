using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving
{
    class Program
    {
        static void Main(string[] args)
        {
            removeduplicate("paaaakkisstaan");
            Countcharacter("paaakkisstaan");
            Console.ReadLine();


        }
        internal static void removeduplicate(string str)
        {
            string result = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                int j = 0;
                if(i != 0)
                {
                    j = i - 1;
                }
                
                string storetempvariable = str[j].ToString();

                if(storetempvariable != str[i].ToString())
                {
                    result += str[i];
                }
                    
                
            }
            Console.WriteLine(result);
            
        }
        internal static void Countcharacter(string str)
        {
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            foreach (var character in str)
            {
                if (character != ' ')
                {
                    if (!characterCount.ContainsKey(character))
                    {
                        characterCount.Add(character, 1);
                    }
                    else
                    {
                        characterCount[character]++;
                    }
                }

            }
            foreach (var character in characterCount)
            {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);
            }
        }
    }
}
