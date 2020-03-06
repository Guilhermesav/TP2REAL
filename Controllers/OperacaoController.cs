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
            var result = _operacoesMatematicasService.OPSoma(operacoesMatematicasModel);

          

            return View("Result", operacoesMatematicasModel);
        }
        public IActionResult OPSub(OperacoesMatematicasModel operacoesMatematicasModel)
        {
            var result = _operacoesMatematicasService.OPSub(operacoesMatematicasModel);

         

            return View("result", operacoesMatematicasModel);
        }
        public IActionResult OPMult(OperacoesMatematicasModel operacoesMatematicasModel)
        {
            var result = _operacoesMatematicasService.OPMult(operacoesMatematicasModel);

      
            return View("result", operacoesMatematicasModel);
        }
        public IActionResult OPDiv(OperacoesMatematicasModel operacoesMatematicasModel)
        {
            var result = _operacoesMatematicasService.OPDiv(operacoesMatematicasModel);
         
            return View("result", operacoesMatematicasModel);
        }



    }
}