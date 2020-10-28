using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_02___classes_e_objetos
{
    class Funcionario
    {
        public string nome;
        public string sexo;
        public string setor;

        public void imprimeDados()
        {
            Console.WriteLine($"nome do funcionário: {nome}");
            Console.WriteLine($"sexo: {sexo}");
            Console.WriteLine($"setor: {setor}");
        }
    }
}
