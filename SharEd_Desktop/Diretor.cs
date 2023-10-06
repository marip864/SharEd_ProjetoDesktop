using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharEd_Desktop
{
    class Diretor
    {
        private String nome, rg, email, cargo, telefone;
        private int nr;

        public Diretor(string nome, string rg, string email, string cargo, string telefone, int nr)
        {
            Nome = nome;
            Rg = rg;
            Email = email;
            Cargo = cargo;
            Telefone = telefone;
            Nr = nr;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Email { get => email; set => email = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public int Nr { get => nr; set => nr = value; }
    }
}
