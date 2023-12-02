using MovieRent.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRent.Models
{
    public class Movie
    {
        [Key]
        public int Id
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public string Description
        {
            get; set;
        }
        public string Image
        {
            get; set;
        }
        public double price{ get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
        public MovieCatagory moviecata { get; set; }
    }
}
