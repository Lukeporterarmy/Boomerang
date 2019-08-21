using System;
using System.Collections.Generic;
using System.Text;

namespace Portocall
{
    abstract class Conversion
    {
        public static string CharToString(char[] characters)
        {
            string build = "";
            foreach(char character in characters)
            {
                build += character;
            }
            return build;
        }

        public static char[] StringToChar(string s)
        {
            var build = new char[s.Length];
            int i = 0;
            foreach(char character in s)
            {
                build[i] = character;
                i++;
            }
            return build;
        }

        public static string ListToString(List<int> list)
        {
            string build = "";
            foreach(int item in list)
            {
                build += item.ToString();
            }
            return build; 
        }

    }
}
