using Dominio.Modelos;
using FluentValidation;
using Infra.ConexaoBD;
using Infra.Interfaces;

namespace Infra.Servicos
{
    public class ServicoTime : ITimeRepository
    {
        private readonly AppDbContext _conexao;
        private readonly IValidator<Time> _validador;

        public ServicoTime(AppDbContext conexao, IValidator<Time> validador)
        {
            _conexao = conexao;
            _validador = validador;
        }

        public async Task Adicionar(Time time)
        {
            var validacao = _validador.Validate(time);
            if (!validacao.IsValid) { throw new Exception(validacao.ToString()); }

            if (_conexao.Times.ToList().Any(t => t.Nome == time.Nome))
            {
                throw new Exception("O nome do time já está em uso.");
            }

            _conexao.Add(time);
            await _conexao.SaveChangesAsync();
        }

        public void Atualizar(Time modelo)
        {
            throw new NotImplementedException();
        }

        public Time ObterPorId(int id)
        {
            return _conexao.Times.FirstOrDefault(x => x.Id == id)
                ?? throw new Exception("Time não encontrado");
        }

        public List<Time> ObterTodos()
        {
            return _conexao.Times.ToList();
        }

        public async Task Remover(Time time)
        {
            var validacao = _validador.Validate(time);
            if (!validacao.IsValid) { throw new Exception(validacao.ToString()); }
            
            var timeObtido = ObterPorId(time.Id);
            _conexao.Remove(timeObtido);
            await _conexao.SaveChangesAsync();
        }
    }
}