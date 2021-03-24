using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Models
{
    public class Movie
    {

        public string Name { get; set; }

        public Guid ID { get; set; }

        public string Genre { get; set; }

    }
}
