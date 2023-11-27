using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLista3.Dtos
{
    /// <summary>
    /// Clase donde estan toda la informacion que se va a utilizar
    /// 21/11/2023 -> irm
    /// </summary>
    internal class ClienteDto
    {
        //Atributos
        private long idCliente;
        private string nombreCliente = "aaaaa";
        private string apellidosCliente = "aaaaa";
        private string dniCliente;
        private string fchNacimientoCliente = "9999/12/31";
        private string emailCliente = "aaaaa";
        private int tlfCliente = 111111111;
        private string fchAltaCliente = "9999/12/31";
        private string fchBajaCliente = "9999/12/31";


        //Getters & Setters
        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string FchNacimientoCliente { get => fchNacimientoCliente; set => fchNacimientoCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public int TlfCliente { get => tlfCliente; set => tlfCliente = value; }
        public string FchAltaCliente { get => fchAltaCliente; set => fchAltaCliente = value; }
        public string FchBajaCliente { get => fchBajaCliente; set => fchBajaCliente = value; }

        //Constructores
        public ClienteDto(long idCliente, string nombreCliente, string apellidosCliente, string dniCliente, string fchNacimientoCliente, string emailCliente, int tlfCliente, string fchAltaCliente, string fchBajaCliente)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.dniCliente = dniCliente;
            this.fchNacimientoCliente = fchNacimientoCliente;
            this.emailCliente = emailCliente;
            this.tlfCliente = tlfCliente;
            this.fchAltaCliente = fchAltaCliente;
            this.fchBajaCliente = fchBajaCliente;
        }
        public ClienteDto()
        {

        }
        //Metodo ToString
        override
        public string ToString()
        {
            string clienteString ="Nombre: " + this.nombreCliente + "\n" + "Apellidos: " + this.apellidosCliente + "\n" +
                "DNI: " + this.dniCliente + "\n" + "Fecha de nacimiento:" + this.fchNacimientoCliente + "\n" +
                "Email:" + this.emailCliente + "\n" + "Teléfono: " + this.tlfCliente + "\n" +
                "Fecha del alta del cliente: " + this.fchAltaCliente + "\n" + "Fecha de la baja del cliente: " + this.fchBajaCliente;

            return clienteString;
        }
    }
}
