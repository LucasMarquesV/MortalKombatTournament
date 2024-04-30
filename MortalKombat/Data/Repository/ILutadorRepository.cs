using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public interface ILutadorRepository
    {
        List<LutadorModel> ObterListaPorId();
        List<LutadorModel> ObterListaPorIdade(List<int> listaDeIdSelecionado);
        public void AumentaVitorias(LutadorModel lutador);
        public void AumentaDerrotas(LutadorModel lutador);
        public void AumentaTotaldeLutas(LutadorModel lutador, LutadorModel lutador2);
    }
}
