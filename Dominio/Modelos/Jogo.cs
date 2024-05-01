using System.Text.Json.Serialization;

namespace Dominio.Modelos
{
    public class Jogo
    {
        public int Id { get; set; }
        public int TimeLocalId { get; set; }
        public int TimeVisitanteId { get; set; }
        public DateTime Data { get; set; }
        public int EstadioId { get; set; }
        [JsonIgnore]
        public Time? TimeLocal { get; set; }
        [JsonIgnore]
        public Time? TimeVisitante { get; set; }
        [JsonIgnore]
        public Estadio? Estadio { get; set; }
    }
}
