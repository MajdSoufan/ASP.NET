using SummerWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SummerWebApp.ViewModel
{
    public class RandomSuberViewModel
    {
        public Suber Suber { get; set; }
        public List<Customer> Customers { get; set; }
    }
}