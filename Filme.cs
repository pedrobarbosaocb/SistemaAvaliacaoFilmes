using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAvalFilmes
{
    internal class Filme
    {
        public string Nome { get; set; }
        public string Genero { get; set; }
        public string Sinopse { get; set; } = "empty";
        public int AnoLancamento { get; set; }
        public double Nota { get; set; } = 0;

        public Filme(string nome, string genero, int anoLancamento)
        {
            Nome = nome;
            Genero = genero;
            AnoLancamento = anoLancamento;
        }
    }
}
