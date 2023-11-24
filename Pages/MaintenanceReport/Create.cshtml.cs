using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication7.Data;
using WebApplication7.Models;

namespace WebApplication7.Pages.MaintenanceReport
{
    public class CreateModel : PageModel
    {
        private readonly WebApplication7Context _context;

        public CreateModel(WebApplication7Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.MaintenanceReport MaintenanceReport { get; set; } = new Models.MaintenanceReport();

        [BindProperty(SupportsGet = true)]
        public int VehicleId { get; set; }

        public IActionResult OnGet()
        {
            // Проверяем существование машины по Id
            var existingVehicle = _context.Vehicle.Find(VehicleId);

            if (existingVehicle == null)
            {
                return NotFound();
            }

            MaintenanceReport.Vehicle = existingVehicle;

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                // Дополнительная обработка ошибок
                foreach (var modelStateEntry in ModelState.Values)
                {
                    foreach (var error in modelStateEntry.Errors)
                    {
                        Console.WriteLine($"Error: {error.ErrorMessage}");
                    }
                }

                return Page();
            }

            _context.MaintenanceReport.Add(MaintenanceReport);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Vehicle/Index");
        }
    }
}