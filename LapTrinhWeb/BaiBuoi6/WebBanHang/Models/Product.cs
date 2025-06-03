using System.ComponentModel.DataAnnotations;
namespace WebBanHang.Models;
public class Product
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Vui lòng nhập tên sản phẩm")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "Vui lòng nhập mô tả")]
    public string Description { get; set; }
    
    [Required(ErrorMessage = "Vui lòng nhập giá")]
    [Range(0, double.MaxValue, ErrorMessage = "Giá phải lớn hơn 0")]
    public decimal Price { get; set; }
    
    [Required(ErrorMessage = "Vui lòng nhập số lượng")]
    [Range(0, int.MaxValue, ErrorMessage = "Số lượng phải lớn hơn 0")]
    public int Stock { get; set; }
    
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    
    public string ImagePath { get; set; }
}