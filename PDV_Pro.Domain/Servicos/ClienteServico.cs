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

        async public Task<Response> AtualizarAsync(Cliente cliente)
        {
            var response = new Response();
            var validacao = new ClienteValidacao();
            var erros = validacao.Validate(cliente).BuscarErros();

            if (erros.Report.Count > 0)
            {
                return erros;
            }

            var existe = await _clienteRepositorio.ExistePorIdAsync(cliente.Id);
            if (!existe)
            {
                response.Report.Add(Report.Criar($"Cliente {cliente.Id} não existe!"));
                return response;
            }
            return response;
        }

        async public Task<Response<Cliente>> BuscarPorIdAsync(string clienteId)
        {
            var response = new Response<Cliente>();

            var existe = await _clienteRepositorio.ExistePorIdAsync(clienteId);
            if (!existe)
            {
                response.Report.Add(Report.Criar($"Cliente {clienteId} não existe!"));
                return response;
            }

            response.Data = await _clienteRepositorio.BuscarPorIdAsync(clienteId);
            return response;
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

        async public Task<Response> DeletarPorIdAsync(string clienteId)
        {
            var response = new Response();

            var existe = await _clienteRepositorio.ExistePorIdAsync(clienteId);
            if (!existe)
            {
                response.Report.Add(Report.Criar($"Cliente {clienteId} não existe!"));
                return response;
            }

            await _clienteRepositorio.DeletarPorIdAsync(clienteId);
            return response;
        }

        async public Task<Response<List<Cliente>>> ListaDeClientesAsync(string clienteId = null, string name = null)
        {
            var response = new Response<List<Cliente>>();

            if (!string.IsNullOrWhiteSpace(clienteId))
            {

                var existe = await _clienteRepositorio.ExistePorIdAsync(clienteId);
                if (!existe)
                {
                    response.Report.Add(Report.Criar($"Cliente {clienteId} não existe!"));
                    return response;
                }
            }


            response.Data = await _clienteRepositorio.ListaDeClientesAsync(clienteId, name);
            return response;
        }
    }
}
