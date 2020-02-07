using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TP2REAL.Models;
using TP2REAL.Services;

namespace TP2REAL.Controllers
{
    public class OperacaoController : Controller
    {
        private readonly OperacoesMatematicasService _operacoesMatematicasService;

        public OperacaoController(OperacoesMatematicasService operacoesMatematicasService)
        {
            _operacoesMatematicasService = operacoesMatematicasService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult OPSoma(OperacoesMatematicasModel operacoesMatematicasModel)
        {
            var resultado = _operacoesMatematicasService.OPSoma(operacoesMatematicasModel);

            return View("result",operacoesMatematicasModel);
        }
        
        

    }
}