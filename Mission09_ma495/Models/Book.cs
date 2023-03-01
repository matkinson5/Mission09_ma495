using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Mission09_ma495.Models
{
    public partial class Book //the information about the books that is in the database
    {
        [Key]
        [Required]
        public long BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        public string Isbn { get; set; }
        [Required]
        public string Classification { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public long PageCount { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
