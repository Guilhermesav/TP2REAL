using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP2REAL.Models;
using TP2REAL.Repository;

namespace TP2REAL.Services
{
    public class OperacoesMatematicasService
    {
        private readonly IOperacaoRepository _operacaoMdfRepository;

        public OperacoesMatematicasService(IOperacaoRepository operacaoMdfRepository)
        {
           _operacaoMdfRepository = operacaoMdfRepository;
        }
        public double OPSoma(OperacoesMatematicasModel operacoesMatematicasModel)
        {
            var result = operacoesMatematicasModel.Numero1 + operacoesMatematicasModel.Numero2;
            operacoesMatematicasModel.Result = result;
            _operacaoMdfRepository.Add(operacoesMatematicasModel);
            return result;
        }
        public double OPSub(OperacoesMatematicasModel operacoesMatematicasModel)
        {
            var result = operacoesMatematicasModel.Numero1 - operacoesMatematicasModel.Numero2;
            operacoesMatematicasModel.Result = result;
            _operacaoMdfRepository.Add(operacoesMatematicasModel);
            return result;
        }
        public double OPMult(OperacoesMatematicasModel operacoesMatematicasModel)
        {
            var result = operacoesMatematicasModel.Numero1 * operacoesMatematicasModel.Numero2;
            operacoesMatematicasModel.Result = result;
            _operacaoMdfRepository.Add(operacoesMatematicasModel);
            return result;
            
        }
        public double OPDiv(OperacoesMatematicasModel operacoesMatematicasModel)
        {
            var result = operacoesMatematicasModel.Numero1 / operacoesMatematicasModel.Numero2;
            operacoesMatematicasModel.Result = result;
            _operacaoMdfRepository.Add(operacoesMatematicasModel);
            return result;
        }
        

        }
}
