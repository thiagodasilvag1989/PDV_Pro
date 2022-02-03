using PDV_Pro.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PDV_Pro.Domain.Interfaces.Servicos
{
    public interface IPedidoServico
    {
        Task CriarAsync(Pedido pedido);
        Task AtualizarAsync(Pedido pedido);
        Task DeletarPorIdAsync(string pedidoId);
        Task<Pedido> BuscarPorIdAsync(string pedidoId);
        Task<List<Pedido>> ListaDeClientesAsync(string pedidoId = null, string clienteId = null, string usuarioId = null);
    }
}
