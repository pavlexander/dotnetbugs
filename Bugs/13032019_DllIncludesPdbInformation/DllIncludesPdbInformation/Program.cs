using System;

namespace DllIncludesPdbInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            // place a debug point here. Step into the code, when in debug mode.
            //DllWithPortableDebuggingInformation.DebuggableClass.DebuggableMethod(); // uncomment!

            Console.WriteLine("End");
            Console.ReadKey();
        }
    }
}
