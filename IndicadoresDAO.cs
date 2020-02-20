using System;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Dapper;

namespace APIIndicadores
{
    public class IndicadoreDAO
    {
        private Iconfiguration _config;

        public IndicadoresDAO(Iconfiguration configuracoes)
        {
            __config = configuracoes;
        }

        public Indicador Obter( string codIndicador)
        {
            using (SqlConnection conexao = new SqlConnection(
                _config.GetConnectionString
            ))
        }
    }
}