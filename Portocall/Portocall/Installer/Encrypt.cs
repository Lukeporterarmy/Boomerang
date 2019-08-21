using System;
using System.Collections.Generic;
using System.Text;

namespace Portocall
{
    class Encrypt
    {
        static int stop;
        public string ApplySharedLayer1(string data)
        {
            char[] localchar = new char[data.Length];

            int i = 0;

            foreach (char character in data)
            {

                localchar[i] = character;
                i++;
            }

            string previous = "";
            int i2 = 0;
            for (; i2 < localchar.Length; i2++)
            {
                if (localchar[i2].ToString() == previous)
                {
                    if (localchar[i2].ToString() == "o")
                    {
                        localchar[i2] = Convert.ToChar("X");
                    }
                }
                else
                {
                    if (localchar[i2].ToString() == "L")
                    {
                        localchar[i2] = Convert.ToChar("I");
                    }
                    if (localchar[i2].ToString() == "C")
                    {
                        localchar[i2] = Convert.ToChar("O");
                    }
                    if (localchar[i2].ToString() == "K")
                    {
                        localchar[i2] = Convert.ToChar("T");
                    }


                    if (localchar[i2].ToString() == "W")
                    {
                        localchar[i2] = Convert.ToChar("A");
                    }
                }
                previous = Convert.ToString(localchar[i2]);
            }
            string build = "";
            foreach (char character in localchar)
            {
                build += character;
            }
            return build;
        }







        public char[] ApplyPrivateLayer2Client(string data, int privateKey)
        {
            string localstring = data;
            char[] localchar = new char[localstring.Length];
            {

                int i = 0;

                foreach (char character in localstring)
                {
                    if (character.ToString() == ",")
                    {
                        stop = i;
                    }
                    localchar[i] = character;
                    i++;
                }
            }
            int LengthofLocal = localchar.Length;
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
                                temp = localchar[j];
                                localchar[j] = localchar[j + 1];
                                localchar[j + 1] = temp;
                            }
                        }
                    }

                }
            } while (param1 < localchar.Length);
            return localchar;

        }

        public char[] ApplyPrivateLayer2Truth(string data, int privateKey)
        {
            
            string localstring = data;
            char[] localchar = new char[localstring.Length];
            
            {

                int i = 0;

                foreach (char character in localstring)
                {
                    if (character.ToString() == ",")
                    {
                        stop = i;
                    }
                    localchar[i] = character;
                    i++;
                }
            }
            int LengthofLocal = localchar.Length;
            int param1 = 0;
            int param2 = privateKey;
            char temp;
            stop = localchar.Length - 1;
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
                                temp = localchar[j];
                                localchar[j] = localchar[j + 1];
                                localchar[j + 1] = temp;
                            }
                        }
                    }

                }
            } while (param1 < localchar.Length);
            return localchar;

        }

        public List<string> EncryptPositionsForTruth(List<int> positions)
        {
            var local = new List<string>();
            int x = 0;
            int y = 1;
            int z = 2;
            for (; x < positions.Count; x++, y++, z++)
            {
                if(true)
                {
                    if(x == positions.Count) { return local; }
                    if (positions[x] == 1 && positions[y] == 2 && positions[z] == 3)
                    {
                        local.Add("j");
                        local.Add("b");
                        local.Add("c");
                        x += 2;
                        y += 2;
                        z += 2;
                    }
                    else if (positions[x] == 4 && positions[y] == 2)
                    {
                        local.Add("f");
                        local.Add("n");
                        x += 1;
                        y += 1;
                        z += 1;
                    }
                    else if (positions[x] == 1)
                    {
                        local.Add("a");
                    }
                    else
                    {
                        local.Add(positions[x].ToString());
                    }

                }
            }
            return local;
        }
    }
}
