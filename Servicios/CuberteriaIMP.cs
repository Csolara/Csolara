using Csolara.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Csolara.Servicios
{
    /// <summary>
    /// Metodo que implementa la interfaz de la cuberteia.
    /// csl - 041223
    /// </summary>
    internal class CuberteriaIMP : CuberteriaINT
    {
        public void Cubiertos()
        {
            Console.WriteLine("Introduze tu id");
            int idElemento = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduze tu codigo");
            string codigoElemento = Console.ReadLine();

            Console.WriteLine("Introduze tu nombre");
            string nombreElemento = Console.ReadLine();

            Console.WriteLine("Introduze tu descripción");
            string descripcionElemento = Console.ReadLine();

            Console.WriteLine("Introduze cantidad");
            int cantidadElemento = Convert.ToInt32(Console.ReadLine());
        }
    }
}
