using System;
using System.Collections.Generic;
using System.Text;

namespace BoomerangPackage.Abstract
{
    abstract class Auth2<T> : IAuth<T>, IBoomerang
    {
        public string DecryptedLayer1DecryptorFromServer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public T DecryptedLayer3PointerDataFromClient { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public T DecryptedLayer2PointerDataFromClient { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<int> PointerDataDecryptedFromClientDecryptor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string TypeName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public (T, T) AwaitClientDecryptorAndData()
        {
            throw new NotImplementedException();
        }

        public T AwaitServerDecryptor()
        {
            throw new NotImplementedException();
        }

        public string DecryptClientLayer1PointerData(T encryptedRoundRobinDecryptionPointerData)
        {
            throw new NotImplementedException();
        }

        public void DecryptClientLayer1PointerData()
        {
            throw new NotImplementedException();
        }

        public T DecryptClientLayer2PointerData(T encryptedSharedServerPointerData)
        {
            throw new NotImplementedException();
        }

        public T DecryptClientLayer3PointerData(T encryptedSharedClientServerPointerData)
        {
            throw new NotImplementedException();
        }

        public void DecryptDecryptorServerData()
        {
            throw new NotImplementedException();
        }

        public string DecryptLayer1ServerDecryptor(T layer1EncryptedSharedNetworkServerDecryptorFromServer)
        {
            throw new NotImplementedException();
        }

        public T DecryptLayer1ServerSharedDecryptor(T layer2EncryptedSharedServerDecryptorFromClient)
        {
            throw new NotImplementedException();
        }

        public T DecryptLayer2ClientSharedDecryptor(T layer2EncryptedSharedClientDecryptorFromClient)
        {
            throw new NotImplementedException();
        }

        public void SendDataToClient(T PointerData)
        {
            throw new NotImplementedException();
        }
    }
}
