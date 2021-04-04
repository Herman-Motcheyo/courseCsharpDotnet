using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearnDotnet.Models;

namespace LearnDotnet.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}