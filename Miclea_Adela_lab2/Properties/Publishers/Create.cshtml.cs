using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Miclea_Adela_lab2.Data;
using Miclea_Adela_lab2.Models;

namespace Miclea_Adela_lab2.Properties.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Miclea_Adela_lab2.Data.Miclea_Adela_lab2Context _context;

        public CreateModel(Miclea_Adela_lab2.Data.Miclea_Adela_lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["PublisherID"]= new SelectList(_context.Set<Publisher>(), "ID", "PublisherName");
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                ViewData["PublisherID"] = new SelectList(_context.Set<Publisher>(), "ID", "PublisherName");
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
