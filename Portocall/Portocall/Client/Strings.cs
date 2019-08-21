using System;
using System.Collections.Generic;
using System.Text;

namespace Portocall.Client
{
    partial class Strings
    {
        internal static char[] DecryptedLayer1 { get; set; }
        internal static char[] DecryptedLayer2 { get; set; }
        internal static byte[] SharedKey { get; set; }
        internal static char[] SharedMessage { get; set; }
        internal static char[] EncryptedLayer2 { get; set; }
        internal static string TransportedEncryption { get; set; }

        internal static string dependency2Content = @"using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Portocall
{
    abstract class Dependency2
    {
        public static string NewDependency()
        {
            Console.WriteLine(""\nNew dependency set to Dependency2."");
            return Path.Combine(Directory.GetCurrentDirectory(), $""..\\..\\..\\Dependency2"");
        }
}
}";

        internal static string TruthDecryption = "" +
            "public List<int> DecryptPositionsFromInstaller(List<string> local){var positions = new List<int>();int x = 0;int y = 1;int z = 2;for (; x<local.Count; x++, y++, z++){if (z >= local.Count){return positions;}" +
            "else if (y >= local.Count){return positions;}else{if (local[x] == 'j' && local[y] == 'b' && local[z] == 'c'){positions[x] = 1;positions[y] = 2;positions[z] = 3;x += 2;y += 2;z += 2;}else if (local[x] == 'f' && local[y] == 'n')" +
            "{positions[x] = 4;positions[y] = 2;x += 1;y += 1;z += 1;}else if (local[x] == 'a'){positions[x] = 1;}else{positions[x] = Convert.ToInt32(local[x]);}}}return positions;}" +
            "";

        internal static char[] encrypted;


        
    }
}
