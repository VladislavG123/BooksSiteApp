using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookSiteApp.Models
{
    public class BookSiteAppContext : DbContext
    {
        public BookSiteAppContext (DbContextOptions<BookSiteAppContext> options)
            : base(options)
        {
        }

        public DbSet<BookSiteApp.Models.Book> Book { get; set; }
    }
}
