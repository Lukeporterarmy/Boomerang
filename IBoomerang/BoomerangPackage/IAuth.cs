using System;
using System.Collections.Generic;
using System.Text;

namespace BoomerangPackage
{
    interface IAuth<T>
    {
        string DecryptedLayer1DecryptorFromServer { get; set; }
        T DecryptedLayer3PositionalDataFromClient { get; set; } //allows the three way decryption relationship between IServer, IClient, and IAuth
        T DecryptedLayer2PositionalDataFromClient { get; set; }
        List<int> PositionalDataDecryptedFromClientDecryptor { get; set; }

        //shared cryptography with server on demand and client internally and has a round robin encryption relationship. This would be a function more than a constant connection
        //it would exist in a semi-partial state

        T AwaitServerDecryptor();
        (T, T) AwaitClientDecryptorAndData();
        string DecryptLayer1ServerDecryptor(T layer1EncryptedSharedNetworkServerDecryptorFromServer);
        T DecryptLayer1ServerSharedDecryptor(T layer2EncryptedSharedServerDecryptorFromClient);
        T DecryptLayer2ClientSharedDecryptor(T layer2EncryptedSharedClientDecryptorFromClient);


        T DecryptClientLayer3PositionalData(T encryptedSharedClientServerPositionalData);
        T DecryptClientLayer2PositionalData(T encryptedSharedServerPositionalData);
        string DecryptClientLayer1PositionalData(T encryptedRoundRobinDecryptionPositionalData);
        void DecryptClientLayer1PositionalData();
        void DecryptDecryptorServerData();

        void SendDataToClient(T positionalData);
    }
}
