using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace AgendaSalas.Models
{
    public class Servico
    {
        [Key]
        [JsonIgnore]
        public int ServicoID { get; set; }

        [Required(ErrorMessage = "Atenção! O campo Descrição é obrigatório.", AllowEmptyStrings = false)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Atenção! O campo Custo é obrigatório.", AllowEmptyStrings = false)]
        public float Custo { get; set; }
    }
}
