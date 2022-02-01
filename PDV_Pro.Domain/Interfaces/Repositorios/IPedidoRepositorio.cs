using PDV_Pro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Pro.Domain.Interfaces.Repositorios
{
    public interface IPedidoRepositorio
    {
        Task<bool> ExistePorIdAsync(string pedidoId);
        Task CriarAsync(Pedido pedido);
        Task AtualizarAsync(Pedido pedido);
        Task DeletarPorIdAsync(string pedidoId);
        Task<Pedido> BuscarPorIdAsync(string clienteId);
        Task<List<Pedido>> ListaDeClientesAsync(string pedidoId = null, string clienteId = null, string usuarioId = null);

        Task CriarItemAsync(Item item);
        Task AutalizarItemAsync(Item item);
        Task DeletarItemAsync(Item item);
        Task<List<Item>> BuscarItemPorOrdemAsync(string pididoId);
    }
}
