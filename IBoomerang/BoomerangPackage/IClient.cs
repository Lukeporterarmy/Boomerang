using System;
using System.Collections.Generic;
using System.Text;

namespace BoomerangPackage
{
    interface IClient<T>
    {
        long PrivateKey { get; set; }
        long FinalKey { get; set; }
        static byte[] HashFinalKey { get; }
        static byte[] HashOperators { get; }
        static byte[] PointerDataHash { get; }
        List<int> PointerData { get; set; }
        static List<int> ActualPositionData { get; set; }
        List<T> seedDataList { get; set; }
        static T SharedData { get; }
        static byte[] HashSharedKey { get; set; }

        T EncryptedAuthDecryptor { get; }

        //shared encryptions with IServer and Auth and has private encryption from IServer
        //takes instructions upon unlock from IServer which can either exist or not exist


        void OpenWorkflowParameters(string[] parameters);
        void SetCurrentWorkflow(string route);


        void PassDecryptorToAuth(T encryptedAuthDecryptor);
        void ArmLock();


        void NormalWorkflow();


        void AwaitDataFromServer(T seedPart);

        T EncryptionForAuth(List<T> seedDataList);

        void SendDataToAuth(T encryptedAuthDecryptor);

        List<int> AwaitDataAuth();

        //primary data being passed as supporting evidence for a trusted relationship
        void ReceiveAuthSupportingEvidence(List<int> pointerData);
        void GatherServerSupportingEvidence(List<T> seedDataList);
        void GatherInternalSupportingEvidence(byte[] hashFinalKey, byte[] hashOperators, byte[] pointerDataHash, byte[] hashPrivateKey);

        void TryUnlock(bool recieveAuthSupportingEvidence, bool gatherServerSupportingEvidence, bool gatherInternalSupportingEvidence, long privateKey, List<string> operators, List<int> actualPositionData);
        

        //if
        T Regenerate();
        void OpenWorkflow(string instructions); //recieves instructions from IServer


    }
}
