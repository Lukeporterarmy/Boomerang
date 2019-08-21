using System;
using System.Collections.Generic;
using System.Text;

namespace Portocall.Truth
{
    class Decrypt
    {
        static int stop;
        public char[] RemovePrivateLayer2(char[] local, int privateKey)
        {
            char[] localchar = new char[local.Length];
            localchar = local;
            int param1 = 0;
            int param2 = privateKey;
            char temp;
            stop = local.Length - 1;

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

        public List<int> DecryptPositionsFromInstaller(List<string> local)
        {
            var positions = new List<int>();
            int x = 0;
            int y = 1;
            int z = 2;
            for (; x < local.Count; x++, y++, z++)
            {
                if(x == local.Count) { return positions; }

                if(true)
                {
                    if (local[x] == "j" && local[y] == "b" && local[z] == "c")
                    {
                        positions.Add(1);
                        positions.Add(2);
                        positions.Add(3);
                        x += 2;
                        y += 2;
                        z += 2;
                    }
                    else if (local[x] == "f" && local[y] == "n")
                    {
                        positions.Add(4);
                        positions.Add(2);
                        x += 1;
                        y += 1;
                        z += 1;
                    }
                    else if (local[x] == "a")
                    {
                        positions.Add(1);
                    }
                    else
                    {
                        positions.Add(Convert.ToInt32(local[x]));
                    }

                }
            }
            return positions;
        }
    }
}
