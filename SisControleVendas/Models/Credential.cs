using System.ComponentModel.DataAnnotations;

namespace SisControleVendas.Models
{
    public class Credential
    {
        public int CredentialID { get; set; }

        [Display(Name = "Nome")]
        public string? Name { get; set; }
    }
}
