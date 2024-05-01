using System.Text.Json.Serialization;

namespace Dominio.Modelos
{
    public class Estadio
    {
        public int Id { get; set; }
        public int TimeId { get; set; }
        [JsonIgnore]
        public Time? Time { get; set; }
        public string Nome { get; set; }
        public string? FotoEstadio { get; set; }
        public int Capacidade { get; set; }
        public DateTime AnoDeConstrucao { get; set; }
        [JsonIgnore]
        public ICollection<Jogo>? EstadioJogo { get; set; }
    }
}
