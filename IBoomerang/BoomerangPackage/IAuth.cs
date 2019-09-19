using System;
using System.Collections.Generic;
using System.Text;

namespace BoomerangPackage
{
    interface IAuth<T>
    {

        //(current state)Encrypt(private or shared keys)Shared(shared with)Client(first level of encryption)SharedLayer1(object name)Decryptor

        string DecryptedLayer1DecryptorFromServer { get; set; }
        T DecryptedLayer3PointerDataFromClient { get; set; } //allows the three way decryption relationship between IServer, IClient, and IAuth
        T DecryptedLayer2PointerDataFromClient { get; set; }
        List<int> PointerDataDecryptedFromClientDecryptor { get; set; }

        //shared cryptography with server on demand and client internally and has a round robin encryption relationship. This would be a function more than a constant connection
        //it would exist in a semi-partial state

        T AwaitServerDecryptor();
        (T, T) AwaitClientDecryptorAndData();
        string DecryptLayer1ServerDecryptor(T layer1EncryptedSharedNetworkServerDecryptorFromServer);
        T DecryptLayer1ServerSharedDecryptor(T layer2EncryptedSharedServerDecryptorFromClient);
        T DecryptLayer2ClientSharedDecryptor(T layer2EncryptedSharedClientDecryptorFromClient);


        T DecryptClientLayer3PointerData(T encryptedSharedClientServerPointerData);
        T DecryptClientLayer2PointerData(T encryptedSharedServerPointerData);
        string DecryptClientLayer1PointerData(T encryptedRoundRobinDecryptionPointerData);
        void DecryptClientLayer1PointerData();
        void DecryptDecryptorServerData();

        void SendDataToClient(T PointerData);
    }
}
