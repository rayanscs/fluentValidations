using FluentValidation;
using FluentValidations.Api.Model;

namespace FluentValidations.Api.Validators
{
    public class ItemValidator : AbstractValidator<Item>
    {
        public ItemValidator()
        {
            RuleFor(i => i.Numero)
                .Must(MaiorQue).WithMessage("O campo número deve ser maior que zero.");
        }

        public static bool MaiorQue(int numero) => numero > 0;
    }
}
