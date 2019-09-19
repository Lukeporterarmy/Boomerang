using System.Collections.Generic;

namespace BoomerangPackage
{
    //Massively scalable version of this idea.
    //Pick between one of three roles for your program.

    //Start point
    //SharedClient means the server shares with the client something
    //Layer1Decryptor means there is a shared layer 1 encryption on a decryptor.
    interface IServer<T>
    {
        T Seed { get; set; }
        T SeedDataToList { get; set; }

        List<int> Positions { get; set; }
        List<int> Operators { get; set; }
        string ClientDecryptor { get; set; }
        string AuthDecryptor { get; set;}
        T EncryptedLayer1ServerSharedClientDecryptor { get; set; }
        T EncryptedLayer1ServerSharedAuthDecryptor { get; set; }
        T EncryptedLayer2ClientSharedAuthDecryptor { get; set; }
        T SharedKey { get; set; }
        T PrivateKey { get; set; }
        byte[] Finalkey { get; set; }
        T EncryptedLayer1PositionalData { get; set; }
        T EncryptedLayer2PositionalData { get; set; }
        T EncryptedLayer3PositionalData { get; set; }

        //creates relationships between IAuth and IClient. IServer does not have to exist for IClient to share a relationship with it.

        void GenerateAuthAndPlantData();
        //In-depth functions of auth generate data
        void BreakSeedDataToList(T seed);
        void GrabPosition(T seedPart);

        void EncryptSharedNetworkLayer1ServerPositionalData(List<int> positions); //shares this with IAuth

        void EncryptSharedLayer2ClientPositionalData(T positions); //passed from client

        void EncryptPrivateLayer3AuthPositionalData(T positions); //sent over network to IAuth from IServer. Decrypted by final decryptor in IAuth.

        void PlantAuthData(T encryptedLayer2PositionalData); //see IAuth for more information after deployment
        void EncryptSharedLayer1AuthDecryptor(string decryptor);



        void GenerateClientAndPlantData();
        //In-depth functions of client generate data
        byte[] CreateHashPositionalData(List<int> positions);
        byte[] PlantFinalKey(T sharedKey, T privateKey); //then IServer passes final key and shared key and private key is provided over the network
        byte[] CreateHashOperators(List<string> operators);
        void EncryptSharedServerLayer1ClientDecryptor(string clientDecryptor); //how layered encryption can happen where this creates a private key from a shared key
        void EncryptSharedServerLayer1AuthDecryptor(string authDecryptor);
        void EncryptSharedClientLayer2AuthDecryptor(T Layer1AuthDecryptor);
        void PlantClientLockData(byte[] finalKey, T sharedKey, T layer2AuthDecryptor, T layer1ClientDecryptor, byte[] hashOperators, byte[] hashPositions); //static readonly data

        void DeployClient(); //see IClient for more information after deployment.



        //optional interaction with client


        void SendSharedDecryptorServerToAuth(T encryptedDecryptor); //shares this over the network to IAuth
        void SendDataToClient(T seedDataToList);
        void InstructClient(T instructions); //gives instructions to IClient

    }
}
