using PDV_Pro.Domain.Interfaces.Servicos;
using PDV_Pro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Pro.Domain.Servicos
{
    public class UsuarioServico : IUsuarioServico
    {
        public Task AtualizarAsync(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AutenticacaoAsync(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> BuscarPorIdAsync(string usuarioId)
        {
            throw new NotImplementedException();
        }

        public Task CriarAsync(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task DeletarPorIdAsync(string usuarioId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Usuario>> ListaDeClientesAsync(string usuarioId = null, string name = null)
        {
            throw new NotImplementedException();
        }
    }
}
