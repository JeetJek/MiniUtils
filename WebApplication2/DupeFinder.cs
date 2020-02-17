using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2
{
    public class DupeFinder
    {
        private static List<string> Split(string str, string delim)
        {
            List<string> list = new List<string>();
            int i = 0;
            if (str.LastIndexOf(delim) != str.Length)
            {
                str += delim;
            }
            while (i < str.Length)
            {
                list.Add(str.Substring(i, str.IndexOf(delim,i) - i));
                i=str.IndexOf(delim, i) +delim.Length;
            }
            return list;
        }
        public static string Find(string str1,string str2,string delim)
        {
            if (delim == null)
                delim = " ";
            List<string> list1=Split(str1, delim);
            Console.WriteLine();
            List<String> list = new List<string>();
            list.Add(list1[0]);
            Console.Write(list1[0] + " ");
            int j2;
            bool have;
            string Output = "";
            for (int i = 1; i < list1.Count; i++)
            {
                j2 = list.Count;
                have = false;
                for (int j = 0; j < j2; j++)
                {
                    if (list1[i] != list[j])
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        have = false;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        have = true;
                        break;
                    }

                }
                if (!have)
                    list.Add(list1[i]);
                Output = Output + "<tr>"+list1[i] + "</tr> ";
            }
            Output = "<table>" + Output + "</table>";
            return Output;
        }
    }
}
