using System.Text.Json.Serialization;

namespace Dominio.Modelos
{
    public class Time
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime AnoFundacao { get; set; }
        public string? FotoEscudo { get; set; }
        [JsonIgnore]
        public ICollection<Jogador>? Jogadores { get; set;}
        [JsonIgnore]
        public ICollection<Estadio>? Estadios { get; set; }
        [JsonIgnore]
        public ICollection<Jogo>? JogosComoLocal { get; set;}
        [JsonIgnore]
        public ICollection<Jogo>? JogosComoVisitante { get; set; }
    }
}