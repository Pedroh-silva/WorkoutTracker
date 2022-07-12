namespace Workout_Tracker.Models.ViewModel
{
    public class DetailsVm 
    {
        public ICollection<Workout> Workouts { get; set; }
        public ICollection<Exercise> Exercises{ get; set; }
        public ICollection<Muscle> Muscles { get; set; }

        public DetailsVm()
        {

        }
    }
    
}
