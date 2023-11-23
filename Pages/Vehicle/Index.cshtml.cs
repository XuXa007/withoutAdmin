using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication7.Data;
using WebApplication7.Models;

namespace WebApplication7.Pages.Vehicle
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication7.Data.WebApplication7Context _context;

        public IndexModel(WebApplication7.Data.WebApplication7Context context)
        {
            _context = context;
        }

        public IList<Models.Vehicle> Vehicle { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Vehicle = await _context.Vehicle.ToListAsync();
        }
    }
}
