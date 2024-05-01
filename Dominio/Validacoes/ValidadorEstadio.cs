using Dominio.Modelos;
using FluentValidation;

namespace Dominio.Validacoes
{
    public class ValidadorEstadio: AbstractValidator<Estadio>
    {
        public ValidadorEstadio()
        {
            RuleFor(x => x.TimeId)
                .NotNull()
                .WithMessage("O estádio é obrigado a ter um time como proprietário");

            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage("O nome do estadio é obrigatório")
                .MaximumLength(250)
                .WithMessage("O nome do estadio deve ter no máximo 250 caracteres");

            RuleFor(x => x.Capacidade)
                .NotNull()
                .WithMessage("Informar a capacidade do estádio é obrigatório")
                .Must(numero => numero > 1000)
                .WithMessage("O número informado deve ser maior que mil torcedores.");

            RuleFor(x => x.AnoDeConstrucao)
                .NotNull()
                .WithMessage("O ano de construção do estádio é obrigatório.")
                .Must(AnoDeConstrucaoDeveSerValido)
                .WithMessage("A data de construção não pode ser maior que a data atual.");
        }

        private bool AnoDeConstrucaoDeveSerValido(DateTime dataDeConstrucao)
        {
            var resultado = DateTime.Compare(dataDeConstrucao, DateTime.Now);
            return resultado <= 0;
        }
    }
}