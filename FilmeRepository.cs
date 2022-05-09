using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAvalFilmes
{
    internal class FilmeRepository
    {
        List<Filme> filmes = new List<Filme>
        {
            new Filme("Indiana Jones: Os Salteadores da Arca Perdida", "Aventura/Ação", 1981) { Sinopse = "Epic tale in which an intrepid archaeologist tries to beat a band of Nazis to a unique religious relic which is central to their plans for world domination. Battling against a snake phobia and a vengeful ex-girlfriend, Indiana Jones is in constant peril, making hair's-breadth escapes at every turn in this celebration of the innocent adventure movies of an earlier era."},
            new Filme("A Dança dos Pássaros", "Documentário", 2020) { Sinopse = "Das técnicas de construção do pássaro jardineiro ao ballet da parotia da rainha Carola, conhecemos os artifícios e habilidades dos machos para impressionar as fêmeas e conseguir uma parceira para garantir a reprodução da espécie. O documentário de 50 minutos é um presente para quem gosta de aves." },
            new Filme("To Kill a Mocking Bird", "Drama", 1983),
            new Filme("Laranja Mecânica ", "Crime", 1971),
            new Filme("Pulp Fiction: Tempo de Violência", "Drama", 1994){ Sinopse="Vincent Vega (John Travolta) and Jules Winnfield (Samuel L. Jackson) are hitmen with a penchant for philosophical discussions. In this ultra-hip, multi-strand crime movie, their storyline is interwoven with those of their boss, gangster Marsellus Wallace (Ving Rhames) ; his actress wife, Mia (Uma Thurman) ; struggling boxer Butch Coolidge (Bruce Willis) ; master fixer Winston Wolfe (Harvey Keitel) and a nervous pair of armed robbers, \"Pumpkin\" (Tim Roth) and \"Honey Bunny\" (Amanda Plummer)." },
            new Filme("Bird Box", "Drama", 1983),
            new Filme("Tempos Modernos", "Drama", 1983),
            new Filme("Clube da Luta", "Drama", 1983),
            new Filme("Kill Bill Vol. 1", "Ação", 1983),
            new Filme("Kill Bill Vol. 2", "Ação", 1983),
            new Filme("Cães de Aluguel", "Drama", 1983)
        };

        public void AddFilme(string nome, string genero, int ano, string sinopse, double nota)
        {
            filmes.Add(new Filme(nome, genero, ano) { Sinopse = sinopse, Nota = nota });
        }


        public Filme[] ToArray()
        {
            return filmes.ToArray();
        }

        public Filme BuscaFilme(string Nome)
        {
            foreach (Filme filme in filmes)
            {
                if (filme.Nome == Nome)
                {
                    return filme;
                }
            }
            return null;
        }

        public Filme Last()
        {
            Filme ultimoFilmeAdicionado = null;
            foreach (Filme filme in filmes)
            {
                ultimoFilmeAdicionado = filme;
            }

            return ultimoFilmeAdicionado;
        }

        public void UpdateFilme(Filme filmeSelecionado)
        {
            foreach(Filme filme in filmes)
            {
                if(filme.Nome == filmeSelecionado.Nome)
                {
                    filme.Nome = filmeSelecionado.Nome;
                    filme.Genero = filmeSelecionado.Genero;
                    filme.Sinopse = filmeSelecionado.Sinopse;
                    filme.Nota = filmeSelecionado.Nota;
                    filme.AnoLancamento = filmeSelecionado.AnoLancamento;
                }
            }
        }

        public void RemoveFilme(Filme filmeSelecionado)
        {
            var filmeASerRemovido = filmes.Single(r => r.Nome == filmeSelecionado.Nome);

            filmes.Remove(filmeASerRemovido);
        }
    }
}
