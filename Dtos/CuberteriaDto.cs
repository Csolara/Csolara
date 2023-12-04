using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csolara.Dtos
{
    /// <summary>
    /// clase principal que contendra todos los metodos de la Cuberteria
    /// csl - 041223
    /// </summary>
    internal class CuberteriaDto
    {
        int id = 0;

        string codigo = "aaaaa";

        string nombre = "aaaaa";

        string descripcion = "aaaaa";

        int cantidad = 0;
        
        public int Id { get => id; set => id = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        /// <summary>
        ///Constructor del metodo de Cuberteria.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="codigo"></param>
        /// <param name="nombre"></param>
        /// <param name="descripcion"></param>
        /// <param name="cantidad"></param>
        public CuberteriaDto(int id, string codigo, string nombre, string descripcion, int cantidad)
        {
            this.id = id;
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.cantidad = cantidad;
        }

        public CuberteriaDto() { }
    }
}
