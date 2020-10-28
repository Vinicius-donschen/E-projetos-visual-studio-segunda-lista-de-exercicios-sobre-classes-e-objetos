using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lista_02___classes_e_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculadora calculadora = new Calculadora();
            //calculadora.operacao();

            //Tabuada tabuada = new Tabuada();
            //tabuada.potencia = 9;
            //tabuada.calcular();

            //Funcionario funcionario = new Funcionario();
            //funcionario.nome = "João";
            //funcionario.sexo = "masculino";
            //funcionario.setor = "informática";
            //funcionario.imprimeDados();

            Loteria loteria = new Loteria();
            loteria.totalNumeros = 6;
            loteria.sortear();
        }
    }
}
