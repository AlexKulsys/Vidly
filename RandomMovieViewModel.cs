using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models; //Necessary to add to be able to use property - public Movie Movie { get; set; }

namespace Vidly.ViewModels
{
    public class RandomMovieViewModel // was created to be able to use View Model
    {
        public Movie Movie { get; set; } // neccessary to create Movie property
        public List<Customer> Customers { get; set; } // List of Customers property
    }
}