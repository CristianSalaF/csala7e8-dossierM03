using System.ComponentModel.DataAnnotations;

namespace T4Ex23.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nom del producte és obligatori")]
        [StringLength(100, ErrorMessage = "El nom no pot superar els 100 caràcters")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "El preu és obligatori")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El preu ha de ser superior a 0")]
        public decimal Price { get; set; }
    }
}
