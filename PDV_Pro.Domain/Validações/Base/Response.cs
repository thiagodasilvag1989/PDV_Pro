using System;
using System.Collections.Generic;
using System.Text;

namespace PDV_Pro.Domain.Validações.Base
{
    public class Response
    {
        public List<Report> Report { get; }

        public Response()
        {
            Report = new List<Report>();
        }

        public Response (Report report) : this(new List<Report>() { report }) { }

        public Response(List<Report> reports)
        {
            Report = reports;
        }
    }

    public class Response<T> : Response
    {
        public Response()
        {

        }

        public Response(T data, List<Report> reports) : base(reports)
        {
            Data = data;
        }

        public T Data { get; set; }
    }
}
