using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Instrumento
    {
        public string nombre;
        public string notas;
        public int precio;

        public Instrumento() {
            this.nombre = "";
            this.notas = "";
            this.precio = 0;

        }
        public virtual String informacion() {
            return "INFORMACION DEL INSTRUMENTO \n"
                + "Nombre: " + this.nombre
                + "\n Notas: " + this.notas 
                + "\n Precio: " + this.precio;
        
        }

    }
}
