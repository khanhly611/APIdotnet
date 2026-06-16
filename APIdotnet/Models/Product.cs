using System.ComponentModel.DataAnnotations;

namespace ProductApi.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Tên sản phẩm là bắt buộc")]
        [MinLength(3, ErrorMessage = "Tên sản phẩm phải có ít nhất 3 ký tự")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Giá sản phẩm là bắt buộc")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Giá phải lớn hơn 0")]
        public decimal Price { get; set; }
    }
}