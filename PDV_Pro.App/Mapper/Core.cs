using AutoMapper;
using PDV_Pro.App.DataContract.Request.Cliente;
using PDV_Pro.App.DataContract.Response.Cliente;
using PDV_Pro.Domain.Models;

namespace PDV_Pro.App.Mapper
{
    public class Core : Profile
    {
        public Core() { ClienteMap(); }

        public void ClienteMap()
        {
            CreateMap<CriarClienteRequest, Cliente>();
            CreateMap<Cliente, ClienteResponse>();
        }
    }
}
