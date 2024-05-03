using System.ComponentModel.DataAnnotations;

namespace SisControleVendas.Models
{
    public class UserInfo
    {
        public int UserInfoID { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "O endereço de email não é válido!")]
        public string? Email { get; set; }

        [Required]
        //[DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string? Password { get; set; }
    }
}
