using System;
using System.Text;
using DemoProject;

namespace Client
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ILectorArchivo lectora = new LectorArchivo();
            ProcesadorPalabras procesador = new ProcesadorPalabras(lectora);

            //Console.WriteLine(procesador.ContarCaracter()); //ContarPalabras());

            Producto producto = new Producto();

            producto.nombre = "Nevera";
            producto.descripcion = "Congelador para carnes";
            producto.precio = 325;

            var ProductoJson = System.Text.Json.JsonSerializer.Serialize(producto);

            Console.WriteLine(ProductoJson);
        }
    }
}
