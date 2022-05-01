using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon.Data
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        [Display(Name = "Location Name")]
        public string LocationName { get; set; }
        
        [Required]
        public string Climate { get; set; }

        // public List<Human> Humans {get; set;}

        // public List<Dragon> Dragons

    }
}
