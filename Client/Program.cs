using System;
using DemoProject;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ILectorArchivo lectora = new LectorArchivo();
            ProcesadorPalabras procesador = new ProcesadorPalabras(lectora);

            Console.WriteLine(procesador.ContarCaracter()); //ContarPalabras());
        }
    }
}
