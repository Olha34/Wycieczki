using Microsoft.EntityFrameworkCore;
using Wycieczki.Models;


namespace Wycieczki.Data
{
    public class ReservationContext:DbContext
    {
        public ReservationContext(DbContextOptions<ReservationContext> options) : base(options) { }
        public DbSet<Reservation> Reservations { get; set; } 
        public DbSet<Person> Persons { get; set; }
        public DbSet<Trip>Trips { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>().ToTable("Reservation");
            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<Trip>().ToTable("Trip");


        }
    }
}
