using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLista3.Dtos
{    /// <summary>
     /// Clase donde estan toda la informacion de la cuenta que se va a utilizar
     /// 21/11/2023 -> irm
     /// </summary>
    internal class CuentaDto
    {
        //Atributos
        private string dniCliente = "aaaaa";
        private long idCuenta;
        private string iban = "aaaaa";
        private string codidoSwitch = "CSISSXX";
        private string fchAltaCuenta = "9999/12/31";
        private string fchBajaCuenta = "9999/12/31";

        //Getters & Setters
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public long IdCuenta { get => idCuenta; set => idCuenta = value; }
        public string Iban { get => iban; set => iban = value; }
        public string CodidoSwitch { get => codidoSwitch; set => codidoSwitch = value; }
        public string FchAltaCuenta { get => fchAltaCuenta; set => fchAltaCuenta = value; }
        public string FchBajaCuenta { get => fchBajaCuenta; set => fchBajaCuenta = value; }

        //Constructores
        public CuentaDto(string dniCliente, long idCuenta, string iban, string codidoSwitch, string fchAltaCuenta, string fchBajaCuenta)
        {
            this.dniCliente = dniCliente;
            this.idCuenta = idCuenta;
            this.iban = iban;
            this.codidoSwitch = codidoSwitch;
            this.fchAltaCuenta = fchAltaCuenta;
            this.fchBajaCuenta = fchBajaCuenta;
        }

        public CuentaDto()
        {
        }

        //Metodo ToString
        public string ToString()
        {
            string cuentaString = "Dni del cliente:" + this.dniCliente + "\n" +
            "IBAN: " + this.iban + "\n" + "Codigo Switch: " + this.codidoSwitch + "\n" +
            "Fecha del alta de la cuenta: " + this.fchAltaCuenta + "\n" + "Fecha de la baja de la cuenta: " + this.fchBajaCuenta;

            return cuentaString;
        }
    }
}
