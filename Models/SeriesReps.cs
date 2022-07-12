namespace Workout_Tracker.Models
{
    public class SeriesReps
    {
        public int Id { get; set; }
        public List<int> Series { get; set; }
        public List<int> Reps { get; set; }
        public ICollection<Exercise> Exercises { get; set; }

        public SeriesReps()
        {
        }
    }
}
