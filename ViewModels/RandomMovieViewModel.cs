using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vividly.Models;

namespace Vividly.ViewModels
{
    public class RandomMovieViewModel
    {
        public movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}