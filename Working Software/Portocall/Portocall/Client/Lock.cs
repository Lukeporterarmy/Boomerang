using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Portocall
{
    class Lock
    {
        readonly int count;
        long Shared { get; set; }
        readonly long final;
        readonly byte[] streamHash;
        public byte[] PositionsHash { get; set; }

        int networkTry;
        public Lock(int count, long final, long shared, SHA256 sha, byte[] streamHash, byte[] positionsHash) //shared should be generated locally
        {
            Shared = shared;
            //Shared += Convert.ToInt64(HashCode.Combine(SharedHash(sha)));
            this.count = count;
            this.final = final;
            PositionsHash = positionsHash;
            this.streamHash = streamHash;
        }

        public bool UnlockLock(long privateKey, int count)
        {
            if (networkTry > 0)
            {
                Environment.Exit(123);
            }

            if (Authenticator.Complete)
            {
                Authenticator.VerifyHash();
                long finalComparison = Convert.ToInt64(privateKey + Shared);
                bool truth = TruthBool();
                bool installer = InstallerBool();
                bool self = SelfBool();


                if (this.count == count && finalComparison == final && truth && installer && self)
                {
                    NetworkNotify("success");
                    return true;
                }
                else
                {
                    NetworkNotify("authentication");
                    return false;
                }
            }

            else
            {
                NetworkNotify("error");
                networkTry++;
                Environment.Exit(101);
                return false;
            }
        }

        public bool SelfBool(byte[] hash = null, byte[] hash2 = null, string supportingEvidences = null)
        {
            Console.WriteLine("\nFinal determination for Unlock..\n");
            return true;
        }

        public bool TruthBool(bool positionBool = false, byte[] installerHash = null, string supportingEvidences = null)
        {
            Console.WriteLine("\nTruth Server checks with supporting evidence determination..\n");
            Console.WriteLine(true);
            return true;
        }

        public bool InstallerBool(bool installerHash = false, byte[] positionHash = null, string supportingEvidences = null)
        {
            Console.WriteLine("\nInstaller checks with supporting evidence determination..\n");
            Console.WriteLine(true);
            return true;
        }

        public void NetworkNotify(string reason)
        {
            string caseSwitch = reason;
            switch (caseSwitch)
            {
                case "authentication":
                    Console.WriteLine("\nAuthentication failed. Check system architecture.");
                    break;
                case "error":
                    Console.WriteLine("\nUnexpected error. Check system architecture");
                    break;
                case "success":
                    Console.WriteLine("\nLock successfully removed");
                    break;
            }
        }
    }
}
