using PDV_Pro.Domain.Interfaces.Repositorios;
using PDV_Pro.Domain.Interfaces.Servicos;
using PDV_Pro.Domain.Models;
using PDV_Pro.Domain.Validações;
using PDV_Pro.Domain.Validações.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PDV_Pro.Domain.Servicos
{
    public class ClienteServico : IClienteService
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteServico(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public Task<Response> AtualizarAsync(Cliente cliente)
        {
            throw new System.NotImplementedException();
        }

        public Task<Response<Cliente>> BuscarPorIdAsync(string clienteId)
        {
            throw new System.NotImplementedException();
        }

        async public Task<Response> CriarAsync(Cliente cliente)
        {
            var response = new Response();
            var validacao = new ClienteValidacao();
            var erros = validacao.Validate(cliente).BuscarErros();

            if (erros.Report.Count > 0)
            {
                return erros;
            }

            await _clienteRepositorio.CriarAsync(cliente);
            return response;
        }

        public Task<Response> DeletarPorIdAsync(string clienteId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Response<List<Cliente>>> ListaDeClientesAsync(string clienteId = null, string name = null)
        {
            throw new System.NotImplementedException();
        }
    }
}
