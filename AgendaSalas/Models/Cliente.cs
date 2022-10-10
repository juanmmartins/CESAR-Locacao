using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AgendaSalas.Models
{
    public class Cliente
    {
        [Key]
        [JsonIgnore]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Atenção! O campo Nome é obrigatório.", AllowEmptyStrings = false)]
        [StringLength(240, MinimumLength = 3, ErrorMessage = "Atenção! O campo nome deve ter entre 3 e 240 e caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Atenção! O campo E-mail deve ser preenchido!")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Atenção! Informe um e-mail válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Atenção! O campo \"Celular\" deve ser preenchido!")]
        [RegularExpression("^\\([1-9]{2}\\) (?:[2-8]|9[1-9])[0-9]{3}\\-[0-9]{4}$", ErrorMessage = "Atenção! Informe um celular válido no seguinte formato: (xx) xxxxx-xxxx")]
        public string Celular { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }

        /*        
                public override string ToString()
                {
                    return "Nome: " + Nome + " \nE-mail: " + Email + " \nCelular: " + Celular + " \nCpf: " + Cpf + " \nRg: " + Rg;
                }
        */
    }
}
