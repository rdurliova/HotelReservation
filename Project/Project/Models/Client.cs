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
        private int id { get; set; }
        private string firstName;
        private string lastName;
        private string egn;
        private int? age;
        private int? townId;
        private string gsm;
        private string email;

        public Client()
        {
            Reservations = new HashSet<Reservation>();
        }
        public Client(string firstName, string lastName, string egn, int age, int townId, string gsm, string email)
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
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value.Length>3)
                {
                    this.firstName = value;
                }
                else
                {
                    throw new ArgumentException("Name length must be more than 3 symbols!");
                }
            }
        }

        [StringLength(50)]
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value.Length > 3)
                {
                    this.lastName = value;
                }
                else
                {
                    throw new ArgumentException("Name length must be more then 3 symbols!");
                }
            }
        }

        [StringLength(10)]
        public string EGN
        {
            get { return this.egn; }
            set
            {
                if (value.Length == 10)
                {
                    this.egn= value;
                }
                else
                {
                    throw new ArgumentException("Name length must be equals 10!");
                }
            }
        }

        public int? Age
        {
            get { return this.age; }
            set
            {
                if (value >= 0)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentException("Name length must be more than 0!");
                }
            }
        }

        public int? TownID
        {
            get { return this.townId; }
            set
            {
                if (value > 0)
                {
                    this.townId = value;
                }
                else
                {
                    throw new ArgumentException("Name length must be more than 0!");
                }
            }
        }

        [StringLength(30)]
        public string Gsm
        {
            get { return this.gsm; }
            set
            {
                if (value.Length > 5)
                {
                    this.gsm = value;
                }
                else
                {
                    throw new ArgumentException("Name length must be more than 5 symbols!");
                }
            }
        }

        [StringLength(30)]
        public string Email
        {
            get { return this.email; }
            set
            {
                if (value.Length > 3)
                {
                    this.email = value;
                }
                else
                {
                    throw new ArgumentException("Name length must be more than 3 symbols!");
                }
            }
        }

        public virtual Town Town { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
