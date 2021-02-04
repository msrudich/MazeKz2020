using Microsoft.EntityFrameworkCore;
using WebMaze.DbStuff.Model;
using WebMaze.DbStuff.Model.Police;
using WebMaze.DbStuff.Model.Polyclinic;

namespace WebMaze.DbStuff
{
    public class WebMazeContext : DbContext
    {
        public DbSet<CitizenUser> CitizenUser { get; set; }

        public DbSet<Adress> Adress { get; set; }

        public DbSet<Policeman> Policemen { get; set; }

        public DbSet<Violation> Violations { get; set; }
        
        public DbSet<ViolationType> TypesOfViolation { get; set; }

        public DbSet<HealthDepartment> HealthDepartment { get; set; }

        public DbSet<Bus> Bus { get; set; }

        public DbSet<BusStop> BusStop { get; set; }

        public DbSet<BusRoute> BusRoute { get; set; }

        public DbSet<UserTask> UserTasks { get; set; }

        // Polyclinic tables
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Doctors> Doctors { get; set; }
        public DbSet<Patients> Patients { get; set; }
        public DbSet<PolyclinicUser> PolyclinicUser { get; set; }
        public DbSet<Positions> Positions { get; set; }
        public DbSet<PriceDoctors> PriceDoctors { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<Specializations> Specializations { get; set; }
        public DbSet<Visits> Visits { get; set; }
        public DbSet<VisitTypes> VisitTypes { get; set; }


        public WebMazeContext(DbContextOptions dbContext) : base(dbContext) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CitizenUser>()
                .HasMany(citizen => citizen.Adresses)
                .WithOne(adress => adress.Owner);

            base.OnModelCreating(modelBuilder);
        }
    }
}
