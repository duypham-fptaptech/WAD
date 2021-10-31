using System;
using System.ComponentModel.DataAnnotations;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMvc.Models
{

    public class Books
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }
        [StringLength(20, MinimumLength = 3)]
        [Required]
        public string Author { get; set; }
        [Required]

        public string Category { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}

