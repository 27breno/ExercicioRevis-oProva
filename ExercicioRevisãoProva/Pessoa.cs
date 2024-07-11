using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRevisãoProva
{
    public class Pessoa
    {
        public string  Nome { get; set; }

        public Pessoa (string nome)
        {
            Nome = nome;
        }

        public Boolean contratar()
        {
            Console.WriteLine("Funcionario cantratado com sucesso !!");

            return true;
        }


    }
}
