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

        public void darAltaCuenta(List<CuentaDto> listaCuentaAntigua)
        {
            CuentaDto nuevaCuenta = crearCuenta();
            listaCuentaAntigua.Add(nuevaCuenta);
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

        public void modificarCliente(List<ClienteDto> listaClienteAntigua)
        {
            ClienteDto antiguoCliente = new ClienteDto();
            string dni = pedirDNI();
            bool cerrarMenu=false;
            int opcionIntroducida;
            foreach (ClienteDto cliente in listaClienteAntigua) 
            {
                if (dni == antiguoCliente.DniCliente) 
                { 
                    while (!cerrarMenu) 
                    {
                        opcionIntroducida=mostrarMenuModificacionesYSeleccion();
                        switch (opcionIntroducida) 
                        {
                            case 0:
                                Console.WriteLine("[INFO] - No se va ha modificar ningun dato");
                                Console.WriteLine("[INFO] - Se va a cerrar la opcion seleccionada");
                                cerrarMenu = true;
                                break;
                            case 1:
                                Console.WriteLine("[INFO] - Ha seleccionado modificar el nombre");
                                Console.WriteLine("Introduzca el nuevo nombre");
                                antiguoCliente.NombreCliente = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("[INFO] - Ha seleccionado modificar los apellidos");
                                Console.WriteLine("Introduzca los nuevos apellidos");
                                antiguoCliente.ApellidosCliente = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("[INFO] - Ha seleccionado modificar el dni");
                                Console.WriteLine("Introduzca el nuevo dni");
                                antiguoCliente.DniCliente = Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("[INFO] - Ha seleccionado modificar la fecha de nacimiento");
                                Console.WriteLine("Introduzca la nueva fecha de nacimiento");
                                antiguoCliente.FchNacimientoCliente = Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("[INFO] - Ha seleccionado modificar el email");
                                Console.WriteLine("Introduzca el nuevo email");
                                antiguoCliente.EmailCliente = Console.ReadLine();
                                break;
                            case 6:
                                Console.WriteLine("[INFO] - Ha seleccionado modificar el telefono");
                                Console.WriteLine("Introduzca el nuevo telefono");
                                antiguoCliente.TlfCliente=Convert.ToInt32(Console.ReadLine());
                                break;
                            default:
                                Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna.");
                                break;
                        }
                    
                    }
                }
            }
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
        /// <summary>
        /// Metodo que muestra el menu de modificacion y selecciona la opcion deseada por el usuario
        /// 28/11/2023 -> irm
        /// </summary>
        /// <returns></returns>
        private int mostrarMenuModificacionesYSeleccion()
        {
            int opcion;
            Console.WriteLine("0. No quiero modificar nada");
            Console.WriteLine("1. Modificar nombre");
            Console.WriteLine("2. Modificar apellidos");
            Console.WriteLine("3. Modificar dni");
            Console.WriteLine("4. Modificar fecha de nacimiento");
            Console.WriteLine("5. Modificar email");
            Console.WriteLine("6. Modificar  telefono");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }

    }
}
