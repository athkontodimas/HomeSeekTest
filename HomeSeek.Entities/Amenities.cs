using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HomeSeek.Entities
{
    public class Amenities
    {
        [ForeignKey("Place")]
        public int AmenitiesId { get; set; }
        public bool Wifi { get; set; }
        public bool Heating { get; set; }
        public bool Tv { get; set; }
        public bool AirConditioning { get; set; }
        public bool WorkSpace { get; set; }
        public bool FirstAidKit { get; set; }
        public bool Elevator { get; set; }
        public bool FreeParking { get; set; }

        //Navigation Properties
        //[Key,ForeignKey("Place")]
        public int PlaceId { get; set; }
        public virtual Place Place { get; set; }
    }
}
