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
            string word;
            while (i < str.Length)
            {
                word = str.Substring(i, str.IndexOf(delim, i) - i);
                if (word != "")
                {
                    list.Add(word);
                    i = str.IndexOf(delim, i);
                }
                else
                    i++;
                
            }
            return list;
        }
        //1 2 3 4 5 6
        //5 5 7 8 9 0
        public static string Find(string str1,string str2,string delim)
        {
            if (delim == null)
                delim = " ";
            List<string> list1 = Split(str1, delim);
            List<string> list2 = Split(str2, delim);

            for (int i = 0; i < list1.Count; i++)
            {
                for (int j = 0; j < list2.Count; j++)
                {
                    
                }
            }

            String Output="";
            foreach (string str in list1)
            {
                Output = Output + "<tr><td>"+str + "</td></tr> ";
            }
            Output = "<table>" + Output + "</table>";
            return Output;
        }
    }
}
