using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSeek.Entities
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalFees { get; set; }
        //public double Vat { get; set; }
        public virtual Reservation Reservation { get; set; }
    }
}
