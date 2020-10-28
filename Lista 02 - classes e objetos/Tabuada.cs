using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_02___classes_e_objetos
{
    class Tabuada
    {
        public int potencia;
        public int resultado;

        public void calcular()
        {
            for (int i = 0; i < 11; i++)
            {
                resultado = potencia * i;
                Console.WriteLine($"{potencia} x {i} = {resultado}");
            }
        }
    }
}
