using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Programa
    {
        public void Piano()
        {
            Piano piano = new Piano();
            piano.nombre = "PIANO";
            piano.notas = " DO-RE-MI-FA-SOL-LA-SI";
            piano.precio = 14600;
            Console.WriteLine(piano.informacion());
        }

        static void Main(string[] args)
        {
            Programa programa = new Programa();
            programa.Piano();
            Console.ReadLine();
            
        }
    }
}
