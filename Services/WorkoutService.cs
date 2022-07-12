using Microsoft.EntityFrameworkCore;
using Workout_Tracker.Data;
using Workout_Tracker.Models;
namespace WorkoutTracker.Services
{
    public class WorkoutService
    {
        private readonly WorkoutTrackerDbContext _context;

        public WorkoutService(WorkoutTrackerDbContext context)
        {
            _context = context;
        }

        public List<Workout> FindAll()
        {
            
            return _context.Workout.Include(x => x.Exercises).ThenInclude(m => m.Muscles).OrderByDescending(x =>x.DateTime).ToList();
        }

        public void Insert(Workout obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
        public Workout FindById(int id)
        {
            return _context.Workout.Include(x => x.Exercises ).ThenInclude(x => x.Muscles).FirstOrDefault(obj => obj.Id == id);
        }
        public void Remove(int id)
        {
            var obj = _context.Workout.Find(id);
            _context.Workout.Remove(obj);
            _context.SaveChanges();
        }

    }
}
