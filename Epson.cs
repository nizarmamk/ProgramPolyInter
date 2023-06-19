using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyInter
{
    public class Epson : IPrinterWindows
    {
        public void Show(Printer printer)
        {
            Console.WriteLine("Epson Display Dimension : 10*11");
        }
        public void Print(Printer printer)
        {
            Console.WriteLine("Epson Printer is printing...");
        }
    }
}
