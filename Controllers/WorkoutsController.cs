using System.Collections.Specialized;
using Microsoft.AspNetCore.Mvc;
using NuGet.Packaging;
using Workout_Tracker.Models;
using Workout_Tracker.Services;
using WorkoutTracker.Services;

namespace Workout_Tracker.Controllers
{
    public class WorkoutsController : Controller
    {
        private readonly WorkoutService _workoutService;
        private readonly ExerciseService _exerciseService;
      

        public WorkoutsController(WorkoutService workoutService, ExerciseService exerciseService)
        {
            _workoutService = workoutService;
            _exerciseService = exerciseService;
        }

        // GET: WorkoutsController
        public ActionResult Index()
        {
            var list = _workoutService.FindAll();

            return View(list);
        }
    

        // GET: WorkoutsController/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _workoutService.FindById(id);
            return View(obj);
        }

        
        public ActionResult Create() 
        {
            ViewBag.Exs = _exerciseService.FindAll();
            return View();
        }

        // POST: WorkoutsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Workout workout)
        {
            
            try
            {
                var lstTags = Request.Form["chkTags"];
                var lstserie = Request.Form["chkseries"];
                var lstreps = Request.Form["chkreps"];
                if (!string.IsNullOrEmpty(lstTags))
				{
                    int[] splt = lstTags.Select(int.Parse).ToArray();
                    if (splt.Count() > 0)
					{
                        var postTags = _exerciseService.FindAll().Where(x => splt.Contains(x.Id)).ToList();
                        var serielist = _e
                        //workout.Exercises.AddRange(postTags);
                        //_workoutService.Insert(workout);
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

        public ActionResult Statistic()
        {
            var diaHoje = DateTime.Now ;
            var mes = DateTime.Now.Month;
            var ano = DateTime.Now.Year;
            if (diaHoje.Day >= 7)
            {
                if(diaHoje.Day == 7)
                {
                    var mesPassado2 = DateTime.Now.Month - 1;
                    var daisnoMesPassado2 = DateTime.DaysInMonth(ano, mesPassado2);
                    List<DateTime> list2 = new List<DateTime>();
                    list2.Add(new DateTime(ano,mesPassado2,daisnoMesPassado2));
                    for (int i = 1; i <= 7; i++)
                    {
                        list2.Add(new DateTime(ano, mes, i));
                    }
                    ViewBag.Dias = list2;
                    return View();
                }
                var diaSemPassada = diaHoje.Day - 7;
                List<int> dias = new List<int>();
                for(int i=diaHoje.Day; i >= diaSemPassada; i--)
                {
                    dias.Add(i);
                }
                List<DateTime> diaMesAnolist = new List<DateTime>();
                foreach (int i in dias)
                {
                    diaMesAnolist.Add(new DateTime(ano, mes, i));
                }
                ViewBag.Dias = diaMesAnolist;
                return View();
            }
            var mesPassado = DateTime.Now.Month - 1;
            var daisnoMesPassado = DateTime.DaysInMonth(ano,mesPassado);
            var quantPDia1 = diaHoje.Day - 1;
            var quantp1semana = 6 - quantPDia1;
            var diadomespassado = daisnoMesPassado - quantp1semana;
            List<DateTime> list = new List<DateTime>();
            for (int i = quantp1semana; i >= 1; i--)
            {
                list.Add(new DateTime(ano, mesPassado, (daisnoMesPassado - i)));
            }
            for(int i = (quantPDia1 +1); i>=1; i--)
            {
                list.Add(new DateTime(ano, mes, i));
            }
            ViewBag.Dias = list.OrderBy(x => x.Date);
            return View();
        }

        // GET: WorkoutsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WorkoutsController/Edit/5
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

        // GET: WorkoutsController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _workoutService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
           
        }

        // POST: WorkoutsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                _workoutService.Remove(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
