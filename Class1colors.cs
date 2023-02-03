using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1colors
    {

         public static string Solution(string s)
        {
            String[] ops1 = s.Split(" ");

            List<int> list = new List<int>();
            List<string> list2 = new List<string>();
            Dictionary<int, string> dict = new Dictionary<int, string>();
            foreach (string op in ops1)
            {
                int c= int.Parse(op.Substring(op.Length-1));
                string str = op.Replace(c.ToString(), String.Empty);
                dict.Add(c, str);
            }

            SortedDictionary<int, string> dict2 =  new SortedDictionary<int, string>(dict);
            foreach(var val in dict2.Values)
            {
                list2.Add(val);
            }
  
            string result = "";
            foreach (string i in list2)
            {
                result+=i+" ";
            }

            return result.Remove(result.Length-1);
        }

       /* public static void Main()
        {
            // string str = "@Hello, World.";
            /*string str = "Tentative of peace";
            //List<char> charsToRemove = new List<char>() { '@', '_', ',', '.' };
            List<char> charsToRemove = new List<char>() { 'a', 'e' };

            str = str.Filter(charsToRemove);
            string stre = "@Hello, World.";
            String ops = "balck2 white1 red3";
            Console.WriteLine("Input: " + ops);
            Console.WriteLine("Output: " + Solution(ops));
        }*/
    }
}
