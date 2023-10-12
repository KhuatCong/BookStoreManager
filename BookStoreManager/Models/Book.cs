using System;
using System.Collections.Generic;

namespace BookStoreManager.Models
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; } = null!;
        public int AuthorId { get; set; }
        public decimal? Price { get; set; }
        public string? Images { get; set; }
        public int CategoryId { get; set; }
        public string? Description { get; set; }
        public DateTime? Published { get; set; }
        public int? ViewCount { get; set; }

        public virtual Author Author { get; set; } = null!;
        public virtual Category Category { get; set; } = null!;
    }
}
