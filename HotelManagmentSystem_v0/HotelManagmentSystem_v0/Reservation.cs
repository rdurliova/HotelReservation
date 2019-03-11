namespace HotelManagmentSystem_v0
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Reservation")]
    public partial class Reservation
    {
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

        public virtual HotelBase HotelBase { get; set; }
    }
}
