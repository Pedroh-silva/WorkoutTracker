using Microsoft.EntityFrameworkCore;
using Workout_Tracker.Data;
using Workout_Tracker.Models;

namespace Workout_Tracker.Services
{
    public class ExerciseService
    {
        private readonly WorkoutTrackerDbContext _context;

        public ExerciseService(WorkoutTrackerDbContext context)
        {
            _context = context;
        }

        public List<Exercise> FindAll()
        {
            return _context.Exercise.OrderBy(x => x.Name).Include(x => x.Muscles).ToList();
        }
        public Exercise FindById(int id)
        {
            return _context.Exercise.Include(x => x.Muscles).FirstOrDefault(obj => obj.Id == id);
        }
        public void Insert(Exercise obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
        public void Remove(int id)
        {
            var obj = _context.Exercise.Find(id);
            _context.Exercise.Remove(obj);
            _context.SaveChanges();
        }

    }
}
