using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.Migrations;

namespace Vidly.ViewModels
{
    public class NewMovieViewModel : Controller
    {
        // GET: NewMovieViewModel
        public IEnumerable <Genre> Genre { get; set; }
        public Movie Movie { get; set; }
        public string Title
        {
            get
            {
                if (Movie != null && Movie.Id != 0)
                    return "Edit Movie";

                return "New Movie";
            }
        }
    }

}