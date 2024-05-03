using System.ComponentModel.DataAnnotations;

namespace SisControleVendas.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [MinLength(3, ErrorMessage = "O nome deve ter pelo menos 3 caracteres.")]
        [Display(Name = "Nome")]
        public string? Name { get; set; }

        [EmailAddress(ErrorMessage = "O endereço de email não é válido!")]
        public string? Email { get; set; }

        [RegularExpression(@"^\d{11}$", ErrorMessage = "O CPF deve conter exatamente 11 dígitos numéricos.")]
        public string? CPF { get; set; }

        [Display(Name = "Matrícula")]
        public string? Registration { get; set; }

        [Display(Name = "Data de admissão")]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

        [Display(Name = "Ativo")]
        public Boolean IsActive { get; set; }

        [Display(Name = "Nível de Acesso")]
        public int CredentialID { get; set; }
    }
}
