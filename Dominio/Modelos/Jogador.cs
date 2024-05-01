using Dominio.Enumeradores;
using System.Text.Json.Serialization;

namespace Dominio.Modelos
{
    public class Jogador
    {
        public int Id { get; set; }
        public int TimeId { get; set; }
        [JsonIgnore]
        public Time? Time { get; set; }
        public string Nome { get; set; }
        public DateTime Idade { get; set; }
        public PernaBoaEnum PernaBoa { get; set; }
        public PosicaoEnum Posicao { get; set; }
        public string Nacionalidade { get; set; }
        public int NumeroDaCamisa { get; set; }
        public int NumeroDeJogos { get; set; }
        public string Detalhes { get; set; }
        public string? Foto { get; set; }
    }
}
