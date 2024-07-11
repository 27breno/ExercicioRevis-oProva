using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRevisãoProva
{
    public  class Dependente : Pessoa 
    {
        public int Parentesco { get; set; }

        public Dependente(string nome, int parentesco)
            :base(nome)
        {
            Parentesco= parentesco;
        }
    }
}
