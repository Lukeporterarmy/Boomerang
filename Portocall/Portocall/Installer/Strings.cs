using System;
using System.Collections.Generic;
using System.Text;

namespace Portocall
{
    partial class Strings
    {
        internal static string[] Operators { get; set; }
        internal static byte[] SharedKey { get; set; }
        internal static List<byte[]> hashList;
        internal static string seed = "A, B, C, D, E, F, 1, 2, 3, 4, 5";
        internal static string plainText = "Walking out the door, LUCKY";
        internal static string EncryptedLayer1 { get; set; }
        internal static char[] EncryptedLayer2 { get; set; }
        internal static char[] SharedMessage { get; set; }

        internal static List<string> EncryptedPositions { get; set; }

        internal static string EncryptedDecryptionLayer2Client = "using System; using System.Collection.Generic; namespace Portocall.Client {" +
            "public char[] RemovePrivateLayer2(char[] local, int privateKey){char[] localchar = new char[local.Length];localchar = local;int param1 = 0;int param2 = privateKey;char temp;do{for (; " +
            "param1<localchar.Length && param1<param2; param2 += privateKey + 1, param1 += privateKey + 1){if (param1 == stop || param2 == stop){param1 = localchar.Length;param2 = param1;}if (param2<localchar.Length)" +
            "{for (int j = param1 + 1; j<param1 + 2; j++){if (j == stop || j + 1 == stop){param1 = localchar.Length;param2 = param1;}else{temp = localchar[j + 1];localchar[j + 1] = localchar[j];localchar[j] = temp;" +
            "}}}}} while (param1<localchar.Length);return localchar;}}";

        internal static string TruthDecryption = "/*" +
            "public List<int> DecryptPositionsFromInstaller(List<string> local){var positions = new List<int>();int x = 0;int y = 1;int z = 2;for (; x<local.Count; x++, y++, z++){if (z >= local.Count){return positions;}" +
            "else if (y >= local.Count){return positions;}else{if (local[x] == 'j' && local[y] == 'b' && local[z] == 'c'){positions[x] = 1;positions[y] = 2;positions[z] = 3;x += 2;y += 2;z += 2;}else if (local[x] == 'f' && local[y] == 'n')" +
            "{positions[x] = 4;positions[y] = 2;x += 1;y += 1;z += 1;}else if (local[x] == 'a'){positions[x] = 1;}else{positions[x] = Convert.ToInt32(local[x]);}}}return positions;}" +
            "*/";

    }
}
