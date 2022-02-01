using System;
using System.Collections.Generic;
using System.Text;

namespace PDV_Pro.Domain.Models
{
    public class Produto : EntidadeBase
    {
        public string Descricao { get; set; }
        public string ValordeVenda { get; set; }
        public int Estoque { get; set; }
    }
}
