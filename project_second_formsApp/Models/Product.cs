using System.ComponentModel.DataAnnotations;

namespace project_second_formsApp.Models
{
    public class Product
    {
        [Display(Name = "Ürün Id")]
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "Ürün Adı")]
        [StringLength(100)]
        public string? Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Ürün Fiyatı boş bırakılamaz.")]
        [Display(Name = "Ürün Fiyatı")]
        [Range(0, 150000)]
        public decimal? Price { get; set; }

        [Display(Name = "Ürün Görseli")]
        public string Image { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public int CategoryId { get; set; }
    }
}



// string.Empty; = Hiçbir zaman null olmayacak "".

// Hem [Required] hemde ? kullanmak mantıklı mı? Hem dolu olması gerekşyor hem null able yapıyoruz neden? = Veriyi eklerken hata almamak için. Decimal price değeri form post edilmeden önce bile model biding sırasında hata oluşturabilir. Ancak bu yöntemi kullanırsak biding işleminin problemsiz gerçekleştirir. 