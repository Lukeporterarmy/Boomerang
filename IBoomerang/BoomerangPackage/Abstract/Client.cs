using System;
using System.Collections.Generic;
using System.Text;

namespace BoomerangPackage.Abstract
{
    abstract class Client2<T> : IClient<T>, IBoomerang
    {
        public long PrivateKey { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public long FinalKey { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<int> PointerData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<T> seedDataList { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public T EncryptedAuthDecryptor => throw new NotImplementedException();

        public string TypeName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ArmLock()
        {
            throw new NotImplementedException();
        }

        public List<int> AwaitDataAuth()
        {
            throw new NotImplementedException();
        }

        public void AwaitDataFromServer(T seedPart)
        {
            throw new NotImplementedException();
        }

        public T EncryptionForAuth(List<T> seedDataList)
        {
            throw new NotImplementedException();
        }

        public void GatherInternalSupportingEvidence(byte[] hashFinalKey, byte[] hashOperators, byte[] pointerDataHash, byte[] hashPrivateKey)
        {
            throw new NotImplementedException();
        }

        public void GatherServerSupportingEvidence(List<T> seedDataList)
        {
            throw new NotImplementedException();
        }

        public void NormalWorkflow()
        {
            throw new NotImplementedException();
        }

        public void OpenWorkflow(string instructions)
        {
            throw new NotImplementedException();
        }

        public void OpenWorkflowParameters(string[] parameters)
        {
            throw new NotImplementedException();
        }

        public void PassDecryptorToAuth(T encryptedAuthDecryptor)
        {
            throw new NotImplementedException();
        }

        public void ReceiveAuthSupportingEvidence(List<int> pointerData)
        {
            throw new NotImplementedException();
        }

        public T Regenerate()
        {
            throw new NotImplementedException();
        }

        public void SendDataToAuth(T encryptedAuthDecryptor)
        {
            throw new NotImplementedException();
        }

        public void SetCurrentWorkflow(string route)
        {
            throw new NotImplementedException();
        }

        public void TryUnlock(bool recieveAuthSupportingEvidence, bool gatherServerSupportingEvidence, bool gatherInternalSupportingEvidence, long privateKey, List<string> operators, List<int> actualPositionData)
        {
            throw new NotImplementedException();
        }
    }
}
