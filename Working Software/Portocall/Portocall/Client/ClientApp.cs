using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Portocall.Client
{
    class ClientApp
    {
        bool unlock;

        static Lock softwareLock;
        public void Startup()
        {
            //startup operations client
            SystemHandler.SetDependency(Dependency1.OriginalDependency());
        }

        public void Decrypt(string decryption)
        {
            var decrypt = new Decrypt();
            var temp = decrypt.RemoveSharedLayer1(Conversion.StringToChar(decryption));
            var decryptFile = new FileHandler("TestDecryptLayer2");
            decryptFile.FileWrite(temp);
            Console.WriteLine("Decrypted DecryptionLayer2 and wrote to file 'TestDecryptLayer2.cs'.");
            Client.Strings.EncryptedLayer2 = Strings.EncryptedLayer2;
            Client.Strings.encrypted = Client.Strings.EncryptedLayer2;
            Console.WriteLine($"\nEncryption Level 2: {Conversion.CharToString(Strings.EncryptedLayer2)}");
            Client.Strings.DecryptedLayer1 = decrypt.RemoveSharedLayer1(Strings.EncryptedLayer2);
            Console.WriteLine($"\nDecrypted Layer 1: {Conversion.CharToString(Client.Strings.DecryptedLayer1)}");
            Client.Strings.DecryptedLayer2 = decrypt.RemovePrivateLayer2(Client.Strings.DecryptedLayer1, 3);
            Console.WriteLine($"\nDecrypted Layer 2: {Conversion.CharToString(Client.Strings.DecryptedLayer2)}");


        }

        public void ArmLock(int hashListCount, long final, long shared, SHA256 sha, byte[] streamHash, byte[] positionsHash)
        {
            softwareLock = new Lock(hashListCount, final, shared, sha, streamHash, positionsHash);
        }

        public void GetTruthDecryptionFromInstaller(string encryptedString)
        {
            Strings.TruthDecryption = encryptedString;
        }


        public string SendToTruth()
        {
            Console.WriteLine("\nSending encryption to Truth Server");
            return Strings.TruthDecryption;
        }

        public void TryLock()
        {
            unlock = softwareLock.UnlockLock(Authenticator.previousHash, Authenticator.hashCount);
        }
        public void AfterUnlock()
        {
            if (unlock)
            {



                //installer implementation
                var dependency = new FileHandler("Dependency2.cs");
                //dependency.FileWrite(Strings.encrypted);
                //string fromFile = dependency.GetContents();
                //char[] decryptFromFile = decrypt.RemoveSharedLayer1(Conversion.StringToChar(fromFile));
                //char[] decryptFromFile2 = decrypt.RemovePrivateLayer2(decryptFromFile, 3);

                dependency.FileWrite(Client.Strings.dependency2Content);
                //SystemHandler.RestartSystem("path");
                SystemHandler.SetDependency(Dependency2.NewDependency());
                //dependency.DeleteFile();
            }

            else
            {
                softwareLock.NetworkNotify("error");
            }
        }

        public void GetEncryptions(char[] Layer2)
        {
            Strings.EncryptedLayer2 = Layer2;
        }
    }
}
