
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab3.Models;

public class Product
{
    public int ProductId { get; set; }
    public string? Name { get; set; }
    [Range(0,200000)]
    [DataType(DataType.Currency)]
     [Column(TypeName = "decimal(7, 2)")]
    public decimal Price { get; set; } = 5.00m;
    public int Stock { get; set; } = 0;
}