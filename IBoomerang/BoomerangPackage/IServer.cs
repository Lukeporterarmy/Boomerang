using System;
using System.Collections.Generic;
using System.Text;

namespace BoomerangPackage
{
    //Massively scalable version of this idea.
    //Pick between one of three roles for your program.

    //Start point
    //SharedClient means the server shares with the client something
    //Layer1Decryptor means there is a shared layer 1 encryption on a decryptor.
    interface IServer
    {
        void GenerateAuthAndPlantData();
        void DeployAuth();
        void SendSharedDecryptorServerToAuth();
        void EncryptPrivateAuthPositionalData();
        void SendEncryptedPositionalDataToAuth();



        void GenerateClientAndPlantData();
        //In-depth functions of generated data
        void PlantFinalKey();
        void PlantHashOperators();
        void PlantHashPositionalData();
        void EncryptSharedClientLayer1Decryptor();
        void EncryptPrivateClientLayer2Planted();
        void EncryptSharedAuthLayer1Decryptor();
        void PlantEncryptedAuthDecryptorToClient();
        void CreateClientLock();
        
        
        
        

    }
}
