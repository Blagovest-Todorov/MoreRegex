using System;
using System.Linq;

namespace MoreExersizesString
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] keys = Console.ReadLine()  
                .Split(' ')
                .Select(int.Parse)
                .ToArray();  //read input of keys

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "find")
                {
                    //ToDo
                    break;
                }

                for (int i = 0; i < line.Length; i++)
                {
                   char[] letters = line.ToCharArray();                  
                   char currChar = line[i];
                   

                    if (letters.Length == keys.Length)
                    {
                        int currKeyValue = (int)(keys[i]);
                        int newCurChar = (int)currChar - currKeyValue;
                        letters[i] = (char)newCurChar;
                    }
                    else if (letters.Length > keys.Length)
                    {
                        int currKeyValue = (int)(keys[i % keys.Length]);
                        int newCurChar = (int)currChar - currKeyValue;
                        letters[i] = (char)newCurChar;
                    }

                    Console.WriteLine(string.Join("", letters));
                }

                // 1 2 1 3
                // ikegfp'jpne)bv=41P83X@
                
            }
        }
    }
}
