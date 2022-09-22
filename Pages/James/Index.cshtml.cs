using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ForTh3Win.Data;
using ForTh3Win.Models;

namespace ForTh3Win.Pages.James
{
    public class IndexModel : PageModel
    {
        private readonly ForTh3Win.Data.ForTh3WinContext _context;

        public IndexModel(ForTh3Win.Data.ForTh3WinContext context)
        {
            _context = context;
        }

        public IList<Review> Review { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Review != null)
            {
                Review = await _context.Review.ToListAsync();
            }
        }
    }
}
