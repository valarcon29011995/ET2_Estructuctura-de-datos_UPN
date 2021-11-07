using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ColaDePrioridad.Nodo cola1;
            cola1 = ColaDePrioridad.NuevoNodo(new ColaDePrioridad.Alumno("N1010", "Victor", "Alarcon", 1));
            cola1 = ColaDePrioridad.push(cola1, new ColaDePrioridad.Alumno("N1020", "Manuel", "Arroyo", 2 ));
            cola1 = ColaDePrioridad.push(cola1, new ColaDePrioridad.Alumno("N1030", "Miriam", "Catellanos", 3));
            cola1 = ColaDePrioridad.push(cola1, new ColaDePrioridad.Alumno("N1040", "Pamela", "Arroyo", 4));
            cola1 = ColaDePrioridad.push(cola1, new ColaDePrioridad.Alumno("N1050", "Heidi", "Arroyo", 5));
            Console.WriteLine("Agregando Alumnos por orden de llegada....");
            Console.WriteLine("******** Mostramos todos los alumnos **********\n");
            ColaDePrioridad.ImprimirLista(cola1);
            Console.WriteLine("******** Agregando Alumno con alta Prioridad 0 **********\n");
            cola1 = ColaDePrioridad.push(cola1, new ColaDePrioridad.Alumno("N1050", "Diego", "Machuca", 0));
            Console.WriteLine("******** Mostramos los alumnos **********\n");
            ColaDePrioridad.ImprimirLista(cola1);
            Console.Read();
        }
    }
    class ColaDePrioridad
    {
        public class Nodo
        {
            public Alumno alumno;
            public Nodo siguiente;
        }

        public class Alumno
        {
            public string ID, Nombre, Apellido;
            public int Prioridad;
            public Alumno(string ID, string Nombre, string Apellido, int Prioridad)
            {
                this.ID = ID;
                this.Nombre = Nombre;
                this.Apellido = Apellido;
                this.Prioridad = Prioridad;
            }
            public override string ToString()
            {
                return $"ID: {this.ID}\nNOMBRE y APELLIDO : {this.Nombre} {this.Apellido}\nPrioridad: {this.Prioridad}\n";
            }
        }




        public static Nodo nodo = new Nodo();

        public static Nodo NuevoNodo(Alumno x)
        {
            Nodo temp = new Nodo();
            temp.alumno = x;
            temp.siguiente = null;
            return temp;
        }

        public static Alumno top(Nodo cabeza)
        {
            return (cabeza).alumno;
        }

        public static Nodo pop(Nodo cabeza)
        {
            Nodo temp = cabeza;
            (cabeza) = (cabeza).siguiente;
            return cabeza;
        }

        public static Nodo push(Nodo cabeza, Alumno x)
        {
            Nodo puntero = (cabeza);
            Nodo temp = NuevoNodo(x);
            if ((cabeza).alumno.Prioridad > x.Prioridad)
            {
                temp.siguiente = cabeza;
                (cabeza) = temp;
            }
            else
            {
                while (puntero.siguiente != null &&
                    puntero.siguiente.alumno.Prioridad < x.Prioridad)
                {
                    puntero = puntero.siguiente;
                }
                temp.siguiente = puntero.siguiente;
                puntero.siguiente = temp;
            }
            return cabeza;
        }

        public static bool isEmpty(Nodo cabeza)
        {
            if (cabeza == null)
            {
                return true;
            }
            return false;
        }
        public static void ImprimirLista(Nodo cola1)
        {
            while (!ColaDePrioridad.isEmpty(cola1))
            {
                Console.WriteLine("{0:D} ", ColaDePrioridad.top(cola1));
                cola1 = ColaDePrioridad.pop(cola1);
            }
        }

    }

}
