using Portocall.Client;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Portocall.Installer
{
    class InstallerApp
    {
        Random random = new Random();
        Print print = new Print();
        Encrypt encrypt = new Encrypt();
        public static SHA256 sha = SHA256.Create();
        public void EncryptForClient()
        {
            
            Console.WriteLine($"Plain Text: {Strings.plainText}");
            Strings.EncryptedLayer1 = encrypt.ApplySharedLayer1(Strings.plainText);
            Console.WriteLine($"\nEncryption Level 1: {Strings.EncryptedLayer1}");
            Strings.EncryptedLayer2 = encrypt.ApplyPrivateLayer2Client(Strings.EncryptedLayer1, 3);
            Console.WriteLine($"\nEncryption Level 2: {Conversion.CharToString(Strings.EncryptedLayer2)}");

            
            

            Strings.TruthDecryption = Conversion.CharToString(encrypt.ApplyPrivateLayer2Truth(Strings.TruthDecryption, 7));
            Strings.TruthDecryption = Conversion.CharToString(encrypt.ApplyPrivateLayer2Truth(Strings.TruthDecryption, 11));


        }

        public string SendTruthDecryptionToClient()
        {
            return Strings.TruthDecryption;
        }

        public (List<string>, int, int) SendInfoToTruth()
        {
            Console.WriteLine("\n\nSending EncryptedPositions to Truth Server");
            return (Strings.EncryptedPositions, 7, 11);
        }

        public void GenerateCodeForClient()
        {
            string[] package = Generate.PackageData(Strings.seed);
            Strings.hashList = Generate.StringToHash(package, sha);

            Console.WriteLine("\n\n\n\nByte Arrays\n");
            print.ShowListOfArrays(Strings.hashList);
            Console.WriteLine("\n\n\n");

            Generate.GatherFeed(Strings.hashList, sha, random);

            Console.WriteLine($"\nStream Hash");
            print.ShowArray(Generate.streamHash);
            Console.WriteLine($"\nPosition Hash");
            print.ShowArray(Generate.positionsHash);
            Console.WriteLine("\nClient code generated.");

            Strings.EncryptedPositions = encrypt.EncryptPositionsForTruth(Generate.positions);
        }

        public (int, long, long, SHA256, byte[], byte[]) CreateLock()
        {
            long privateHash = Generate.previousHash;
            (long final, long shared, byte[] streamHash, byte[] positionsHash) = Generate.FinalClientLock(privateHash, sha); 
            
            
            Console.WriteLine("\n\nSoftware lock created.\n\n");
            return (Strings.hashList.Count, final, shared, InstallerApp.sha, streamHash, positionsHash);
        }

        public void ClearData()
        {
            Generate.Clear();
            Authenticator.previousHash = 0;
        }

        public void SendDataToClient()
        {
            var sender = new SendToClient();
            sender.AuthenticatorFeed(Strings.hashList, sha);
        }

        public char[] GetEncryptions()
        {
            return Strings.EncryptedLayer2;
        }

        public void CompleteTransmission()
        {
            Authenticator.CompleteTransmission(true);
        }

    }
}
