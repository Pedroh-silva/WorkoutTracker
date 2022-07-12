using Microsoft.EntityFrameworkCore;
using Workout_Tracker.Models;

namespace Workout_Tracker.Data
{
    public class WorkoutTrackerDbContext : DbContext
    {
        public DbSet<Exercise> Exercise { get; set; }
        public DbSet<Workout> Workout { get; set; }
        public DbSet<Muscle> Muscle { get; set; }

        public WorkoutTrackerDbContext(DbContextOptions<WorkoutTrackerDbContext> options) : base(options)
        {
        }
         protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Exercise>().HasData(new Exercise
            {
                Id = 1,
                Name = "Barra Fixa",
                
            });
            mb.Entity<Exercise>().HasData(new Exercise
            {
                Id = 2,
                Name = "Flexão de braço",

            });
            mb.Entity<Exercise>().HasData(new Exercise
            {
                Id = 3,
                Name = "Agachamento",

            });
            mb.Entity<Exercise>().HasData(new Exercise
            {
                Id = 4,
                Name = "Dips",

            });
            mb.Entity<Muscle>().HasData(new Muscle
            {
                Id = 1,
                Name = "Costas",
                ImagePath= "/lib/Images/Muscle/costas.png"

            });
            mb.Entity<Muscle>().HasData(new Muscle
            {
                Id = 2,
                Name = "Peito",
                ImagePath = "/lib/Images/Muscle/peito.png"

            });
            mb.Entity<Muscle>().HasData(new Muscle
            {
                Id = 3,
                Name = "Pernas",
                ImagePath = "/lib/Images/Muscle/pernas.png"

            });
            mb.Entity<Muscle>().HasData(new Muscle
            {
                Id = 4,
                Name = "Triceps",
                ImagePath = "/lib/Images/Muscle/triceps.png"

            });
        }
        
    }
}
