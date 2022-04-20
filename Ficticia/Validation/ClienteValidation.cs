using Ficticia.Models;
using FluentValidation;

namespace Ficticia.Validation
{
    public class ClienteValidation : AbstractValidator<Cliente>
    {
        public ClienteValidation()
        {
            RuleFor(c => c.Id).NotNull();
            RuleFor(c => c.Nombre).NotEmpty();
            RuleFor(c => c.Genero).NotEmpty();

        }
    }
}
