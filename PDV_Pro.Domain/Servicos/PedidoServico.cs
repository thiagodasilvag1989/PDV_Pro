using PDV_Pro.Domain.Interfaces.Servicos;
using PDV_Pro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Pro.Domain.Servicos
{
    public class PedidoServico : IPedidoServico
    {
        public Task AtualizarAsync(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public Task<Pedido> BuscarPorIdAsync(string pedidoId)
        {
            throw new NotImplementedException();
        }

        public Task CriarAsync(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public Task DeletarPorIdAsync(string pedidoId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Pedido>> ListaDeClientesAsync(string pedidoId = null, string clienteId = null, string usuarioId = null)
        {
            throw new NotImplementedException();
        }
    }
}
