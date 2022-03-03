using PDV_Pro.App.DataContract.Request.Cliente;
using PDV_Pro.Domain.Models;
using PDV_Pro.Domain.Validações.Base;
using System.Threading.Tasks;

namespace PDV_Pro.App.Interfaces
{
    public interface IClienteAplicacao
    {
        Task<Response> CriarClienteAsync(CriarClienteRequest cliente);
    }
}
