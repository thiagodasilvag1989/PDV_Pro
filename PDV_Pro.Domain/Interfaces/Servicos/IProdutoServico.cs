using PDV_Pro.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PDV_Pro.Domain.Interfaces.Servicos
{
    public interface IProdutoServico
    {
        Task CriarAsync(Produto produto);
        Task AtualizarAsync(Produto produto);
        Task DeletarPorIdAsync(string produtoId);
        Task<Produto> BuscarPorIdAsync(string produtoId);
        Task<List<Produto>> ListaDeClientesAsync(string produtoId = null, string name = null);
    }
}
