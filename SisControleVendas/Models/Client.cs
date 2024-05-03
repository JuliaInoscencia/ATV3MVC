using System.ComponentModel.DataAnnotations;

namespace SisControleVendas.Models
{
    public class Client { 
        public int ClientID { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [MinLength(3, ErrorMessage = "O nome deve ter pelo menos 3 caracteres.")]
        [Display(Name = "Nome")]
        public string? Name { get; set; }

        public string? Email { get; set; }

        [RegularExpression(@"^\d{11}$", ErrorMessage = "O CPF deve conter exatamente 11 dígitos numéricos.")]
        public string? CPF { get; set; }

        [RegularExpression(@"^\([0-9]{2}\) ([0-9]{8}|[0-9]{9})$")]
        [Display(Name = "Telefone")]
        public string? Phone { get; set; }

        [Display(Name = "Data de nascimento")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Nível de Acesso")]
        public int CredentialID { get; set; }

        [Display(Name = "Login")]
        public int UserInfoID { get; set; }
    }
}
