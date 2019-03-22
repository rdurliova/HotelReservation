namespace Project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Reservation")]
    public partial class Reservation
    {
        public Reservation()
        {

        }
        public Reservation(int idClient, int idRoom, DateTime startDate, DateTime finishDate, decimal payment, string paymentType)
        {
            this.IdClient = idClient;
            this.IdRoom = idRoom;
            this.DataStart = startDate;
            this.DataFinish = finishDate;
            this.Payment = payment;
            this.PaymentType = paymentType;
        }
   
        public int Id { get; set; }

        public int? IdClient { get; set; }

        public int? IdRoom { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataStart { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DataFinish { get; set; }

        public decimal? Payment { get; set; }

        [StringLength(20)]
        public string PaymentType { get; set; }

        public virtual Client Client { get; set; }

        public virtual Room Room { get; set; }
    }
}
