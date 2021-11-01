using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Books.Models
{
    public class Book
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]

        public string Category { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}