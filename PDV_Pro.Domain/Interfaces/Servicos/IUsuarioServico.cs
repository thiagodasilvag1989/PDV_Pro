using PDV_Pro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Pro.Domain.Interfaces.Servicos
{
    public interface IUsuarioServico
    {
        Task<bool> AutenticacaoAsync(Usuario usuario);
        Task CriarAsync(Usuario usuario);
        Task AtualizarAsync(Usuario usuario);
        Task DeletarPorIdAsync(string usuarioId);
        Task<Usuario> BuscarPorIdAsync(string usuarioId);
        Task<List<Usuario>> ListaDeClientesAsync(string usuarioId = null, string name = null);
    }
}
