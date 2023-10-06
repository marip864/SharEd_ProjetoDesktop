using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharEd_Desktop
{
    class Aluno
    {
        private String nome,rg,nascimento,telefone,email;
        private int ra,serie;

        public Aluno()
        {
        }

        public Aluno(string nome, string rg, string nascimento, string telefone, string email, int ra, int serie)
        {
            Nome = nome;
            Rg = rg;
            Nascimento = nascimento;
            Telefone = telefone;
            Email = email;
            Ra = ra;
            Serie = serie;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Nascimento { get => nascimento; set => nascimento = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public int Ra { get => ra; set => ra = value; }
        public int Serie { get => serie; set => serie = value; }
    }
}
