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
            var result = operacoesMatematicasModel.numero1 + operacoesMatematicasModel.numero2;

            return result;
        }
        public double OPSub(OperacoesMatematicasModel operacoesMatematicasModel)
        {
            var result = operacoesMatematicasModel.numero1 - operacoesMatematicasModel.numero2;

            return result;
        }
        public double OPMult(OperacoesMatematicasModel operacoesMatematicasModel)
        {
            var result = operacoesMatematicasModel.numero1 * operacoesMatematicasModel.numero2;

            return result;
            
        }
        public double OPDiv(OperacoesMatematicasModel operacoesMatematicasModel)
        {
            var result = operacoesMatematicasModel.numero1 / operacoesMatematicasModel.numero2;

            return result;
        }
        

        }
}
