using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pop_AlexandruCristian_ProiectIEID3.Data;
using Pop_AlexandruCristian_ProiectIEID3.Models;

namespace Pop_AlexandruCristian_ProiectIEID3.Pages.Vanzatori
{
    public class CreateModel : PageModel
    {
        private readonly Pop_AlexandruCristian_ProiectIEID3.Data.Pop_AlexandruCristian_ProiectIEID3Context _context;

        public CreateModel(Pop_AlexandruCristian_ProiectIEID3.Data.Pop_AlexandruCristian_ProiectIEID3Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Vanzator Vanzator { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Vanzator.Add(Vanzator);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
