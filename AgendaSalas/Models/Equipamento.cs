using System.ComponentModel.DataAnnotations;

namespace AgendaSalas.Models
{
    public class Equipamento
    {
        [Key]
        public int EquipamentoId { get; set; }

        [Required(ErrorMessage = "Atenção! O campo Nome é obrigatório.", AllowEmptyStrings = false)]
        string Nome { get; set; }

        [Required(ErrorMessage = "Atenção! O campo Descrição é obrigatório.", AllowEmptyStrings = false)]
        string Descricao { get; set; }  

        float Custo { get; set; }   

    }
}
