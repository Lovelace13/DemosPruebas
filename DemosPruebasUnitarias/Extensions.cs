using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemosPruebasUnitarias
{
    public static class Extensions
    {
        public static bool AreSame(string x, string y)
        {
            return (string.IsNullOrEmpty(x) == string.IsNullOrEmpty(y));
        }
    }
}
