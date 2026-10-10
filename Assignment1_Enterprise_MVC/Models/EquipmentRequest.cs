using System.ComponentModel.DataAnnotations;

namespace Assignment1_Enterprise_MVC.Models;

public class EquipmentRequest
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Please enter your name")]
    public string? Name { get; set; }
    
    [Required(ErrorMessage = "Please enter your email")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address")]
    public string? Email { get; set; }
    
    [Required(ErrorMessage = "Please enter your phone number")]
    [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Please enter in the format xxx-xxx-xxxx")]
    public string? Phone { get; set; }
    
    [Required(ErrorMessage = "Please select your role")]
    public Requester? Role { get; set; } 
    
    [Required(ErrorMessage = "Please select your equipment type")]
    public EquipmentType? EquipmentType { get; set; }
    
    [Required(ErrorMessage = "Please enter your request details")]
    public string? Details { get; set; }
    
    [Required(ErrorMessage = "Please enter the duration in days")]
    [Range(1, 365, ErrorMessage = "The request duration must be greater than zero")]
    public int? Duration { get; set; }
}