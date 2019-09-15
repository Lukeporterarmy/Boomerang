using System;
using System.Collections.Generic;
using System.Text;

namespace Portocall.Truth
{
    class TruthApp
    {
        internal static List<string> encryptedPositions;
        internal static int decryptionkey1;
        internal static int decryptionkey2;
        internal static List<long> hashLong;
        internal static List<int> decryptedPositions;
     


        public void GetInstallerInfo(List<string> positions, int decryptionkey1, int decryptionkey2)
        {
            TruthApp.decryptionkey1 = decryptionkey1;
            TruthApp.decryptionkey2 = decryptionkey2;
            TruthApp.encryptedPositions = positions;

            Console.WriteLine($"\n\n\nTruth Server:\nDecryption Keys {decryptionkey1} {decryptionkey2}\nPositions\n");
            foreach(string position in positions)
            {
                Console.WriteLine(position);
            }
            

        }

        public void DecryptClientLongValues2(List<long> hashLong, int decryptionkey1, int decryptionkey2)
        {
            TruthApp.hashLong = hashLong;
            TruthApp.decryptionkey1 = decryptionkey1;
            TruthApp.decryptionkey2 = decryptionkey2;


        }

        public void CreateDecryption(string contents)
        {
            FileHandler fileHandler = new FileHandler("DecryptPositions.cs");
            fileHandler.FileWrite(contents);
        }

        public void DecryptPositions()
        {
            var decrypt = new Decrypt();
            decryptedPositions = decrypt.DecryptPositionsFromInstaller(encryptedPositions);
            Console.WriteLine("\n\n\nDecrypted positions from Installer from Truth Server");
            Console.WriteLine("\nNew Positions\n");
            string temp = (Conversion.ListToString(decryptedPositions));
            Console.WriteLine(temp);
            Console.WriteLine("\n\n\n\n");
        }
    }
}
