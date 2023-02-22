using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pop_AlexandruCristian_ProiectIEID3.Data;
using Pop_AlexandruCristian_ProiectIEID3.Models;

namespace Pop_AlexandruCristian_ProiectIEID3.Pages.Automobile
{
    public class DeleteModel : PageModel
    {
        private readonly Pop_AlexandruCristian_ProiectIEID3.Data.Pop_AlexandruCristian_ProiectIEID3Context _context;

        public DeleteModel(Pop_AlexandruCristian_ProiectIEID3.Data.Pop_AlexandruCristian_ProiectIEID3Context context)
        {
            _context = context;
        }

        [BindProperty]
      public Automobil Automobil { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Automobil == null)
            {
                return NotFound();
            }

            var automobil = await _context.Automobil.FirstOrDefaultAsync(m => m.ID == id);

            if (automobil == null)
            {
                return NotFound();
            }
            else 
            {
                Automobil = automobil;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Automobil == null)
            {
                return NotFound();
            }
            var automobil = await _context.Automobil.FindAsync(id);

            if (automobil != null)
            {
                Automobil = automobil;
                _context.Automobil.Remove(Automobil);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
