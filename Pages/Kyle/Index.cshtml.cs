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
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;

namespace ForTh3Win.Pages.Kyle
{
    public class IndexModel : PageModel
    {
        private readonly ForTh3Win.Data.ForTh3WinContext _context;

        public IndexModel(ForTh3Win.Data.ForTh3WinContext context)
        {
            _context = context;
        }

        public IList<Review> Review { get;set; } = default!;
        [BindProperty(SupportsGet = true)]
        public string ? SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public int ? GameGenreQuery { get; set; }

        public async Task OnGetAsync()
        {
            //if (_context.Review != null)
            //{
            //    Review = await _context.Review.ToListAsync();
            //}

            var reviews = from r in _context.Review
                          select r;
            if (!string.IsNullOrEmpty(SearchString))
            {
                reviews = reviews.Where(s => s.GameName.Contains(SearchString));
            }

            if (GameGenreQuery.HasValue && Enum.IsDefined(typeof(GenreEnum), GameGenreQuery)){
                var genre = (GenreEnum)GameGenreQuery;

                reviews = reviews.Where(x => x.Genre == genre);
            }
            
            Review = await reviews.ToListAsync();
        }
    }
}
