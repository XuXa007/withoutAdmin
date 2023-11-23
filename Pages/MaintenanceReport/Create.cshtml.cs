using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication7.Data;
using WebApplication7.Models;

namespace WebApplication7.Pages.MaintenanceReport
{
    public class CreateModel : PageModel
    {
        private readonly WebApplication7.Data.WebApplication7Context _context;

        public CreateModel(WebApplication7.Data.WebApplication7Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["MakeList"] = new SelectList(_context.Vehicle.Select(v => v.Make).Distinct().ToList());
            ViewData["ModelList"] = new SelectList(_context.Vehicle.Select(v => v.Model).Distinct().ToList());
            return Page();
        }

        [BindProperty]
        public Models.MaintenanceReport MaintenanceReport { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MaintenanceReport.Add(MaintenanceReport);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
