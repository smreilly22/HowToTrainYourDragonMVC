using Dragon.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon.Model.LocationModels
{
    public class LocationDetails
    {
        public int LocationId { get; set; }

        public string LocationName { get; set; }

        public string Climate { get; set; }

        public List<Human> Humans { get; set; }

        public List<Dragon.Data.Dragon> Dragons { get; set; }

    }
}
