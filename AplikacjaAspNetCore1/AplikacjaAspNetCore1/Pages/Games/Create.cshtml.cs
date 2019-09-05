using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AplikacjaAspNetCore1.Model;
using AplikacjaAspNetCore1.Models;

namespace AplikacjaAspNetCore1.Pages.Games
{
    public class CreateModel : PageModel
    {
        private readonly AplikacjaAspNetCore1.Models.AppDbContext _context;

        public CreateModel(AplikacjaAspNetCore1.Models.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Game Game { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Game.Add(Game);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}