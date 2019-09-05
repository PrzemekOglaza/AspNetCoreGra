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
    public class IndexModel : PageModel
    {
        private readonly AplikacjaAspNetCore1.Models.AppDbContext _context;

        public IndexModel(AplikacjaAspNetCore1.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; }

        public async Task OnGetAsync()
        {
            Game = await _context.Game.ToListAsync();
        }
    }
}
