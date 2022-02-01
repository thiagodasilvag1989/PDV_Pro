using System;
using System.Collections.Generic;
using System.Text;

namespace PDV_Pro.Domain.Models
{
    public abstract class EntidadeBase
    {
        public string Id { get; set; }
        public DateTime DataDeCriacao { get; set; }
    }
}
