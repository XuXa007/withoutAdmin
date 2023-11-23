using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication7.Data;
using WebApplication7.Models;

namespace WebApplication7.Pages.MaintenanceReport
{
    public class EditModel : PageModel
    {
        private readonly WebApplication7.Data.WebApplication7Context _context;

        public EditModel(WebApplication7.Data.WebApplication7Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.MaintenanceReport MaintenanceReport { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maintenancereport =  await _context.MaintenanceReport.FirstOrDefaultAsync(m => m.RequestId == id);
            if (maintenancereport == null)
            {
                return NotFound();
            }
            MaintenanceReport = maintenancereport;
           ViewData["VehicleId"] = new SelectList(_context.Vehicle, "Id", "Make");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(MaintenanceReport).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MaintenanceReportExists(MaintenanceReport.RequestId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MaintenanceReportExists(int id)
        {
            return _context.MaintenanceReport.Any(e => e.RequestId == id);
        }
    }
}
