using Data.Config;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class LutadorRepository : ILutadorRepository
    {
        private readonly ContextoBase _contextoBase;

        public LutadorRepository(ContextoBase contextoBase)
        {
            _contextoBase = contextoBase;
        }
        public void AumentaDerrotas(LutadorModel lutador)
        {
            lutador.Derrotas++;
            _contextoBase.SaveChanges();
        }

        public void AumentaTotaldeLutas(LutadorModel lutador, LutadorModel lutador2)
        {
            lutador.TotalDeLutas++;
            lutador2.TotalDeLutas++;
            _contextoBase.SaveChanges();
        }

        public void AumentaVitorias(LutadorModel lutador)
        {
            lutador.Vitorias++;
            _contextoBase.SaveChanges();
        }

        public List<LutadorModel> ObterListaPorId()
        {
            return _contextoBase.Lutadores.OrderBy(lutador => lutador.Id).ToList();            
        }

        public List<LutadorModel> ObterListaPorIdade(List<int> listaDeIdSelecionado)
        {
            var listaOrdenadaPorIdade = _contextoBase.Lutadores.Where
                (lutador => listaDeIdSelecionado.Contains(lutador.Id)).OrderBy(lutador => lutador.Idade).ToList();
            return listaOrdenadaPorIdade;
        }
    }
}
