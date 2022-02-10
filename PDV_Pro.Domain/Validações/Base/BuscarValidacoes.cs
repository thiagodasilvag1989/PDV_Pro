using FluentValidation.Results;

namespace PDV_Pro.Domain.Validações.Base
{
    public static class BuscarValidacoes
    {
        public static Response BuscarErros(this ValidationResult result)
        {
            var response = new Response();
            if (!result.IsValid)
            {
                foreach (var erro in result.Errors)
                {
                    response.Report.Add(new Report()
                    {
                        Code = erro.PropertyName,
                        Message = erro.ErrorMessage
                    });
                }

                return response;
            }
            return response;
        }
    }
}
