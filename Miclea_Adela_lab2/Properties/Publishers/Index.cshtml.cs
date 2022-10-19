using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Miclea_Adela_lab2.Data;
using Miclea_Adela_lab2.Models;

namespace Miclea_Adela_lab2.Properties.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Miclea_Adela_lab2.Data.Miclea_Adela_lab2Context _context;

        public IndexModel(Miclea_Adela_lab2.Data.Miclea_Adela_lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;
        public List<Book> Book { get; private set; }

        public async Task OnGetAsync()
        {
            
                Book = await _context.Book.Include(b => b.Publisher).ToListAsync();
            
        }
    }
}
