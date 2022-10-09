using System.ComponentModel.DataAnnotations;

namespace AgendaSalas.Models
{
    public class Sala
    {
        [Key]
        public int SalaId { get; set; }

        [Required(ErrorMessage = "Atenção! O campo Identificacao é obrigatório.", AllowEmptyStrings = false)]
        [StringLength(240, MinimumLength = 3, ErrorMessage = "Atenção! O campo Identificacao deve ter entre 3 e 240 e caracteres.")]
        public string Identificacao { get; set; }
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Atenção! O campo \"Medida Lado 1 Em Metros\" é obrigatório.", AllowEmptyStrings = false)]
        public int MedidaLado1EmMetros { get; set; }

        [Required(ErrorMessage = "Atenção! O campo \"Medida Lado 2 Em Metros\" é obrigatório.", AllowEmptyStrings = false)]
        public int Medidalado2EmMetros { get; set; }

        [Required(ErrorMessage = "Atenção! O campo \"Numero Maximo De Pessoas\" é obrigatório.", AllowEmptyStrings = false)]
        public int NumeroMaximoDePessoas { get; set; }
        public ICollection<Endereco>? Enderecos { get; set; }

    }
}
