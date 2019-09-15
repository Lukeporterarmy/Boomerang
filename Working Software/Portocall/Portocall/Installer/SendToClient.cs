using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Portocall
{
    class SendToClient
    {

        public void AuthenticatorFeed(List<byte[]> hashList, SHA256 sha)
        {
            bool last = false;
            for (int i = 0; i < hashList.Count; i++)
            {
                if(i + 1 == hashList.Count) { last = true; }
                Authenticator.CombineHash(hashList[i], sha, last, i, "+");
            }
        }

        public void AuthenticatorFeed(List<byte[]> hashList)
        {
            Authenticator.hashList = null;
            foreach(byte[] hash in hashList)
            {
                Authenticator.GatherHashList(hash, false);
            }
            Authenticator.GatherHashList(null, true);
        }
    }


}
