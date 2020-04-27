﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HomeSeek.Entities
{
    public class Review
    {
        //[ForeignKey("Reservation")]
        public int ReviewId { get; set; }
        [Range(0,10, ErrorMessage = "Values should be between 0 - 10.")]
        public int Accuracy { get; set; }
        [Range(0, 10, ErrorMessage = "Values should be between 0 - 10.")]
        public int Checkin { get; set; }
        [Range(0, 10, ErrorMessage = "Values should be between 0 - 10.")]
        public int Cleanliness { get; set; }
        [Range(0, 10, ErrorMessage = "Values should be between 0 - 10.")]
        public int Location { get; set; }
        [Range(0, 10, ErrorMessage = "Values should be between 0 - 10.")]
        public int Value { get; set; }
        public DateTime SubDate { get; set; }
        [Range(0, 10, ErrorMessage = "Values should be between 0 - 10.")]
        public double OverallRating { get; set; }
        [DataType(DataType.Text),CustomValidation(typeof(Validations),"MaxWords")]
        public string Comment { get; set; }
       // public int? ReservationId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

       // public virtual Reservation Reservation { get; set; }
    }
}
