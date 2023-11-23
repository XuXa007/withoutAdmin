using System.ComponentModel.DataAnnotations;

namespace WebApplication7.Models;

public class Vehicle
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Make is required")]
    public string Make { get; set; }

    [Required(ErrorMessage = "Model is required")]
    public string Model { get; set; }

    [Required(ErrorMessage = "Registration number is required")]
    public string RegistrationNumber { get; set; }
    
    [Range(1900, int.MaxValue, ErrorMessage = "Invalid year")]
    public int Year { get; set; }
    
    [Required(ErrorMessage = "Owner name is required")]
    public string OwnerName { get; set; }
    
    [Required(ErrorMessage = "Owner contact name is required")]
    public string OwnerContact { get; set; }
    
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime LastServiceDate { get; set; }
    
    [Range(0, int.MaxValue, ErrorMessage = "Odometer reading must be non-negative")]
    public int OdometerReading { get; set; }
}