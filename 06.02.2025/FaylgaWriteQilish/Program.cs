using System;
using System.IO;

namespace FaylgaWriteQilish
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Butun sonlar space bilan kiritilsin: ");
            string son = Console.ReadLine();
            string filePath = "input.txt";
            try
            {
                File.WriteAllText(filePath, son);
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
                Console.WriteLine("O'qilgan satr: {0}", satr);
            }
            else
            {
                Console.WriteLine("File topilmadi!");
            }


            Console.ReadLine();
        }
    }
}
