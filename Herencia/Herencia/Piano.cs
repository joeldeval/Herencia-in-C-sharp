using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Piano : Instrumento
    {
        public Piano() { 
        
        }
        public override String informacion()
        {
            return "INFORMACION DEL PIANO \n"
                + "Nombre: " + this.nombre
                + "\n Notas: " + this.notas
                + "\n Precio: " + this.precio;
        }
    }
}
