using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta01
{
    internal class Program
    {
        static Lista Lprogram = new Lista();
        static void Main(string[] args)
        {
            Lprogram.AgregarPrograma(new Nodo("Programa 1", "Suma"));
            Lprogram.AgregarPrograma(new Nodo("Programa 2", "Resta"));
            Lprogram.AgregarPrograma(new Nodo("Programa 3", "Multiplicación"));
            Lprogram.AgregarPrograma(new Nodo("Programa 4", "División"));
            Lprogram.AgregarPrograma(new Nodo("Programa 5", "Suma"));
            Console.WriteLine("+++++++++++++++Lista de Programas++++++++++++++++++");
            Lprogram.ImprimirProgramas();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++");             
            Console.WriteLine("++++++++++Eliminar 2 Ultimos ingresos++++++++++++++");
            Lprogram.Eliminar();
            Lprogram.Eliminar();
            Console.WriteLine("+++++++++++++++Lista de Programas++++++++++++++++++");
            Lprogram.ImprimirProgramas();
            Console.Read();
        }
        
    }
}
