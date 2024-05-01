using Dominio.Modelos;
using FluentValidation;

namespace Dominio.Validacoes
{
    public class ValidadorJogador: AbstractValidator<Jogador>
    {
        public ValidadorJogador()
        {
            RuleFor(x => x.TimeId)
                .NotNull()
                .WithMessage("Informar o time do jogador é obrigatório");

            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage("O nome do jogador é obrigatório");

            RuleFor(x => x.Idade)
                .NotNull()
                .WithMessage("É obrigatório informar a idade do jogador")
                .Must(idade => CalcularIdade(idade) >= 16 && CalcularIdade(idade) <= 50)
                .WithMessage("O jogador deve ter entre 16 e 50 anos, por favor verifique a idade do jogador.");

            RuleFor(x => x.PernaBoa)
                .NotNull()
                .WithMessage("Informar a perna boa do jogador é obrigatório.")
                .IsInEnum()
                .WithMessage("Perna boa deve ser inteiro já que é um enumerador");

            RuleFor(x => x.Posicao)
                .NotNull()
                .WithMessage("Informar a posição do jogador é obrigatório.")
                .IsInEnum()
                .WithMessage("A posição do jogador deve ser inteiro pois é um enumerador");

            RuleFor(x => x.Nacionalidade)
                .NotEmpty()
                .WithMessage("A nacionalidade do jogador é obrigatória")
                .MaximumLength(100)
                .WithMessage("A nacionalidade informada deve ter no máximo 100 caracteres.");

            RuleFor(x => x.NumeroDaCamisa)
                .NotNull()
                .WithMessage("O número da camisa é obrigatório")
                .Must(numero => numero > 0 && numero <= 50)
                .WithMessage("O número da camisa do jogador deve estar entre o 0 e 50.");

            RuleFor(x => x.NumeroDeJogos)
                .NotNull()
                .WithMessage("Informar o número de jogos do jogador é obrigatório.")
                .Must(numero => numero >= 0)
                .WithMessage("O número deve ser maior ou igual a zero");

            RuleFor(x => x.Detalhes)
                .NotEmpty()
                .WithMessage("Os detalhes do jogador são obrigatórios.")
                .MaximumLength(250)
                .WithMessage("O número de caracteres dos detalhes não pode ultrapassar os 250 caracteres.");
        }

        private int CalcularIdade(DateTime dataNascimento)
        {
            var hoje = DateTime.Now;
            var idade = hoje.Year - dataNascimento.Year;

            if (dataNascimento.Date > hoje.AddYears(-idade))
            {
                idade--;
            }
            return idade;
        }
    }
}
