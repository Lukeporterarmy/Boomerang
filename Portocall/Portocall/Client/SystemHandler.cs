using System;
using System.Collections.Generic;
using System.Text;

namespace Portocall
{
    abstract class SystemHandler
    {
        public static string dependency;
        public static void RestartSystem(string application)
        {
            System.Diagnostics.Process.Start(application);
            Environment.Exit(0);
        }

        public static void SetDependency(string path)
        {
            Console.WriteLine("\nDependency Change.\n");
            SystemHandler.dependency = path;
        }
    }
}
