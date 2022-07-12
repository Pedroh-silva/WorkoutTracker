namespace Workout_Tracker.Models
{
    public class Muscle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Exercise> Exercises { get; set; } = new List<Exercise>();
        public string ImagePath { get; set; }

        public Muscle()
        {

        }
        public Muscle(int id, string name, string imagePath)
        {
            Id = id;
            Name = name;
            ImagePath = imagePath;
            
        }
    }
}
