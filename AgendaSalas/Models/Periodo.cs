using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AgendaSalas.Models
{
    public enum DiaSemana
    {
        Domingo = 1,
        Segunda_Feira = 2,
        Terca_Feira = 3,
        Quarta_Feira = 4,
        Quinta_Feira = 5,
        Sexta_Feira = 6,
        Sabado = 7
    }
    public class Periodo
    {

        [Key]
        [JsonIgnore]
        public int PeriodoId { get; set; }
        public DiaSemana diaSemana { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
    }
}
