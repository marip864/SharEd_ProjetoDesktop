using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharEd_Desktop
{
    class Administrador
    {
        private String nome, rg, cargo, telefone, email;
        private int nr;

        public Administrador(string nome, string rg, string cargo, string telefone, string email, int nr)
        {
            Nome = nome;
            Rg = rg;
            Cargo = cargo;
            Telefone = telefone;
            Email = email;
            Nr = nr;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public int Nr { get => nr; set => nr = value; }
    }
}
