using System;
using System.IO;

namespace Mask
{
    class Program
    {
        static void Main(string[] args)
        {
           
                string[] papkalar = Directory.GetDirectories(@"C:\", "P*");
                foreach (string papka in papkalar)
                {
                    Console.WriteLine(papka);
                }
            Console.ReadLine();
            
        }
    }
}
