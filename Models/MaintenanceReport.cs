using System.ComponentModel.DataAnnotations;

namespace WebApplication7.Models;

public class MaintenanceReport
{
    [Key]
    public int RequestId { get; set; }
    public int VehicleId { get; set; }
    public string MaintenanceType { get; set; }
    public DateTime RequestDate { get; set; }
    
    public Vehicle Vehicle { get; set; }
}