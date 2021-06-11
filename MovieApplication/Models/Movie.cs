using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApplication.Models
{
    public class Movie
    {
        public Guid id { get; internal set; }
        public string name { get; set; }
        public string genre { get; set; }
    }
}