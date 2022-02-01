using PDV_Pro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Pro.Domain.Interfaces.Repositorios
{
    public interface IUsuarioRepository
    {
        Task<bool> ExistePorIdAsync(string usuraioId);
        Task<bool> ExistePorLoginAsync(string login);
        Task CriarAsync(Usuario usuario);
        Task AtualizarAsync(Usuario usuario);
        Task DeletarPorIdAsync(string usuraioId);
        Task<Usuario> BuscarPorIdAsync(string usuraioId);
        Task<List<Usuario>> ListaDeClientesAsync(string usuraioId = null, string name = null);
    }
}
