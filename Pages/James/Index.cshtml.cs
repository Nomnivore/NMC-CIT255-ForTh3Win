using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ForTh3Win.Data;
using ForTh3Win.Models;
using System.Data;
using Microsoft.Data.SqlClient.DataClassification;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ForTh3Win.Pages.James
{
    public class IndexModel : PageModel
    {
        private readonly ForTh3Win.Data.ForTh3WinContext _context;

        public IndexModel(ForTh3Win.Data.ForTh3WinContext context)
        {
            _context = context;
        }

        public string SearchSort { get; set; }
        public ESRBEnum ESRBSort { get; set; }
        public GenreEnum GenreSort { get; set; }

        public IList<Review> Review { get;set; } = default!;

        public async Task OnGetAsync(string searchString, string esrbSearch, string genreSearch)
        {
            
            IQueryable<Review> reviewList = from r in _context.Review select r;
            if (!String.IsNullOrEmpty(searchString))
            {
                SearchSort = searchString;
                reviewList = reviewList.Where(r => r.GameName.Contains(SearchSort));
            }
            if (!String.IsNullOrEmpty(esrbSearch))
            {
                ESRBSort = (ESRBEnum)Enum.Parse(typeof(ESRBEnum), esrbSearch);
                reviewList = reviewList.Where(r => r.ESRBRating == ESRBSort);
            }
            if (!String.IsNullOrEmpty(genreSearch))
            {
                GenreSort = (GenreEnum)Enum.Parse(typeof(GenreEnum), genreSearch);
                reviewList = reviewList.Where(r => r.Genre == GenreSort);
            }
            if (_context.Review != null)
            {
                Review = await reviewList.AsNoTracking().ToListAsync();
            }
        }
    } 
}
