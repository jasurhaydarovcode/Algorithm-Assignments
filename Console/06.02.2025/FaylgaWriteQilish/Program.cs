using System;
using System.IO;

namespace FaylgaWriteQilish
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Ma'lumot kiriting: ");
            string inputData = Console.ReadLine();
            string filePath = "input.txt";
            try
            {
                File.WriteAllText(filePath, inputData);
                Console.WriteLine("Ma'lumot {0} fayliga yozildi", filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine("Xatolik", e.Message);
            }
            */


            string filePath = "input.txt";
            if (File.Exists(filePath))
            {
                string satr = File.ReadAllText(filePath);
                Console.WriteLine("O'qilgan ma'lumot: {0}", satr);
            }
            else
            {
                Console.WriteLine("File topilmadi!");
            }


            // Console Freeze
            Console.ReadLine();
        }
    }
}
