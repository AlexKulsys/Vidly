﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(225)]
        [Display(Name = "Movie Name")]
        public string Name { get; set; }
        [Display(Name= "Genre")]
        public string Genre { get; set; }
        public byte GenreId { get; set; }
        public DateTime DateAdded { get; set; }
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Number in Stock")]
        public byte NumberInStock { get; set; }
    }
}