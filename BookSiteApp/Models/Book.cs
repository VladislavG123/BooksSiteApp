using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookSiteApp.Models
{
    public class Book
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime RealiseDate { get; set; }
        public decimal Price { get; set; }
        public string Author { get; set; }
    }
}
