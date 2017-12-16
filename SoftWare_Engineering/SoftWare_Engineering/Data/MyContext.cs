namespace SoftWare_Engineering.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyContext : DbContext
    {
        public MyContext()
            : base("name=MyContext5")
        {
        }

        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Calendar> Calendars { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Compliment> Compliments { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<Discipline> Disciplines { get; set; }
        public virtual DbSet<Dormitory> Dormitories { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<RegistrationForm> RegistrationForms { get; set; }
        public virtual DbSet<Relative> Relatives { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomAssessment> RoomAssessments { get; set; }
        public virtual DbSet<SchoolYear> SchoolYears { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TypeRoom> TypeRooms { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Relative>()
                .Property(e => e.Relationship)
                .IsFixedLength();

            modelBuilder.Entity<Relative>()
                .Property(e => e.Job)
                .IsFixedLength();

            modelBuilder.Entity<SchoolYear>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<TypeRoom>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsFixedLength();
        }
    }
}
