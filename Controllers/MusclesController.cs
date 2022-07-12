using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Workout_Tracker.Services;
using WorkoutTracker.Services;

namespace Workout_Tracker.Controllers
{
    public class MusclesController : Controller
    {
        private readonly ExerciseService _exerciseService;
        private readonly WorkoutService _workoutService;
        private readonly MuscleService _muscleService;

        public MusclesController(MuscleService muscleService, ExerciseService exerciseService)
        {
            _muscleService = muscleService;
            _exerciseService = exerciseService;
        }
        // GET: ExercisesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ExercisesController/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _muscleService.FindById(id);
            return View(obj);
        }

        // GET: ExercisesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExercisesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ExercisesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ExercisesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ExercisesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ExercisesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
