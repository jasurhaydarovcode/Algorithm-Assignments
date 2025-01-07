using System;
using System.IO;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInfoMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo f = new FileInfo("kitob.pdf");
            string nomi = f.Name;
            string toliqNomi = f.FullName;
            DateTime t1 = f.CreationTime;
            DateTime t2 = f.LastWriteTime;
            WriteLine("Faylning Nomi: {0}\nFaylning to'liq nomi: {1}", nomi, toliqNomi);
            WriteLine("Yaratilgan vaqti: {0}\nOxirgi o'zgartirilgan vaqti: {1}", t1, t2);
            ReadLine();
        }
    }
}
