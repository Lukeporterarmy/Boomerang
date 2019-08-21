using System;
using System.Collections.Generic;
using System.Text;

namespace Portocall.Truth
{
    struct Gather
    {
        public void FromClientEncryptedPositions(List<string> encryptedPositions)
        {
            TruthApp.encryptedPositions = encryptedPositions;
        }

        public void FromClientEncryptDecryptionOfEncryptedPositions(string decryption)
        {
            decryption = Strings.EncryptedDecryptionLayer2Client;
        }

        public void FromClientValuesEncrypted()
        {

        }

        public void FromInstallerDecryptionNumbers(int key1, int key2)
        {
            TruthApp.decryptionkey1 = key1;
            TruthApp.decryptionkey2 = key2;
        }
    }
}
