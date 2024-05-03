using System.ComponentModel.DataAnnotations;

namespace SisControleVendas.Models
{
    public class Sale
    {
        public int SaleID { get; set; }

        [Display(Name = "Data da venda")]
        public DateTime SaleDate { get; set; }

        [Display(Name = "Quantidade")]
        public int Quantity { get; set; }

        [Display(Name = "Valor Unitário")]
        public decimal UnitaryValue { get; set; }

        [Display(Name = "Valor Total")]
        public decimal Amount { get; set; }

        [Display(Name = "Produto")]
        public int ProductID { get; set; }

        [Display(Name = "Vendedor")]
        public int EmployeeID { get; set; }

        [Display(Name = "Cliente")]
        public int ClientID { get; set; }
    }
}
