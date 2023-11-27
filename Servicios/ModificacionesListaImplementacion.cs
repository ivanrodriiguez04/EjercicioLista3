using EjercicioLista3.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLista3.Servicios
{
        /// <summary>
        /// Clase que implementa a la interfaz de las modificaciones de lista
        /// 20/11/2023 -> irm
        /// </summary>
        internal class ModificacionesListaImplementacion : ModificacionesListaInterfaz
        {
            public void darAltaCliente(List<ClienteDto> listaClienteAntigua)
            {
                ClienteDto nuevoCliente = crearCliente();

                listaClienteAntigua.Add(nuevoCliente);
            }

            public void darAltaCuenta(List<CuentaDto> listaCuentaAntigua)
            {
                CuentaDto nuevaCuenta = crearCuenta();

                listaCuentaAntigua.Add(nuevaCuenta);
            }

        public void modificarCliente(List<ClienteDto> listaClienteAntigua)
        {
            ClienteDto antiguoCliente= new ClienteDto();
            string dni = pedirDNI();
            foreach (ClienteDto cliente in listaClienteAntigua) 
            {
                if (dni == antiguoCliente.DniCliente) 
                { 
                
                }
            }
        }

        /// <summary>
        /// Metodo en el cual se pide toda la informacion necesario del cliente
        /// 20/11/2023 -> irm
        /// </summary>
        /// <returns></returns>
        private ClienteDto crearCliente()
            {

                //Creamos un  objeto cliente
                ClienteDto nuevoCliente = new ClienteDto();
                //le pedimos al usuario la informacion necesaria
                Console.WriteLine("Introduzca el id del cliente: ");
                nuevoCliente.IdCliente = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Introduzca su nombre:");
                nuevoCliente.NombreCliente = Console.ReadLine();
                Console.WriteLine("Introduzca sus apellidos:");
                nuevoCliente.ApellidosCliente = Console.ReadLine();
                Console.WriteLine("Introduzca su dni");
                nuevoCliente.DniCliente = Console.ReadLine();
                Console.WriteLine("Introduzca su cumpleaños:");
                nuevoCliente.FchNacimientoCliente = Console.ReadLine();
                Console.WriteLine("Introduzca su email:");
                nuevoCliente.EmailCliente = Console.ReadLine();
                Console.WriteLine("Introduzca su numero telefonico");
                nuevoCliente.TlfCliente = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduzca la fecha del alta del cliente:");
                nuevoCliente.FchAltaCliente = Console.ReadLine();
                Console.WriteLine("Introduzca la fecha de la baja del cliente:");
                nuevoCliente.FchBajaCliente = Console.ReadLine();
                return nuevoCliente;
            }
            /// <summary>
            /// Metodo que pide al usuario toda la informacion necesaria de la cuenta
            /// 20/11/2023 -> irm
            /// </summary>
            /// <returns></returns>
            private CuentaDto crearCuenta()
            {
                //Creamos el objeto cuenta
                CuentaDto nuevaCuenta = new CuentaDto();
                //Le pedimos al usuario toda la informacion necesaria
                Console.WriteLine("Introduzca el dni del cliente:");
                nuevaCuenta.DniCliente = Console.ReadLine();
                Console.WriteLine("Introduzca el id de la cuenta:");
                nuevaCuenta.IdCuenta = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Introduzca el IBAN:");
                nuevaCuenta.Iban = Console.ReadLine();
                Console.WriteLine("Introduzca la fecha del alta de la cuenta:");
                nuevaCuenta.FchAltaCuenta = Console.ReadLine();
                Console.WriteLine("Introduzca la fecha de la baja de la cuenta:");
                nuevaCuenta.FchBajaCuenta = Console.ReadLine();
                return nuevaCuenta;
            }
        /// <summary>
        /// metodo que pide el dni del cliente a modificar al usuario
        /// 27/11/2023 -> irm
        /// </summary>
        /// <returns></returns>
        private string pedirDNI() 
        {
            string dni;
            Console.WriteLine("Introduzca el dni del cliente a modificar:");
            dni= Console.ReadLine();
            return dni;
        }
        }
}
