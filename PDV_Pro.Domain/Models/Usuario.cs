using System;
using System.Collections.Generic;
using System.Text;

namespace PDV_Pro.Domain.Models
{
    public class Usuario : EntidadeBase
    {

        public string Name { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
