using PDV_Pro.Domain.Interfaces.Servicos;
using PDV_Pro.Domain.Models;
using PDV_Pro.Domain.Validações;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PDV_Pro.Domain.Servicos
{
    public class ClienteServico : IClienteService
    {
        public Task AtualizarAsync(Cliente cliente)
        {
            throw new System.NotImplementedException();
        }

        public Task<Cliente> BuscarPorIdAsync(string clienteId)
        {
            throw new System.NotImplementedException();
        }

        public Task CriarAsync(Cliente cliente)
        {
            var validacao = new ClienteValidacao();
            var resut = validacao.Validate(cliente);

            if (!resut.IsValid)
            {
                foreach (var erro in resut.Errors)
                {

                }
            }
            throw new System.NotImplementedException();

        }

        public Task DeletarPorIdAsync(string clienteId)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Cliente>> ListaDeClientesAsync(string clienteId = null, string name = null)
        {
            throw new System.NotImplementedException();
        }
    }
}
