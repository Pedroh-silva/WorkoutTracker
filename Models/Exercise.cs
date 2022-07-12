using System.ComponentModel.DataAnnotations;

namespace Workout_Tracker.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Por favor, coloque o nome do exercício")]
        [Display(Name = "Nome do exercício")]
        public string Name { get; set; }
        public ICollection<Workout> Workouts { get; set; } = new List<Workout>();
        [Required(ErrorMessage = "Por favor, selecione o músculo")]
        [Display(Name = "Músculo")]
        public ICollection<Muscle> Muscles { get; set; } = new List<Muscle>();
        public ICollection<SeriesReps> SeriesReps { get; set; } = new List<SeriesReps>();

        public Exercise()
        {

        }

        public Exercise(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}
