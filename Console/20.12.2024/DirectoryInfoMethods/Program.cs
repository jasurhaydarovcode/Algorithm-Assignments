using System;
using System.IO;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryInfo1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo tanlanganFayl = new DirectoryInfo("test");

            string nomi = tanlanganFayl.Name;
            string toliqNomi = tanlanganFayl.FullName;
            DateTime t1 = tanlanganFayl.CreationTime;
            DateTime t2 = tanlanganFayl.LastWriteTime;

            WriteLine("Katalogning Nomi: {0}\nKatalogning to'liq nomi: {1}", nomi, toliqNomi);
            WriteLine("Katalog yaratilgan sana: {0}\nOxirgi uzgargan sana: {1}", t1, t2);

            ReadLine();
        }
    }
}
