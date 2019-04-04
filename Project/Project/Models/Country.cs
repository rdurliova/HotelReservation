namespace Project
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Country
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        private int id;
        private string name;

        public Country()
        {
            Towns = new HashSet<Town>();
        }

        public int Id
        {
            get { return this.id; }
            set
            {
                if (value > 0)
                {
                    this.id = value;
                }
                else
                {
                    throw new ArgumentException("Town Id трябва да бъде по-голямо от 0!");
                }
            }
        }

        [StringLength(50)]
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length >=3)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Дължината на името трябва да с и повече от 3 символа!");
                }
            }
        }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Town> Towns { get; set; }
    }
}
