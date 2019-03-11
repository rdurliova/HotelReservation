namespace HotelManagmentSystem_v0
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Room
    {
        public int Id { get; set; }

        public int TypeId { get; set; }

        public virtual HotelBase HotelBase { get; set; }

        public virtual Type Type { get; set; }
    }
}
