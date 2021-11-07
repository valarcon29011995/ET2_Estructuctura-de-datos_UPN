using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta01
{
    internal class Lista
    {
        Stack<Nodo> Listaprogramas = new Stack<Nodo>();

        public void AgregarPrograma(Nodo x)
        {
            Listaprogramas.Push(x);
        }

        public void ImprimirProgramas()
        {
            foreach (var Nodo in Listaprogramas)
            {
                Console.WriteLine(Nodo.ToString());
            }
        }

        public void Eliminar()
        {
            Listaprogramas.Pop();
        }
    }
}
