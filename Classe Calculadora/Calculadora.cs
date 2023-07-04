using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Calculadora {
    internal class Calculadora {

        //utilizando params parametros variados( indicando que pode receber valores variaveis).
        public static int Soma(params int[] numeros) {
            int somas = 0;
            for(int i =0; i < numeros.Length; i++) {
                somas += numeros[i];
            }
            return somas;
        }
    }
}
