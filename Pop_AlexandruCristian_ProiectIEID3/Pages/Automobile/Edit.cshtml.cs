using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pop_AlexandruCristian_ProiectIEID3.Data;
using Pop_AlexandruCristian_ProiectIEID3.Models;

namespace Pop_AlexandruCristian_ProiectIEID3.Pages.Automobile
{
    public class EditModel : PageModel
    {
        private readonly Pop_AlexandruCristian_ProiectIEID3.Data.Pop_AlexandruCristian_ProiectIEID3Context _context;

        public EditModel(Pop_AlexandruCristian_ProiectIEID3.Data.Pop_AlexandruCristian_ProiectIEID3Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Automobil Automobil { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Automobil == null)
            {
                return NotFound();
            }

            var automobil =  await _context.Automobil.FirstOrDefaultAsync(m => m.ID == id);
            if (automobil == null)
            {
                return NotFound();
            }
            Automobil = automobil;
            ViewData["VanzatorID"] = new SelectList(_context.Set<Vanzator>(), "ID", "NumeVanzator");
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

            _context.Attach(Automobil).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutomobilExists(Automobil.ID))
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

        private bool AutomobilExists(int id)
        {
          return _context.Automobil.Any(e => e.ID == id);
        }
    }
}
