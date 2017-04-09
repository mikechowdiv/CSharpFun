using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DvdRental1.Models;

namespace DvdRental1.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}