using Dapper;
using InserirAnexo.Models;
using InserirAnexo.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InserirAnexo.Services
{
    public class OSD_ordem_servicoService : IOSD_ordem_servico<OSD_ordem_servico>
    {
        private readonly string _connectionString;

        public OSD_ordem_servicoService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<IEnumerable<OSD_ordem_servico>> ObterTodos()
        {
            try
            {
                var sql = @"select 
                            ods_codtemp,
                            ods_codserv,
                            ods_informacoes
                            from OSD_ordem_servico";
                using (var connection = new SqlConnection(_connectionString))
                {
                    return await connection.QueryAsync<OSD_ordem_servico>(sql);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter todas as ordens de serviço", ex);
            }
        }

        public Task<OSD_ordem_servico> Atualizar(OSD_ordem_servico entity)
        {
            throw new NotImplementedException();
        }

        public Task<OSD_ordem_servico> Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<OSD_ordem_servico> Inserir(OSD_ordem_servico entity)
        {
            throw new NotImplementedException();
        }

        public Task<OSD_ordem_servico> ObterPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
