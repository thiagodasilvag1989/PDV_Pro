

namespace PDV_Pro.App.DataContract.Request.Cliente
{
    public sealed class CriarClienteRequest 
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
    }
}
