using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharEd_Desktop
{
    class Professor
    {
        private String nome, rg, series, materias, telefone, email;
        private int nr;

        public Professor(string nome, string rg, string series, string materias, string telefone, string email, int nr)
        {
            Nome = nome;
            Rg = rg;
            Series = series;
            Materias = materias;
            Telefone = telefone;
            Email = email;
            Nr = nr;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Series { get => series; set => series = value; }
        public string Materias { get => materias; set => materias = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public int Nr { get => nr; set => nr = value; }
    }
}
