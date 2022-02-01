using PDV_Pro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Pro.Domain.Interfaces.Repositorios
{
    public interface IClienteRepositorio
    {
        Task<bool> ExistePorIdAsync(string clienteId);
        Task CriarAsync(Cliente cliente);
        Task AtualizarAsync(Cliente cliente);
        Task DeletarPorIdAsync(string clienteId);
        Task<Cliente> BuscarPorIdAsync(string clienteId);
        Task<List<Cliente>> ListaDeClientesAsync(string clienteId = null, string name = null);
    }
}
