using Portocall.Client;
using Portocall.Installer;
using Portocall.Truth;
using System;

namespace Portocall
{
    class Program
    {
        static void Main(string[] args)
        {
            var print = new Print();

            var client = new ClientApp();
            client.Startup();

            var installer = new InstallerApp();
            installer.EncryptForClient();

            installer.GenerateCodeForClient();


            client.GetEncryptions(installer.GetEncryptions());

            var (hashList, final, shared, sha, streamHash, positionsHash) = installer.CreateLock();

            client.ArmLock(hashList, final, shared, sha, streamHash, positionsHash);


            




            //Adds decryptor needed for position values using client and installer.

            var truth = new TruthApp();

            var gather = new Portocall.Truth.Gather();

            

            var (encryptedPositions, decryptKey1, decryptKey2) = installer.SendInfoToTruth();

            gather.FromClientEncryptedPositions(encryptedPositions);

            gather.FromInstallerDecryptionNumbers(decryptKey1, decryptKey2);

            truth.GetInstallerInfo(encryptedPositions, decryptKey1, decryptKey2);

            


            string encryptedDecryptor = installer.SendTruthDecryptionToClient();

            client.GetTruthDecryptionFromInstaller(encryptedDecryptor);

            string decryptionPositions = client.SendToTruth();

            truth.CreateDecryption(decryptionPositions);

            

            truth.DecryptPositions();

            installer.ClearData();

            client.Decrypt(Strings.EncryptedDecryptionLayer2Client);

            installer.SendDataToClient();

            installer.CompleteTransmission();

            client.TryLock();

            client.AfterUnlock();
        }
    }
}
