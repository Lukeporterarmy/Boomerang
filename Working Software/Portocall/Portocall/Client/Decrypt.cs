using System;
using System.Collections.Generic;
using System.Text;

namespace Portocall
{
    class Decrypt
    {
        static int stop;
        public char[] RemoveSharedLayer1(char[] data)
        {
            char[] localchar = new char[data.Length];

            int i = 0;

            foreach (char character in data)
            {
                if(character.ToString() == ",")
                {
                    stop = i;
                }
                localchar[i] = character;
                i++;
            }

            string previous = "";
            int i2 = 0;
            for (; i2 < localchar.Length; i2++)
            {
                if (localchar[i2].ToString() == previous)
                {
                    if (localchar[i2].ToString() == "a")
                    {
                        localchar[i2] = Convert.ToChar("o");
                    }
                }
                else
                {
                    if (localchar[i2].ToString() == "I")
                    {
                        localchar[i2] = Convert.ToChar("L");
                    }
                    if (localchar[i2].ToString() == "O")
                    {
                        localchar[i2] = Convert.ToChar("C");
                    }
                    if (localchar[i2].ToString() == "T")
                    {
                        localchar[i2] = Convert.ToChar("K");
                    }

                    if (localchar[i2].ToString() == "A")
                    {
                        localchar[i2] = Convert.ToChar("W");
                    }
                    if (localchar[i2].ToString() == "X")
                    {
                        localchar[i2] = Convert.ToChar("o");
                    }
                }
                previous = Convert.ToString(localchar[i2]);
            }
            return localchar;
        }






// delete this eventually


        public char[] RemovePrivateLayer2(char[] local, int privateKey)
        {
            char[] localchar = new char[local.Length];
            localchar = local;
            int param1 = 0;
            int param2 = privateKey;
            char temp;

            do
            {
                for (; param1 < localchar.Length && param1 < param2; param2 += privateKey + 1, param1 += privateKey + 1)
                {
                    if (param1 == stop || param2 == stop)
                    {
                        param1 = localchar.Length;
                        param2 = param1;
                    }
                    if (param2 < localchar.Length)
                    {

                        for (int j = param1 + 1; j < param1 + 2; j++)
                        {
                            if (j == stop || j + 1 == stop)
                            {
                                param1 = localchar.Length;
                                param2 = param1;
                            }
                            else
                            {
                                temp = localchar[j + 1];
                                localchar[j + 1] = localchar[j];
                                localchar[j] = temp;
                            }
                        }
                    }
                }
            } while (param1 < localchar.Length);

            return localchar;
        }
    }
}
