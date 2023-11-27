using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLista3.Servicios
{
    /// <summary>
    /// Interfaz del menu
    /// 21/11/2023 -> irm
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra el menu y selecciona la opcion que desea el usuario
        /// 21/11/2023 -> ir,
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSeleccion();
    }
}
