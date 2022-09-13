using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ForTh3Win.Models;

namespace ForTh3Win.Data
{
    public class ForTh3WinContext : DbContext
    {
        public ForTh3WinContext (DbContextOptions<ForTh3WinContext> options)
            : base(options)
        {
        }

        public DbSet<ForTh3Win.Models.Review> Review { get; set; } = default!;
    }
}
