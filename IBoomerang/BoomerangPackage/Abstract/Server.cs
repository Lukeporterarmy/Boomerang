using System;
using System.Collections.Generic;
using System.Text;

namespace BoomerangPackage.Abstract
{
    abstract class Server2<T> : IServer<T>, IBoomerang
    {
        public T Seed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public T SeedDataToList { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<int> PositionData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<int> PointerData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public byte[] HashPointerData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<int> Operators { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public byte[] HashOperators { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ClientDecryptor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string AuthDecryptor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public T EncryptedLayer1ServerSharedClientDecryptor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public T EncryptedLayer1ServerSharedAuthDecryptor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public T EncryptedLayer2ClientSharedAuthDecryptor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public T SharedKey { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public T PrivateKey { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public byte[] Finalkey { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public T EncryptedLayer1PointerData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public T EncryptedLayer2PointerData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public T EncryptedLayer3PointerData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string TypeName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void BreakSeedDataToList(T seed)
        {
            throw new NotImplementedException();
        }

        public byte[] CreateHashOperators(List<string> operators)
        {
            throw new NotImplementedException();
        }

        public byte[] CreateHashPointerData(List<int> pointerData)
        {
            throw new NotImplementedException();
        }

        public T CreatePrivateKey(List<int> actualPositionData)
        {
            throw new NotImplementedException();
        }

        public void DeployClient()
        {
            throw new NotImplementedException();
        }

        public void EncryptPrivateLayer3AuthPointerData(T pointerData)
        {
            throw new NotImplementedException();
        }

        public void EncryptSharedClientLayer2AuthDecryptor(T Layer1AuthDecryptor)
        {
            throw new NotImplementedException();
        }

        public void EncryptSharedLayer1AuthDecryptor(string decryptor)
        {
            throw new NotImplementedException();
        }

        public void EncryptSharedLayer2ClientPointerData(T pointerData)
        {
            throw new NotImplementedException();
        }

        public void EncryptSharedNetworkLayer1ServerPointerData(List<int> pointerData)
        {
            throw new NotImplementedException();
        }

        public void EncryptSharedServerLayer1AuthDecryptor(string authDecryptor)
        {
            throw new NotImplementedException();
        }

        public void EncryptSharedServerLayer1ClientDecryptor(string clientDecryptor)
        {
            throw new NotImplementedException();
        }

        public void GenerateAuthAndPlantData()
        {
            throw new NotImplementedException();
        }

        public void GenerateClientAndPlantData()
        {
            throw new NotImplementedException();
        }

        public void GrabPosition(T seedPart)
        {
            throw new NotImplementedException();
        }

        public void InstructClient(T instructions)
        {
            throw new NotImplementedException();
        }

        public void PlantAuthData(T encryptedLayer2PointerData)
        {
            throw new NotImplementedException();
        }

        public void PlantClientLockData(byte[] finalKey, T sharedKey, T layer2AuthDecryptor, T layer1ClientDecryptor, byte[] hashOperators, byte[] hashPositions)
        {
            throw new NotImplementedException();
        }

        public byte[] PlantFinalKey(T sharedKey, T privateKey)
        {
            throw new NotImplementedException();
        }

        public void SendDataToClient(T seedDataToList)
        {
            throw new NotImplementedException();
        }

        public void SendSharedDecryptorServerToAuth(T encryptedDecryptor)
        {
            throw new NotImplementedException();
        }
    }
}
