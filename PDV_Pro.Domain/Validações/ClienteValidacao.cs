using FluentValidation;
using PDV_Pro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PDV_Pro.Domain.Validações
{
    public class ClienteValidacao : AbstractValidator<Cliente>
    {
        public ClienteValidacao()
        {
            RuleFor(_ => _.Nome)
                .NotNull().WithMessage("Campo Obrigatorio")
                .NotEmpty()
                .Length(3, 30);

            RuleFor(_ => _.Email)
                .NotNull().WithMessage("Campo Obrigatorio")
                .NotEmpty()
                .Length(3, 30);

            RuleFor(_ => _.Email)
                .NotNull().WithMessage("Campo Obrigatorio")
                .NotEmpty()
                .EmailAddress(FluentValidation.Validators.EmailValidationMode.AspNetCoreCompatible);

            RuleFor(_ => _.Telefone)
                .NotNull().WithMessage("Campo Obrigatorio")
                .NotEmpty()
                .Length(10, 11).WithMessage("DDD Obrigatorio");
        }
    }
}
