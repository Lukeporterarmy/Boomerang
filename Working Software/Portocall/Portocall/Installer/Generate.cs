using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Portocall
{
    struct Generate
    {
        public static string streamNumbers = "";
        public static List<int> positions = new List<int>();
        public static byte[] streamHash;
        public static byte[] positionsHash;
        public static long previousHash;
        public static string[] PackageData(string words)
        {
            var stringArray = words.Split(", ");
            return stringArray;
        }

        public static List<byte[]> StringToHash(string[] words, SHA256 sha)
        {
            byte[] entry;
            var gather = new List<byte[]>();
            foreach (string word in words)
            {
                entry = sha.ComputeHash(Encoding.UTF8.GetBytes(word));
                gather.Add(entry);
            }
            return gather;
        }

        public static (long, long, byte[], byte[]) FinalClientLock(long privateHash, SHA256 sha)
        {
            long shared = Convert.ToInt64(HashCode.Combine(SharedHash(sha)));
            long final = Convert.ToInt64(shared + privateHash);
            return (final, shared, streamHash, positionsHash);
        }

        public static void Clear()
        {
            streamHash = null;
            positionsHash = null;
        }

        private static byte[] SharedHash(SHA256 sha)
        {
            byte[] entry;
            entry = sha.ComputeHash(Encoding.UTF8.GetBytes((Strings.plainText)));
            return entry;
        }
        public static void StreamHash(long previousHash, int count, bool last, Random obj, SHA256 sha)
        {
            int random = obj.Next(previousHash.ToString().Length - 3);
            if (last)
            {
                string temp = previousHash.ToString();
                string streamData = temp.Substring(random, 2);
                streamNumbers += streamData;
                positions.Add(count);
                streamHash = sha.ComputeHash(Encoding.UTF8.GetBytes((streamData)));
                positionsHash = sha.ComputeHash(Encoding.UTF8.GetBytes(Conversion.ListToString(positions)));


            }
            else
            {
                string temp = previousHash.ToString();
                string streamData = temp.Substring(random, 2);
                streamNumbers += streamData;
                positions.Add(random);
            }
        }

        public static void GatherFeed(List<byte[]> hashList, SHA256 sha, Random random)
        {
            bool last = false;
            for (int i = 0; i < hashList.Count; i++)
            {
                if (i + 1 == hashList.Count) { last = true; }
                CombineHash(hashList[i], sha, last, i, random, "+");

            }
        }

        public static void CombineHash(byte[] current, SHA256 sha, bool last, int count, Random random, string symbol = "+")
        {
            switch (symbol)
            {
                case "+":
                    previousHash += Convert.ToInt64((HashCode.Combine(current)));
                    StreamHash(previousHash, count, last, random, sha);
                    break;

                case "*":
                    break;
                case "%":
                    break;
                case "/":
                    break;
            }


        }

    }
}
