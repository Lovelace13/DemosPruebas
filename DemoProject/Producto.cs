using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    public class Producto
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public string fullDescripcion {
            get
            {
                return nombre + " - " + descripcion;
            } 
        }

        public decimal Impuesto
        {
            get
            {
                return precio * Convert.ToDecimal(0.19);
            }
        }

    }
}
