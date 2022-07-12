using Microsoft.EntityFrameworkCore;
using Workout_Tracker.Data;
using Workout_Tracker.Models;

namespace Workout_Tracker.Services
{
    public class MuscleService
    {
        private readonly WorkoutTrackerDbContext _context;

        public MuscleService(WorkoutTrackerDbContext context)
        {
            _context = context;
        }

        public List<Muscle> FindAll()
        {
            return _context.Muscle.OrderBy(x => x.Name).Include(x => x.Exercises).ToList();
        }
        public Muscle FindById(int id)
        {
            return _context.Muscle.Include(x => x.Exercises).FirstOrDefault(obj => obj.Id == id);
        }
        public Muscle FindByIdList(int id)
        {
            return _context.Muscle.Include(x => x.Exercises).FirstOrDefault(obj => obj.Id == id);
        }
    }
}
