using System.ComponentModel.DataAnnotations;

namespace WebApplication7.Models;

public class Vehicle
{
    public int Id { get; set; }
    
    [StringLength(30)]
    [Required(ErrorMessage = "Make is required")]
    public string Make { get; set; }

    [Required(ErrorMessage = "Model is required")]
    public string Model { get; set; }

    [Display(Name = "Registration number")]
    [Required(ErrorMessage = "Registration number is required")]
    public string RegistrationNumber { get; set; }
    
    [Range(1900, int.MaxValue, ErrorMessage = "Invalid year")]
    public int Year { get; set; }
    
    [Display(Name = "Owner name")]
    [Required(ErrorMessage = "Owner name is required")]
    public string OwnerName { get; set; }
    
    [Display(Name = "Owner contact")]
    [Required(ErrorMessage = "Owner contact name is required")]
    public string OwnerContact { get; set; }
    
    [Display(Name = "Last service date")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime LastServiceDate { get; set; }
    
    [Display(Name = "Odometer reading")]
    [Range(0, int.MaxValue, ErrorMessage = "Odometer reading must be non-negative")]
    public int OdometerReading { get; set; }
}