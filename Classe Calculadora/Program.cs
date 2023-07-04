using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Calculadora {
    internal class Program {
        static void Main(string[] args) {
            int s1 = Calculadora.Soma( 2, 3, 4, 5 );

            Console.WriteLine("Valores da soma utilizando metodo PARAMS: "+s1);

        }
    }
}
