using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRevisãoProva
{
    public class Funcionario : Pessoa
    {
        private int Matricula { get; set; }

        private string Placaveiculo { get; set; } 

        public Funcionario(string nome,int matricula, string placaveiculo)
            :base(nome)
        {
            Matricula= matricula;
            Placaveiculo= placaveiculo;
        }

        public int ValorMaticula()
        {
            return Matricula;
        }
        public Boolean VerificarVeiculo(Automovel automovel)
        {
            Console.WriteLine(" vamos verficar se a sua placa possui uma placa com 7 digitos");

            if(Placaveiculo.Length == 7)
            {
               
                return true;
            }
            else
            {
                return false;
            }

           
        }
    }
}
