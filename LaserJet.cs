using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyInter
{
    internal class LaserJet : IPrinterWindows
    {
        public void Show(Printer printer)
        {
            Console.WriteLine("LaserJet Display Dimension : 12*12");
        }
        public void Print(Printer printer)
        {
            Console.WriteLine("LaserJet Printer is printing...");
        }
    }
}
