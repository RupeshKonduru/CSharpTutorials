using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicalPrograms
{
    class CharacterOccurance
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the string : ");
            string message = Console.ReadLine();
            //Remove the empty spaces from the message
            message = message.Replace(" ", string.Empty);

            while (message.Length > 0)
            {
                Console.Write(message[0] + " : ");
                int count = 0;
                for (int j = 0; j < message.Length; j++)
                {
                    if (message[0] == message[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                message = message.Replace(message[0].ToString(), string.Empty);
            }

            //Method 2
            Console.Write("Enter the string : ");
            string msg = Console.ReadLine();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char ch in msg.Replace(" ", string.Empty))
            {
                if (dict.ContainsKey(ch))
                {
                    dict[ch] = dict[ch] + 1;
                }
                else
                {
                    dict.Add(ch, 1);
                }
            }
            foreach (var item in dict.Keys)
            {
                Console.WriteLine(item + " : " + dict[item]);
            }

            //Method 3
            Console.Write("Enter the string : ");
            string messageEx = Console.ReadLine();
            Dictionary<char, int> dicton = messageEx.Replace(" ", string.Empty)
                                         .GroupBy(c => c)
                                         .ToDictionary(gr => gr.Key, gr => gr.Count());
            foreach (var item in dicton.Keys)
            {
                Console.WriteLine(item + " : " + dict[item]);
            }

            Console.ReadKey();
        }
    }
}
