using Data.Model;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class LutadorServices : ILutadorServices
    {
        private readonly ILutadorRepository _repository;
        public LutadorServices(ILutadorRepository repository)
        {
            _repository = repository;
        }
        public LutadorModel ObterLutadorComMaiorPorcentagem(LutadorModel lutador, LutadorModel lutador2)
        {
            double porcentagemLutador = ((double)lutador.Vitorias / lutador.TotalDeLutas) * 100;
            double porcentagemLutador2 = ((double)lutador2.Vitorias / lutador2.TotalDeLutas) * 100;
            if (porcentagemLutador > porcentagemLutador2)
            {
                _repository.AumentaVitorias(lutador);
                _repository.AumentaDerrotas(lutador2);
                return lutador;
            }
            if (porcentagemLutador == porcentagemLutador2)
            {
                return ObterVencedorDesempate(lutador, lutador2);
            }
            else
            {
                _repository.AumentaVitorias(lutador2);
                _repository.AumentaDerrotas(lutador);
                return lutador2;
            }
        }

        public LutadorModel ObterVencedorDesempate(LutadorModel lutador, LutadorModel lutador2)
        {
            if (lutador.ArtesMarciais != lutador2.ArtesMarciais)
            {
                if (lutador.ArtesMarciais > lutador2.ArtesMarciais)
                {
                    _repository.AumentaVitorias(lutador);
                    return lutador;
                }
                _repository.AumentaVitorias(lutador2);
                return lutador2;
            }
            if (lutador.TotalDeLutas > lutador2.TotalDeLutas)
            {
                _repository.AumentaVitorias(lutador);
                return lutador;
            }
            else
            {
                _repository.AumentaVitorias(lutador2);
                return lutador2;
            }
        }

        public LutadorModel ObterVencedorDuelo(LutadorModel lutador, LutadorModel lutador2)
        {
            _repository.AumentaTotaldeLutas(lutador, lutador2);
            return ObterLutadorComMaiorPorcentagem(lutador, lutador2);
        }
        public List<LutadorModel> RealizarCombates(List<LutadorModel> listaCombatentes)
        {
            List<LutadorModel> listaFinal = new List<LutadorModel>();
            int lutadoresAtuais = listaCombatentes.Count(); 
            int contadorLutas = (lutadoresAtuais / 2);      
            for (int rodada = 1; rodada <= 3; rodada++) 
            {
                int indexLutador = 0;
                int indexLutador2 = 1;
                List<LutadorModel> vencedoresRodada = new List<LutadorModel>();
                for (int lutas = 1; lutas <= contadorLutas; lutas++) 
                {
                    LutadorModel vencedor = ObterVencedorDuelo(listaCombatentes[indexLutador], listaCombatentes[indexLutador2]);
                    vencedoresRodada.Add(vencedor);
                    indexLutador += 2;
                    indexLutador2 += 2;
                }
                lutadoresAtuais = vencedoresRodada.Count(); 
                contadorLutas = (lutadoresAtuais / 2);
                listaCombatentes = vencedoresRodada;
                listaFinal = listaCombatentes;
            }
            return listaFinal;
    }
        public List<LutadorModel> ObterResultadoDueloFinal(List<LutadorModel> listaCombatentes)
        {
            int indexLutador = 0;
            int indexLutador2 = 1;
            List<LutadorModel> winnerAndLoser = new List<LutadorModel>();
            LutadorModel winner = ObterVencedorDuelo(listaCombatentes[indexLutador], listaCombatentes[indexLutador2]);
            if (winner == listaCombatentes[0])
            {
                winnerAndLoser.Add(listaCombatentes[0]);
                winnerAndLoser.Add(listaCombatentes[1]);
                return winnerAndLoser;
            }
            else
            {
                winnerAndLoser.Add(listaCombatentes[1]);
                winnerAndLoser.Add(listaCombatentes[0]);
                return winnerAndLoser;
            }
        }
    }
}
