using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ForTh3Win.Data;
using ForTh3Win.Models;

namespace ForTh3Win.Pages.Kyle
{
    public class DetailsModel : PageModel
    {
        private readonly ForTh3Win.Data.ForTh3WinContext _context;

        public DetailsModel(ForTh3Win.Data.ForTh3WinContext context)
        {
            _context = context;
        }

      public Review Review { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Review == null)
            {
                return NotFound();
            }

            var review = await _context.Review.FirstOrDefaultAsync(m => m.ID == id);
            if (review == null)
            {
                return NotFound();
            }
            else 
            {
                Review = review;
            }
            return Page();
        }
    }
}
