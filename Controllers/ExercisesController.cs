using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Packaging;
using Workout_Tracker.Data;
using Workout_Tracker.Models;
using Workout_Tracker.Models.ViewModel;
using Workout_Tracker.Services;
using WorkoutTracker.Services;

namespace Workout_Tracker.Controllers
{
    public class ExercisesController : Controller
    {
        private readonly ExerciseService _exerciseService;
        private readonly WorkoutService _workoutService;
        private readonly MuscleService _muscleService;

        public ExercisesController(ExerciseService exerciseService,WorkoutService workoutService, MuscleService muscleService)
        {
             _workoutService = workoutService;
             _exerciseService = exerciseService;
            _muscleService = muscleService;
        }
        // GET: ExercisesController
        public ActionResult Index()
        {
            DetailsVm detailsVm = new DetailsVm();
            detailsVm.Workouts = _workoutService.FindAll();
            detailsVm.Exercises = _exerciseService.FindAll();
            detailsVm.Muscles = _muscleService.FindAll();
            
            return View(detailsVm);
        }
        public ActionResult Lista()
        {
           var obj = _exerciseService.FindAll();
            

            return View(obj);
        }

        // GET: ExercisesController/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _exerciseService.FindById(id);
            return View(obj);
        }
        public ActionResult DetailsByMuscle(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _muscleService.FindAll().Where(x => x.Id == id).ToList();
            return View(obj);
            
        }



        // GET: ExercisesController/Create
        public ActionResult Create()
        {
            ViewBag.muscles = _muscleService.FindAll();
            return View();
        }

        // POST: ExercisesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Exercise exercise)
        {
            try
            {
                var lstTags = Request.Form["chkTags"];
                if (!string.IsNullOrEmpty(lstTags))
                {
                    int[] splt = lstTags.Select(int.Parse).ToArray();
                    if (splt.Count() > 0)
                    {
                        var postTags = _muscleService.FindAll().Where(x => splt.Contains(x.Id)).ToList();
                        exercise.Muscles.AddRange(postTags);
                        _exerciseService.Insert(exercise);
                        return RedirectToAction(nameof(Index));
                    }
                }

                return NoContent();
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
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _exerciseService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // POST: ExercisesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                _exerciseService.Remove(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
