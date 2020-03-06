using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP2REAL.Models;

namespace TP2REAL.Repository
{
    public interface IOperacaoRepository
    {
        IEnumerable<OperacoesMatematicasModel> GetAll();

        void Add(OperacoesMatematicasModel newOperacoesMatematicasModel);
    }
}
