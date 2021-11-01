using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Models
{
    public class BookManager
    {
            public List<Book> Books { get; set; }
            public SelectList Category { get; set; }
            public string BookGenres { get; set; }
            public string SearchString { get; set; }
    }
}
