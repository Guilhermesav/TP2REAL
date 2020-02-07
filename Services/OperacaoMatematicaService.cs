using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP2REAL.Models;

namespace TP2REAL.Services
{
    public class OperacoesMatematicasService
    {
        public double OPSoma(OperacoesMatematicasModel operacoesMatematicasModel)
        {
            var resultado = operacoesMatematicasModel.numero1 + operacoesMatematicasModel.numero2;

            return resultado;
        }
        public double OPSub(OperacoesMatematicasModel operacoesMatematicasModel)
        {
            var resultado = operacoesMatematicasModel.numero1 - operacoesMatematicasModel.numero2;

            return resultado;
        }
        public double OPDiv(OperacoesMatematicasModel operacoesMatematicasModel)
        {
            var resultado = operacoesMatematicasModel.numero1 / operacoesMatematicasModel.numero2;

            return resultado;
        }
        public double OPMult(OperacoesMatematicasModel operacoesMatematicasModel)
        {
            var resultado = operacoesMatematicasModel.numero1 * operacoesMatematicasModel.numero2;

            return resultado;
        }
    }
}
