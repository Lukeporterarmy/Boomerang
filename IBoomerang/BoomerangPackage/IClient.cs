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
        static byte[] PositionalDataHash { get; }
        List<T> seedDataList { get; set; }
        static T SharedData { get; }
        static byte[] HashSharedKey { get; set; }
        List<int> positions { get; set; }

        T EncryptedAuthDecryptor { get; }

        //shared encryptions with IServer and Auth and has private encryption from IServer
        //takes instructions upon unlock from IServer which can either exist or not exist


        void OpenWorkflowParameters(string[] parameters);
        void SetCurrentWorkflow(string route);


        void PassDecryptorToAuth(T encryptedAuthDecryptor);
        void ArmLock();


        void NormalWorkflow();


        void AwaitDataFromServerToAuthenticator(T seedPart);

        T EncryptionForIAuth(List<T> seedDataList);

        void SendDataToAuth(T seedDataList, T encryptedAuthDecryptor);

        T AwaitDataAuth();

        void ReceiveAuthSupportingEvidence(List<int> positions);
        void GatherServerSupportingEvidence(List<T> seedDataList);
        void GatherInternalSupportingEvidence(byte[] hashFinalKey, byte[] hashOperators, byte[] positionalDataHash, byte[] hashPrivateKey);

        void TryUnlock(bool recieveAuthSupportingEvidence, bool gatherServerSupportingEvidence, bool gatherInternalSupportingEvidence, long privateKey, List<string> operators, List<int> positions);
        

        //if
        T Regenerate();
        void OpenWorkflow(string instructions); //recieves instructions from IServer


    }
}
