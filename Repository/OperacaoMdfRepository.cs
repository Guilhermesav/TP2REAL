using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP2REAL.Models;
using System.Data;
using Microsoft.Data.SqlClient;
using TP2REAL.Repository;

namespace TP2REAL.Repository
{
    public class OperacaoMdfRepository : IOperacaoRepository
    {
        private readonly string  _connectionString
            = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\guilherme.nascimento\Documents\Operacoes.mdf;Integrated Security=True;Connect Timeout=30";

        public IEnumerable<OperacoesMatematicasModel> GetAll()
        {
            var cmdText = $"SELECT Numero1, Numero2, Resultado FROM Operacao";

            var operacao = new List<OperacoesMatematicasModel>();

            using (var sqlConnection = new SqlConnection(_connectionString))
            using (var sqlCommand = new SqlCommand(cmdText, sqlConnection))
            {
                sqlCommand.CommandType = CommandType.Text;


                sqlConnection.Open();
                using (var reader = sqlCommand.ExecuteReader())
                {
                    var numero1ColumnIndex = reader.GetOrdinal("Numero1");
                    var numero2ColumnIndex = reader.GetOrdinal("Numero2");
                    var resultadoColumnIndex = reader.GetOrdinal("Resultado");
                    while (reader.Read())
                    {
                        var numero1 = reader.GetFieldValue<double>(numero1ColumnIndex);
                        var numero2 = reader.GetFieldValue<double>(numero2ColumnIndex);
                        var resultado = reader.GetFieldValue<double>(resultadoColumnIndex);

                        var novaOperacao = new OperacoesMatematicasModel
                        {
                            Numero1 = numero1,
                            Numero2 = numero2,
                            Result = resultado
                        };
                        operacao.Add(novaOperacao);
                    }
                }
            }
            return operacao;
        }
        public void Add(OperacoesMatematicasModel newOperacoesMatematicasModel)
        {
            var cmdText = "INSERT INTO Operacao" +
                "		(Numero1, Numero2,Resultado)" +
                "VALUES	(@operacaoNumero1, @operacaoNumero2,@operacaoResultado);";

            using (var sqlConnection = new SqlConnection(_connectionString)) 
            using (var sqlCommand = new SqlCommand(cmdText, sqlConnection)) 
            {
                sqlCommand.CommandType = CommandType.Text;

                sqlCommand.Parameters
                    .Add("@operacaoNumero1", SqlDbType.Int).Value = newOperacoesMatematicasModel.Numero1;
                sqlCommand.Parameters
                    .Add("@operacaoNumero2", SqlDbType.Int).Value = newOperacoesMatematicasModel.Numero2;
                sqlCommand.Parameters
                    .Add("@operacaoResultado", SqlDbType.Int).Value = newOperacoesMatematicasModel.Result;

                sqlConnection.Open();

                var resutScalar = sqlCommand.ExecuteScalar();
            }
        }
    }
}

