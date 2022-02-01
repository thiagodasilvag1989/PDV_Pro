using System;
using System.Collections.Generic;
using System.Text;

namespace PDV_Pro.Domain.Models
{
    public class Item : EntidadeBase
    {
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
        public decimal ValordeVenda { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
