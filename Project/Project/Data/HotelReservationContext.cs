namespace Project
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HotelReservationContext : DbContext
    {
        public HotelReservationContext()
            : base("name=HotelReservationContext")
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomType> RoomTypes { get; set; }
        public virtual DbSet<Town> Towns { get; set; }

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

            modelBuilder.Entity<Reservation>()
                .Property(e => e.Payment)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Reservation>()
                .Property(e => e.PaymentType)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.RoomNumebr)
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .HasMany(e => e.Reservations)
                .WithOptional(e => e.Room)
                .HasForeignKey(e => e.IdRoom);

            modelBuilder.Entity<RoomType>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<RoomType>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RoomType>()
                .HasMany(e => e.Rooms)
                .WithRequired(e => e.RoomType)
                .HasForeignKey(e => e.TypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Town>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
