using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication7.Models;


public class MaintenanceReport
{
    [Key]
    public int RequestId { get; set; }

    [Required(ErrorMessage = "MaintenanceType is required")]
    public string MaintenanceType { get; set; }

    [Required(ErrorMessage = "RequestDate is required")]
    public DateTime RequestDate { get; set; }

    public Vehicle Vehicle { get; set; }

    public int? VehicleId { get; set; }
}
