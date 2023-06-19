using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyInter
{
    internal class Canon : IPrinterWindows
    {
        public void Show(Printer printer)
        {
            Console.WriteLine("Canon Display Dimension : 9.5*12");
        }
        public void Print(Printer printer)
        {
            Console.WriteLine("Canon Printer is printing...");
        }
    }
}
