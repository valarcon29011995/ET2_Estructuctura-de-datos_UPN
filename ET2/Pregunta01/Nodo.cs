using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta01
{
    internal class Nodo
    {
        public string NOMBRE, PROGRAMA;
        public Nodo(string NOMBRE, string PROGRAMA)
        {
            this.NOMBRE = NOMBRE;
            this.PROGRAMA = PROGRAMA;
        }
        public override string ToString()
        {
            return $"NOMBRE: {this.NOMBRE}\nPROGRAMA: {this.PROGRAMA}\n";
        }
    }
}
