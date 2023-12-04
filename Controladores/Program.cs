using Csolara.Dtos;
using Csolara.Servicios;

namespace Csolara.Controladores
{
    /// <summary>
    /// Clase principal de la apliación.
    /// csl - 041223
    /// </summary>
    class program
    {
        /// <summary>
        /// metodo principal de la aplicacion
        /// csl - 041223
        /// </summary>
        /// <param name="args"></param>
        static public void Main(string[] args)
        {
            menuINT mi = new MenuIMP();
            List<CuberteriaDto> list = new List<CuberteriaDto>();
            CuberteriaINT ci = new CuberteriaIMP();

            bool cerrarMenu = false;
            int Eleccion;

            while (!cerrarMenu)
            {
                Eleccion = mi.SeleccionUsuario();
                switch (Eleccion)
                {
                    case 0:
                        Console.WriteLine("Se cerrara el menu.");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("Se dara de alta");
                        ci.Cubiertos();
                        break;
                    case 2:
                        Console.WriteLine("Se dara de baja");
                        break;
                    default:
                        Console.WriteLine("La opcion que ha seleccionado es incorrecta");
                        break;
                }                
            }            
        }
    }
}