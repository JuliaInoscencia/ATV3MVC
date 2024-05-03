using System.ComponentModel.DataAnnotations;

namespace SisControleVendas.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [MinLength(3, ErrorMessage = "O nome deve ter pelo menos 3 caracteres.")]
        [Display(Name = "Nome")]
        public string? Name { get; set; }

        [Display(Name = "Descrição")]
        public string? Description { get; set; }

        [Display(Name = "Preço")]
        public decimal Price { get; set; }

        [Display(Name = "Categoria")]
        public string? Category { get; set; }

        [Display(Name = "Data de Lançamento")]
        public DateTime LaunchDate { get; set; }

        [Display(Name = "Responsável pelo Registro")]
        public int EmployeedID { get; set; }
    }
}
