using System;
using AffinityOffsetUpdater;

namespace TestOffsets
{
    internal class Program
    {
       private static void Main()
       {
           var offsets = new Offsets();

            #region NETVARS
            Console.WriteLine("[NETVARS]" + Environment.NewLine);
            //Console.WriteLine(nameof(offsets.rootObject.netvars.) + ": " + offsets.rootObject.netvars.);
            Console.WriteLine(Environment.NewLine);
            #endregion

            #region SIGNATURES
            Console.WriteLine("[SIGNATURES]" + Environment.NewLine);
            //Console.WriteLine(nameof(offsets.rootObject.signatures.) + ": " + offsets.rootObject.signatures.);
            Console.WriteLine(Environment.NewLine);
            #endregion
        }
    }
}
