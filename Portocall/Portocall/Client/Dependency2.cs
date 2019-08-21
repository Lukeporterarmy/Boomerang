using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Portocall
{
    abstract class Dependency2
    {
        public static string NewDependency()
        {
            Console.WriteLine("\nNew dependency set to Dependency2.");
            return Path.Combine(Directory.GetCurrentDirectory(), $"..\\..\\..\\Dependency2");
        }
}
}