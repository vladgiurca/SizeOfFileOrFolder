using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SizeOfFileOrFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti adresa fisierului/folderului: ");
            string path = Console.ReadLine();

            SOFF sOFF = new SOFF(path);
            sOFF.Size();

            Console.ReadKey();
        }
    }
}
