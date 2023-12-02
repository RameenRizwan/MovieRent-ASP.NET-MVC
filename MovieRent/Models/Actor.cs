using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRent.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }

        public string Name{ get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
