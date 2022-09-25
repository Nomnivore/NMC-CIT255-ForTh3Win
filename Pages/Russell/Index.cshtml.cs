using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ForTh3Win.Data;
using ForTh3Win.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ForTh3Win.Pages.Russell
{
    public class IndexModel : PageModel
    {
        private readonly ForTh3Win.Data.ForTh3WinContext _context;

        public IndexModel(ForTh3Win.Data.ForTh3WinContext context)
        {
            _context = context;
        }


        public IList<Review> Review { get; set; } = default!;
        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        public SelectList? Genre { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? Titles { get; set; }

       // public IList<Review> Review { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Review != null)
            {
                Review = await _context.Review.ToListAsync();
            }

            var title = from m in _context.Review
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                title = title.Where(s => s.GameName.Contains(SearchString));
            }

            Review = await title.ToListAsync();
        }
    }
}
