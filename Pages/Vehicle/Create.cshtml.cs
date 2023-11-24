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

namespace WebApplication7.Pages.Vehicle
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
            return Page();
        }

        [BindProperty]
        public Models.Vehicle Vehicle { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (Vehicle.Id == 0)
            {
                _context.Vehicle.Add(Vehicle);
            }
            else
            {
                _context.Entry(Vehicle).State = EntityState.Modified;
            }


            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
