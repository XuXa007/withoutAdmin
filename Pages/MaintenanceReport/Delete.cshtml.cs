using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication7.Data;
using WebApplication7.Models;

namespace WebApplication7.Pages.MaintenanceReport
{
    public class DeleteModel : PageModel
    {
        private readonly WebApplication7.Data.WebApplication7Context _context;

        public DeleteModel(WebApplication7.Data.WebApplication7Context context)
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

            var maintenancereport = await _context.MaintenanceReport.FirstOrDefaultAsync(m => m.RequestId == id);

            if (maintenancereport == null)
            {
                return NotFound();
            }
            else
            {
                MaintenanceReport = maintenancereport;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var maintenancereport = await _context.MaintenanceReport.FindAsync(id);
            if (maintenancereport != null)
            {
                MaintenanceReport = maintenancereport;
                _context.MaintenanceReport.Remove(MaintenanceReport);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
