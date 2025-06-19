using System.Collections.Generic;
using System.Threading.Tasks;

namespace InserirAnexo.ServiceContracts
{
    public interface IOSD_ordem_servico_anexo<T> where T : class
    {
        Task<IEnumerable<T>> ObterTodos(long cod_temp);
        Task<T> ObterPorId(long cod_temp);
        Task<T> Inserir(T entity);
    }
}
