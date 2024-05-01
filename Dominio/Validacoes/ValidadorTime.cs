using Dominio.Modelos;
using FluentValidation;

namespace Dominio.Validacoes
{
    public class ValidadorTime: AbstractValidator<Time>
    {
        public ValidadorTime()
        {
            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage("O nome do time é obrigatório");

            RuleFor(x => x.AnoFundacao)
                .NotNull()
                .WithMessage("O ano de fundação do time é obrigatório.")
                .Must(AnoFundacaoNaoPodeSerMaiorQueOAnoAtual)
                .WithMessage("O ano de fundação depois do ano atual.");
        }

        private bool AnoFundacaoNaoPodeSerMaiorQueOAnoAtual(DateTime anoFundacao)
        {
            var resultado = DateTime.Compare(anoFundacao, DateTime.Now);
            return resultado <= 0;
        }
    }
}