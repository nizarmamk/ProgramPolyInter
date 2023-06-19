using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PolyInter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            Console.WriteLine("Select a Printer : ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet");
            Console.WriteLine();

            Console.Write("Choose Priner Number [1...3] : ");
            int option = Convert.ToInt32(Console.ReadLine());
            printer.Jenis = option;

            IPrinterWindows print;

            if (printer.Jenis == 1)
                print = new Epson();
            else if (printer.Jenis == 2)
                print = new Canon();
            else
                print = new LaserJet();

            Console.WriteLine();
            print.Show(printer);
            print.Print(printer);
            Console.ReadLine();
        }
    }
}
