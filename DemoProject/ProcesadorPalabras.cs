using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    public class ProcesadorPalabras
    {
        ILectorArchivo lector;

        public ProcesadorPalabras(ILectorArchivo lectorArchivo)
        {
            this.lector = lectorArchivo;
        }

        public int ContarPalabras()
        {
            return lector.LeerArchivo("G:/WEBcore/PruebasUnitarias/ComandosDotnet.txt").
                Split("").Count();
        }

        public int ContarCaracter()
        {
            return lector.LeerArchivo("G:/WEBcore/PruebasUnitarias/ComandosDotnet.txt").Length;
        }
    }
}
