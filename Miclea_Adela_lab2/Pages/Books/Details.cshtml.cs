﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Miclea_Adela_lab2.Data;
using Miclea_Adela_lab2.Models;

namespace Miclea_Adela_lab2.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Miclea_Adela_lab2.Data.Miclea_Adela_lab2Context _context;

        public DetailsModel(Miclea_Adela_lab2.Data.Miclea_Adela_lab2Context context)
        {
            _context = context;
        }

      public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                Book = book;
            }
            return Page();
        }
    }
}
