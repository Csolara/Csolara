using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csolara.Servicios
{
    /// <summary>
    /// Interfaz que contiene los metodos del menu.
    /// csl - 041223
    /// </summary>
    internal interface menuINT
    {
        /// <summary>
        /// Metodo que muestra las opciones al usuario y recoge la opcion que ha seleccionado.
        /// csl - 041223
        /// </summary>
        /// <returns></returns>
        public int SeleccionUsuario();
    }
}
