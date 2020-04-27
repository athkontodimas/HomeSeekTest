using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeSeek.Entities
{
    public class Place
    {
        [ForeignKey("Amenities")]
        public int PlaceId { get; set; }
        public string ApartmentName { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int AmenitiesId { get; set; }
        //Navigation Properties
        public virtual Amenities Amenities { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
