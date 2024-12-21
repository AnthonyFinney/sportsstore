using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SportsStore.Models;

public class Order {
    [BindNever]
    public int OrderID { get; set; }
    [BindNever]
    public ICollection<CartLine> Lines { get; set; } = new List<CartLine>();

    [Required(ErrorMessage = "Please Enter A Name")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Please Enter The First Address Line")]
    public string? Line1 { get; set; }
    public string? Line2 { get; set; }
    public string? Line3 { get; set; }

    [Required(ErrorMessage = "Please Enter A City Name")]
    public string? City { get; set; }

    [Required(ErrorMessage = "Please Enter A State Name")]
    public string? State { get; set; }

    public string? Zip { get; set; }

    [Required(ErrorMessage = "Please Enter A Country Name")]
    public string? Country { get; set; }

    public bool GiftWrap { get; set; }

    [BindNever]
    public bool Shipped { get; set; }
}