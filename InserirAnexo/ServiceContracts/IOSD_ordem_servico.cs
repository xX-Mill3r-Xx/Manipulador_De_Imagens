using System.Collections.Generic;
using System.Threading.Tasks;

namespace InserirAnexo.ServiceContracts
{
    public interface IOSD_ordem_servico<T> where T : class
    {
        Task<IEnumerable<T>> ObterTodos();
        Task<T> ObterPorId(int id);
        Task<T> Inserir(T entity);
        Task<T> Atualizar(T entity);
        Task<T> Deletar(int id);
    }
}
