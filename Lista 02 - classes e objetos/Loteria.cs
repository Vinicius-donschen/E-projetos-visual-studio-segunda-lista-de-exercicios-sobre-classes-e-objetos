using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lista_02___classes_e_objetos
{
    class Loteria
    {
        public int totalNumeros;
        public int[] numerosSorteados = new int[6]; 
        public void sortear()
        {
            Random random = new Random();

            Console.WriteLine("os numeros sorteados foram: ");

            for (int i = 0; i < totalNumeros; i++)
            {
                int sorteado = random.Next(50);
                while (checarRepitido(sorteado))
                {
                    sorteado = random.Next(50);
                }
                numerosSorteados[i] = sorteado;
            }

            foreach (var item in numerosSorteados)
            {
                Console.WriteLine(item);
            }

        }

        private bool checarRepitido(int sorteado)
        {
            bool repitido = false;
            foreach (var numero in numerosSorteados)
            {
                repitido = sorteado == numero;
                if (repitido)
                {
                    break;
                }
            }
            return repitido;
        }
    }
}
