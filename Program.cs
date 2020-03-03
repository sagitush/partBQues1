using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partb2._3._20
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string> { "java", "jjava", "vaj", "aavj", "j", "vjaa", "dan", "and", "ddan" };
            Words(list1);

        }
        public static void Words(List<string> list)
        {
            string[] newArray = new string[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                char[] charArray = list[i].ToCharArray();

                Array.Sort(charArray);

                newArray[i] = new string(charArray);
            }
            Dictionary<string, int> wordDict = new Dictionary<string, int>();
            for (int i = 0; i < newArray.Length; i++)
            {
                if (wordDict.TryGetValue(newArray[i], out int value))
                {
                    wordDict[newArray[i]] = value + 1;

                }
                else
                {
                    wordDict.Add(newArray[i], 1);
                }
            }
            foreach(var item in wordDict)
            {
                Console.WriteLine($"the word {item.Key} is in the list {item.Value} times");              
            }
        }
    }
}

