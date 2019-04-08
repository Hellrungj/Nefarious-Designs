using NefariousDesigns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NefariousDesigns.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Shirt> Shirts { get; set; }
    }
}
