using System.Xml.Serialization;

using System.Collections.Generic;
using console_1302220152;

namespace consoleapp_1302220152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KodeBuah kodeBuah = new KodeBuah();
            Console.WriteLine(kodeBuah.getKodeBuah(KodeBuah.Buah.Alpukat));
        }


    }
}
