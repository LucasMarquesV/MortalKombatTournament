using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Services;
using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace MortalKombat1.Controllers
{
    public class LutadoresController : Controller
    {
        private readonly ILutadorRepository _repository;
        private readonly ILutadorServices _services;

        public LutadoresController(ILutadorRepository repository, ILutadorServices services)
        {
            _repository = repository;
            _services = services;
        }
        
        public IActionResult Selecao()
        {
            List<LutadorModel> listaLutadores = _repository.ObterListaPorId();
            return View(listaLutadores);
        }

        public IActionResult DueloFinal(List<int> lutadoresSelecionados)
        {
            List<LutadorModel> listaLutadoresOrdenada = _repository.ObterListaPorIdade(lutadoresSelecionados);
            listaLutadoresOrdenada = _services.RealizarCombates(listaLutadoresOrdenada);
            listaLutadoresOrdenada = _services.ObterResultadoDueloFinal(listaLutadoresOrdenada);
            return View(listaLutadoresOrdenada);
        }
        public IActionResult FinishHim(List<int> finalistasSelecionados)
        {
            List<LutadorModel> listaOrdenada = _repository.ObterListaPorIdade(finalistasSelecionados);
            return View(listaOrdenada);
        }
        public IActionResult Vencedor(List<int> finalistasSelecionados)
        {
            List<LutadorModel> listaOrdenada = _repository.ObterListaPorIdade(finalistasSelecionados);
            return View(listaOrdenada);
        }
    }
}
