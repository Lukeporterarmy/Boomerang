using System;
using System.Collections.Generic;
using System.Text;

namespace BoomerangPackage
{
    interface IClient
    {
        void ArmLock();
        void SetWorkflow();
        void Authenticator();
        void ReceiveDataFromServer();
        void Decrypt();
        void EncryptDecryptorLayer2();
        void PassDecryptorToAuth();


    }
}
