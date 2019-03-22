namespace Project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            Reservations = new HashSet<Reservation>();
        }
        public Client(string firstName, string lastName, string egn,int age, int townId, string gsm, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EGN = egn;
            this.TownID = townId;
            this.Age = age;
            this.Gsm = gsm;
            this.Email = email;
            Reservations = new HashSet<Reservation>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(10)]
        public string EGN { get; set; }

        public int? Age { get; set; }

        public int? TownID { get; set; }

        [StringLength(30)]
        public string Gsm { get; set; }

        [StringLength(30)]
        public string Email { get; set; }

        public virtual Town Town { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
