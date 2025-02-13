using System;
using System.IO;
using static System.Console;

namespace FaylniO_chirish
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            WriteLine("Ma'lumot Kiriting: ");
            string inputData = Console.ReadLine();
            string filePath = "input.txt";
            try
            {
                File.WriteAllText(filePath, inputData);
                WriteLine("Ma'lumot {0} ga muaffaqiyatli yozildi.", filePath);
            }
            catch(Exception e)
            {
                WriteLine("Xatolik yuz berdi.", e.Message);
            }
            */

            
            string filePath = "input.txt";
            if(File.Exists(filePath))
            {
                File.Delete(filePath);
                WriteLine("{0} Fayl muaffaqiyatli o'chirildi.", filePath);
            }
            else
            {
                WriteLine("{0} Fayl topilmadi.", filePath);
            }
            

            // Console freeze
            ReadLine();
        }
    }
}
