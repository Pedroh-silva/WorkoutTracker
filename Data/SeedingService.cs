/*using Workout_Tracker.Models;

namespace Workout_Tracker.Data
{
	public class SeedingService 
	{
		private readonly WorkoutTrackerDbContext _context;

		public SeedingService(WorkoutTrackerDbContext context)
		{
			_context = context;
		}

		/*public void Seed()
		{
			if (_context.Workout.Any() || _context.Exercise.Any() || _context.Muscle.Any())
			{
				return;
			}
			Muscle m1 = new Muscle(1, "Costas");
			Muscle m2 = new Muscle(2, "Peito");
			Muscle m3 = new Muscle(3, "Tríceps");
			Muscle m4 = new Muscle(4, "Bíceps");
			Muscle m5 = new Muscle(5, "Ombro");
			Muscle m6 = new Muscle(6, "Perna");
			Muscle m7 = new Muscle(7, "Core");

			Exercise e1 = new Exercise { Exercise_Id = 1, Name = "Pull up", Muscles = new List<Muscle>() { m1 } };
			Exercise e2 = new Exercise { Exercise_Id = 2, Name = "Push up", Muscles = new List<Muscle>() { m2 } };
			Exercise e3 = new Exercise { Exercise_Id = 3, Name = "Bicep curl", Muscles = new List<Muscle>() { m4 } };
			Exercise e4 = new Exercise { Exercise_Id = 4, Name = "Triceps press", Muscles = new List<Muscle>() { m3 } };

			Workout w1 = new Workout { Workout_Id = 1, Name = "Push Day", Exercises = new List<Exercise>() {e2, e4 }, DateTime = new DateTime(2022,02,22,18,28,00), Duration = new TimeSpan(00,46,39) };
			Workout w2 = new Workout { Workout_Id = 2, Name = "Pull Day", Exercises = new List<Exercise>() {e1, e3 }, DateTime = new DateTime(2022,02,21,17,51,00,DateTimeKind.Local), Duration = new TimeSpan(00,23,49) };

			WorkoutExercise we1 = new WorkoutExercise { Workout_Id = w1.Workout_Id, Exercise_Id = e2.Exercise_Id };
			WorkoutExercise we2 = new WorkoutExercise { Workout_Id = w1.Workout_Id, Exercise_Id = e4.Exercise_Id };
			WorkoutExercise we3 = new WorkoutExercise { Workout_Id = w2.Workout_Id, Exercise_Id = e1.Exercise_Id };
			WorkoutExercise we4 = new WorkoutExercise { Workout_Id = w2.Workout_Id, Exercise_Id = e3.Exercise_Id };

			_context.Muscle.AddRange(m1, m2, m3, m4, m5, m6, m7);
			_context.Exercise.AddRange(e1, e2, e3, e4);
			_context.Workout.AddRange(w1, w2);
			_context.SaveChanges();

			
		}
	}
}
*/