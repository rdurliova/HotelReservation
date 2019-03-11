namespace HotelManagmentSystem_v0
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HotelsReservationContext : DbContext
    {
        public HotelsReservationContext()
            : base("name=HotelsReservationContext")
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<HotelBase> HotelBases { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Town> Towns { get; set; }
        public virtual DbSet<Type> Types { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.EGN)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Gsm)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Reservations)
                .WithOptional(e => e.Client)
                .HasForeignKey(e => e.IdClient);

            modelBuilder.Entity<Country>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Towns)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HotelBase>()
                .HasMany(e => e.Reservations)
                .WithOptional(e => e.HotelBase)
                .HasForeignKey(e => e.IdRoom);

            modelBuilder.Entity<Reservation>()
                .Property(e => e.Payment)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Reservation>()
                .Property(e => e.PaymentType)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .HasOptional(e => e.HotelBase)
                .WithRequired(e => e.Room);

            modelBuilder.Entity<Town>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Type>()
                .Property(e => e.Type1)
                .IsUnicode(false);

            modelBuilder.Entity<Type>()
                .HasMany(e => e.Rooms)
                .WithRequired(e => e.Type)
                .WillCascadeOnDelete(false);
        }
    }
}
