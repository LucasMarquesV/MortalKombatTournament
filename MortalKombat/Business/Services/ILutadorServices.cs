using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public interface ILutadorServices
    {
        LutadorModel ObterVencedorDuelo(LutadorModel lutador, LutadorModel lutador2);
        LutadorModel ObterLutadorComMaiorPorcentagem(LutadorModel lutador, LutadorModel lutador2);
        LutadorModel ObterVencedorDesempate(LutadorModel lutador, LutadorModel lutador2);
        public List<LutadorModel> ObterResultadoDueloFinal(List<LutadorModel> listaCombatentes);
        public List<LutadorModel> RealizarCombates(List<LutadorModel> listaCombatentes);
    }
}
