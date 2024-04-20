using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Operaciones
    {

        public static int Acumulador(int valor, int acumulador) {
            
            acumulador += valor;

            return acumulador;
        }
    }
}
