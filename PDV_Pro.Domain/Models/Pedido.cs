using System;
using System.Collections.Generic;
using System.Text;

namespace PDV_Pro.Domain.Models
{
    public class Pedido : EntidadeBase
    {
        public Cliente Cliente { get; set; }
        public Usuario usuario { get; set; }
    }
}
