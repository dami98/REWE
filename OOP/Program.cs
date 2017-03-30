using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammin
{
    class Program
    {
        static void Main(string[] args)
        {
            Form Viereck = new Form("Viereck",5,5);
            Kreis Circ = new Kreis("Kreis",3.4f);
            Console.WriteLine(Viereck.ToString());
            Console.WriteLine(Circ.ToString());
            Console.ReadLine();

        }
    }
}
