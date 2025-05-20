using System.ComponentModel.DataAnnotations;

namespace project_second_formsApp.Models
{
    public class Product
    {
        [Display(Name = "Ürün Id")]
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "Ürün Adı")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Ürün Fiyatı")]
        public decimal? Price { get; set; }

        [Display(Name = "Ürün Görseli")]
        public string Image { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public int CategoryId { get; set; }
    }
}



// string.Empty; = Hiçbir zaman null olmayacak "".