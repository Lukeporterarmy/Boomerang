using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Portocall
{
    abstract class Dependency1
    {
        public static string OriginalDependency()
        {
            Console.WriteLine("\nOriginal dependency set to Dependency1.");
            return Path.Combine(Directory.GetCurrentDirectory(), $"..\\..\\..\\Dependency1");
        }
    }
}
