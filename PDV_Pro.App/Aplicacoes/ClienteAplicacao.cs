using AutoMapper;
using PDV_Pro.App.DataContract.Request.Cliente;
using PDV_Pro.App.Interfaces;
using PDV_Pro.Domain.Interfaces.Servicos;
using PDV_Pro.Domain.Models;
using PDV_Pro.Domain.Validações.Base;
using System.Threading.Tasks;

namespace PDV_Pro.App.Aplicacoes
{
    public class ClienteAplicacao : IClienteAplicacao
    {
        private readonly IClienteService _clienteService;
        private readonly IMapper _mapper;

        public ClienteAplicacao(IClienteService clienteService, IMapper mapper)
        {
            _clienteService = clienteService;
            _mapper = mapper;
        }

        public async Task<Response> CriarClienteAsync(CriarClienteRequest cliente)
        {
            var clienteMap = _mapper.Map<Cliente>(cliente);
            
            return await _clienteService.CriarAsync(clienteMap);
        }
    }
}
