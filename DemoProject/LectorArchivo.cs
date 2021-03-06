using System;
using System.IO;

namespace DemoProject
{
    public class LectorArchivo : ILectorArchivo
    {
        public string LeerArchivo(string rutaArchivo)
        {
            StreamReader strRead = new StreamReader(rutaArchivo);

            string result = strRead.ReadToEnd();
            strRead.Close();

            return result;
        }
    }

    public interface ILectorArchivo
    {
        string LeerArchivo(string rutaArchivo);
    }
}
