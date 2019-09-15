using System;
using System.Collections.Generic;
using System.Text;

namespace BoomerangPackage
{
    interface IAuth
    {
        void RecieveServerData();
        void RecieveClientData();
        void RecieveDecryptionServer();
        void RecieveDecryptorClient();
        void DecryptServerLayer2Decryptor();
        void DecryptClientLayer1Decryptor();
        void DecryptClientLayer1ClientData();
        void DecryptDecryptorServerData();
    }
}
