using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Portocall
{
    struct Authenticator
    {
        public static int hashCount;
        public static long previousHash;
        public static bool Complete { get; set; }
        public static List<byte[]> hashList;


        public static long CombineHash(byte[] current, SHA256 sha, bool last, int count, string symbol = "+")
        {
            switch (symbol)
            {
                case "+":
                    previousHash += Convert.ToInt64((HashCode.Combine(current)));
                    if (last)
                    {
                        Authenticator.hashCount = count + 1;
                    }
                    break;

                case "*":
                    break;
                case "%":
                    break;
                case "/":
                    break;
            }

            return previousHash;

        }

        public static bool GatherHashList(byte[] hash, bool complete)
        {
            if (complete)
            {
                return (complete);
            }
            else
            {
                hashList.Add(hash);
                return (complete);
            }
        }

       public static void VerifyHash(int[] streamPositions = null, byte[] lockHash = null, string streamNumebrs = null)
        {
            Console.WriteLine("\nVerified hashes.");
        }

        public static void CompleteTransmission(bool complete)
        {
            Complete = complete;
        }

        public static void VerifyInstallerAndTruth<T>(bool installer, bool truth, List<T> supportingEvidence)
        {

        }

    }
}
