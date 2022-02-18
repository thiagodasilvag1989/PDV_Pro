using System;
using System.Collections.Generic;
using System.Text;

namespace PDV_Pro.Domain.Validações.Base
{
    public class Report
    {
        public Report(){ }
        public Report( string message)
        {
            Message = message;
        }
        public string Code { get; set; }
        public string Message { get; set; }

        public static Report Criar(string message) => new Report(message);
    }
}
