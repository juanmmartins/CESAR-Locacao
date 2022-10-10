using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AgendaSalas.Models
{
    public class Sala
    {
        [Key]
        [JsonIgnore]
        public int SalaId { get; set; }

        [Required(ErrorMessage = "Atenção! O campo Identificacao é obrigatório.", AllowEmptyStrings = false)]
        [StringLength(240, MinimumLength = 3, ErrorMessage = "Atenção! O campo Identificacao deve ter entre 3 e 240 e caracteres.")]
        public string Identificacao { get; set; }
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Atenção! O campo Medida Lado 1 Em Metros é obrigatório.", AllowEmptyStrings = false)]
        public int MedidaLado1EmMetros { get; set; }

        [Required(ErrorMessage = "Atenção! O campo Medida Lado 2 Em Metros é obrigatório.", AllowEmptyStrings = false)]
        public int Medidalado2EmMetros { get; set; }

        [Required(ErrorMessage = "Atenção! O campo Numero Maximo De Pessoas é obrigatório.", AllowEmptyStrings = false)]
        public int NumeroMaximoDePessoas { get; set; }

        [ForeignKey("Endereco")]
        public int EnderecoId { get; set; }
       // [JsonIgnore]
      //  public virtual Endereco Endereco { get; set; }
      

    }
}
