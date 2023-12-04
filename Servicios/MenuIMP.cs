using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csolara.Servicios
{
    /// <summary>
    /// Metodo que implementa la interfaz del menu.
    /// csl - 041223
    /// </summary>
    internal class MenuIMP : menuINT
    {
        /// <summary>
        /// Metodo que muestra el menu al usuario.
        /// csl - 041223
        /// </summary>
        /// <returns></returns>
        public int SeleccionUsuario()
        {
            int OpcionSeleccionada;

            Console.WriteLine("&======================&");
            Console.WriteLine("0. Cerrar menu.");
            Console.WriteLine("1. Dar alta cliente.");
            Console.WriteLine("2. Dar baja cliente.");
            Console.WriteLine("&======================&");

            OpcionSeleccionada = Console.ReadKey(true).KeyChar-('0');
            return OpcionSeleccionada;
        }
    }
}
