using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HomeSeek.Entities
{
    public class Reservation
    {
        
        public int ReservationId { get; set; }
        [Required,Display(Name ="Check in date")]
        public DateTime CheckInDate { get; set; }
        [Required,Display(Name = "Check out date"),]
        public DateTime CheckOutDate { get; set; }
        [CustomValidation(typeof(Validations), "GreaterThanZero")/*,RegularExpression(@"([0-9])+")*/]
        public int DaysOfStaying { get; set; }
        
        [DataType( DataType.Currency, ErrorMessage ="Price should contain only numbers." ), CustomValidation(typeof(Validations), "GreaterThanZero")/*, RegularExpression(@"([0-9])+")*/] //, Range(5,100000,ErrorMessage ="Price should be between $ 5 - 5000.")]
        public decimal TotalPrice { get; set; }
        
        
        public int? ReviewId { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual Place Place { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual Review Review { get; set; }
        
    }
}
