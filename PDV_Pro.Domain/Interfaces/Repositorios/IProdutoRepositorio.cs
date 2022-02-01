using PDV_Pro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Pro.Domain.Interfaces.Repositorios
{
    public interface IProdutoRepositorio
    {
        Task<bool> ExistePorIdAsync(string produtoId);
        Task CriarAsync(Produto produto);
        Task AtualizarAsync(Produto produto);
        Task DeletarPorIdAsync(string produtoId);
        Task<Produto> BuscarPorIdAsync(string produtoId);
        Task<List<Produto>> ListaDeProdutosAsync(string produtoId = null, string descricao = null);
    }
}
