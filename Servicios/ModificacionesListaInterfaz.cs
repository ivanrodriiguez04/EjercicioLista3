using EjercicioLista3.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLista3.Servicios
{
    internal interface ModificacionesListaInterfaz
    {
        /// <summary>
        /// Metodo que da del alta a un nuevo cliente
        /// 20/11/2023 -> irm
        /// </summary>
        /// <param name=""></param>
        public void darAltaCliente(List<ClienteDto> listaClienteAntigua);
        /// <summary>
        /// Metodo que da el alta a una nueva cuenta
        /// 20/11/2023 -> irm
        /// </summary>
        /// <param name="listaCuentaAntigua"></param>
        public void darAltaCuenta(List<CuentaDto> listaCuentaAntigua);
        /// <summary>
        /// Metodo que modifica la informacion 
        /// </summary>
        /// <param name="listaClienteAntigua"></param>
        public void modificarCliente(List<ClienteDto> listaClienteAntigua);
    }
}
