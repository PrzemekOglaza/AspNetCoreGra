using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AplikacjaAspNetCore1.Model;
using AplikacjaAspNetCore1.Models;

namespace AplikacjaAspNetCore1.Pages.Games
{
    public class DetailsModel : PageModel
    {
        private readonly AplikacjaAspNetCore1.Models.AppDbContext _context;

        public DetailsModel(AplikacjaAspNetCore1.Models.AppDbContext context)
        {
            _context = context;
        }

        public Game Game { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Game = await _context.Game.FirstOrDefaultAsync(m => m.Id == id);

            if (Game == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
