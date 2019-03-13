using System;
using DebugTests.Common.NugetWithPdb;

namespace WrongAssemblyLoaded
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            var test = new DebugTests.Common.NugetWithPdb.DebuggingCommon();

            Console.WriteLine("End");
            Console.ReadKey();
        }
    }
}
