using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ForTh3Win.Data;
using ForTh3Win.Models;

namespace ForTh3Win.Pages.Kyle
{
    public class CreateModel : PageModel
    {
        private readonly ForTh3Win.Data.ForTh3WinContext _context;

        public CreateModel(ForTh3Win.Data.ForTh3WinContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Review Review { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Review == null || Review == null)
            {
                return Page();
            }

            _context.Review.Add(Review);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Details", new { id = Review.ID });
        }
    }
}
