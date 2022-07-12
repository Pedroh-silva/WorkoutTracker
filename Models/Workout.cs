using System.ComponentModel.DataAnnotations;

namespace Workout_Tracker.Models
{
    public class Workout
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Por favor, coloque o nome do treino")]
        [Display(Name = "Nome do treino")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Por favor, coloque a data e hora do treino")]
        [Display(Name = "Data e hora do treino")]
        public DateTime DateTime { get; set; }
        [Required(ErrorMessage = "Por favor, coloque a duração do treino")]
        [DataType(DataType.Time)]
        [Display(Name ="Duração do treino")]
        public TimeSpan Duration { get; set; }
        [Display(Name = "Exercícios")]
        public ICollection<Exercise> Exercises { get; set; } = new List<Exercise>();

        public Workout()
        {
            
        }
        public Workout(string name, DateTime dateTime, TimeSpan duration)
        {

            Name = name;
            DateTime = dateTime;
            Duration = duration;
           
        }
        public Workout(int id, string name, DateTime dateTime, TimeSpan duration)
        {
            Id = id;
            Name = name;
            DateTime = dateTime;
            Duration = duration;
            
        }
    }
}
