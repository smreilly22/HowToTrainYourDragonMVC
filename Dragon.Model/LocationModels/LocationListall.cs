using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon.Model.LocationModels
{
    public class LocationListall
    {
        public int LocationId { get; set; }

        [Display(Name = "Location")]
        public string LocationName { get; set; }
    }
}
