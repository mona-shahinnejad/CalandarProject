using System;
using System.Data.Entity;
using System.Linq;
using Domain.Entities;

namespace Domain
{
    public class CalendarDatabaseContext : DbContext
    {
        public CalendarDatabaseContext() :
            base("CalendarDb")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public IDbSet<User> Users { get; set; }
        public IDbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>()
               .HasMany<User>(s => s.Attendees)
               .WithMany(c => c.Appointments_Attendees)
               .Map(cs =>
               {
                   cs.MapLeftKey("AppointmentId");
                   cs.MapRightKey("AttendeeId");
                   cs.ToTable("AppointmentAttendees");
               });

            modelBuilder.Entity<Appointment>()
                .HasRequired(d => d.Organizer)
                .WithMany(u => u.Appointments).WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            var AddedEntities = ChangeTracker.Entries<BaseEntity>().Where(E => E.State == EntityState.Added).ToList();

            AddedEntities.ForEach(E =>
            {
                E.Entity.CreateDateTime = DateTime.Now;
                E.Entity.ModifyDateTime = DateTime.Now;
            });

            var ModifiedEntities = ChangeTracker.Entries<BaseEntity>().Where(E => E.State == EntityState.Modified).ToList();

            ModifiedEntities.ForEach(E =>
            {
                E.Entity.ModifyDateTime = DateTime.Now;
            });

            return base.SaveChanges();
        }
    }
}
