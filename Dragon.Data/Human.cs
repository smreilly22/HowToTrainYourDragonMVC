using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon.Data
{
    public class Human
    {
        [Key]
        public int HumanId { get; set; }

        [Required]

        public Guid OwnerId { get; set; }

        [Required]
        public string HumanName { get; set; }

        [Required]
        public string Occupation { get; set; }

        //[ForeignKey(nameof(PreviousLocation))]
       // public int PreviousLocationId { get; set; }

       // public virtual Location PreviousLocation { get; set; }

        //[ForeignKey(nameof(CurrentLocation))]
        //public int CurrentLocationId { get; set; }

       // public virtual Location CurrentLocation { get; set; }

       // [ForeignKey(nameof(DragonCompanion))]
       // public int DragonCompanionId { get; set; }

       // public virtual Dragon DragonCompanion { get; set; }

        public bool IsEvil { get; set; }

        
    }
}
