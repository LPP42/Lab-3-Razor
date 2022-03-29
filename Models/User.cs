
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab3.Models;

public class User
{
    public int UserId { get; set; }
    public string? Name { get; set; }
    [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public int? StreetNumber { get; set; }
    public string? StreetName { get; set; }
        [RegularExpression (@"^[A-Za-z]\d[A-Za-z][ -]?\d[A-Za-z]\d$" , ErrorMessage = "Either thats not a valid postal code or my programm sucks")]
    public string? PostalCode { get; set; }
    public string? City { get; set; }
    public string? Province { get; set; }
}