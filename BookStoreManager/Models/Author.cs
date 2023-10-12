using System;
using System.Collections.Generic;

namespace BookStoreManager.Models
{
    public partial class Author
    {
        public Author()
        {
            Books = new HashSet<Book>();
        }

        public int AuthorId { get; set; }
        public string AuthorName { get; set; } = null!;
        public string? AuthorEmail { get; set; }
        public string? AuthorAddress { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
