using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDP.Util
{
    public class StringUtils
    {
        public static String EsMayorDeEdad(int edad)
        {
            return edad >= 18 ? "Es mayor de Edad" : "Es menor de Edad";
        }

        public static Func<String, String> GenerarFuncionConvertirAMayusculas(bool mayuscula)
        {
            return mayuscula ? str => str.ToUpper() : str => str.ToLower();
        }
    }
}
