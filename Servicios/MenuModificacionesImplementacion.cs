using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLista3.Servicios
{
    internal class MenuModificacionesImplementacion : MenuModificacionesInterfaz
    {
        public int mostrarMenuModificacionesYSeleccion()
        {
            int opcion;
            Console.WriteLine("0.No quiero modificar nada");
            Console.WriteLine("1. Modificar nombre");
            Console.WriteLine("2. Modificar apellidos");
            Console.WriteLine("3. Modificar dni");
            Console.WriteLine("4. Modificar fecha de nacimiento");
            Console.WriteLine("5. Modificar email");
            Console.WriteLine("6. Modificar  telefono");
            opcion=Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
    }
}