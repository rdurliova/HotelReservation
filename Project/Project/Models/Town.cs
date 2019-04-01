namespace Project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Town
    {
        private string name;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Town()
        {
            Clients = new HashSet<Client>();
        }
        public Town(string townName, int id)
        {
            this.Name = townName;
            this.Id = id;
            Clients = new HashSet<Client>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length > 3)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Името на града трябва да е по-дълго от 3 символа!");
                }
            }
        }

        public int CountryId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Client> Clients { get; set; }

        public virtual Country Country { get; set; }
    }
}
