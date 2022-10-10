using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AgendaSalas.Models
{
    public class Reserva
    {

        [Key]
        [JsonIgnore]
        public int ReservaId { get; set; }

        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }

        [ForeignKey("Sala")]
        public int SalaId { get; set; }

        [ForeignKey("Servico")]
        public int ServicoID { get; set; }

        [ForeignKey("Periodo")]
        public int PeriodoId { get; set; }
    }
}
