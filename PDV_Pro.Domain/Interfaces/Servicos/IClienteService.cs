using PDV_Pro.Domain.Models;
using PDV_Pro.Domain.Validações.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Pro.Domain.Interfaces.Servicos
{
    public interface IClienteService
    {
        Task<Response> CriarAsync(Cliente cliente);
        Task<Response> AtualizarAsync(Cliente cliente);
        Task<Response> DeletarPorIdAsync(string clienteId);
        Task<Response<Cliente>> BuscarPorIdAsync(string clienteId);
        Task<Response<List<Cliente>>> ListaDeClientesAsync(string clienteId = null, string name = null);
    }
}
