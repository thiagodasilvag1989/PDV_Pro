using PDV_Pro.Domain.Interfaces.Servicos;
using PDV_Pro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Pro.Domain.Servicos
{
    public class ProdutoServico : IProdutoServico
    {
        public Task AtualizarAsync(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Task<Produto> BuscarPorIdAsync(string produtoId)
        {
            throw new NotImplementedException();
        }

        public Task CriarAsync(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Task DeletarPorIdAsync(string produtoId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Produto>> ListaDeClientesAsync(string produtoId = null, string name = null)
        {
            throw new NotImplementedException();
        }
    }
}
