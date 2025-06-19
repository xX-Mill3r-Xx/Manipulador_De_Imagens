using InserirAnexo.Models;
using InserirAnexo.ServiceContracts;
using System;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace InserirAnexo.Services
{
    public class OSD_ordem_servico_anexoService : IOSD_ordem_servico_anexo<OSD_ordem_servico_anexo>
    {
        private readonly string _connectionString;

        public OSD_ordem_servico_anexoService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<OSD_ordem_servico_anexo> Inserir(OSD_ordem_servico_anexo entity)
        {
            try
            {
                var sql = @"INSERT INTO OSD_ordem_servico_anexo(
	                                                oax_codserv,
	                                                ods_codtemp,
	                                                oax_descricao,
	                                                oax_imagem,
	                                                oax_extensao
	                                                )
                                                    VALUES(
	                                                @oax_codserv,
	                                                @ods_codtemp,
	                                                @oax_descricao,
	                                                @oax_imagem,
	                                                @oax_extensao); 
                            SELECT CAST(SCOPE_IDENTITY() as BIGINT);";
                using (var connection = new SqlConnection(_connectionString))
                {
                    long generatedId = await connection.ExecuteScalarAsync<long>(sql, new
                    {
                        entity.oax_codserv,
                        entity.ods_codtemp,
                        entity.oax_descricao,
                        entity.oax_imagem,
                        entity.oax_extensao
                    });

                    entity.oax_codtemp = generatedId;
                }
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir anexo", ex);
            }
        }

        public Task<OSD_ordem_servico_anexo> ObterPorId(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<OSD_ordem_servico_anexo>> ObterTodos(long oax_codserv)
        {
            try
            {
                var sql = @"SELECT oax_codtemp, oax_codserv, ods_codtemp, oax_data, oax_descricao,
                            oax_imagem, oax_extensao FROM OSD_ordem_servico_anexo WHERE oax_codserv = @oax_codserv";
                using (var connection = new SqlConnection(_connectionString))
                {
                    return await connection.QueryAsync<OSD_ordem_servico_anexo>(sql, new { oax_codserv });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao recuperar anexo da base de dados", ex);
            }
        }
    }
}
