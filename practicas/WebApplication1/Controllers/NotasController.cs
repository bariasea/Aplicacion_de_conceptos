using System.Threading.Tasks;
using System.Web.Mvc;
using WebApplication1.Models;

using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class NotasController : Controller
    {
        private readonly INotaService _notaService;

        public NotasController(INotaService notaService)
        {
            _notaService = notaService;
        }



        public async Task<ActionResult> LongRunning()
        {
            await _notaService.LongRunningOperationAsync();
            return Content("Operación larga completada");
        }








        // GET: Notas/Details/5
        public ActionResult Details(int id)
        {
            var nota = _notaService.GetNotaById(id);
            if (nota == null)
            {
                return HttpNotFound();
            }
            return View(nota);
        }

        // GET: Notas/Create
        public ActionResult Create()
        {
            return View();
        }







        // POST: Notas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Notas nota)
        {
            if (ModelState.IsValid)
            {
                await _notaService.AddNotaAsync(nota);
                return RedirectToAction("Index");
            }
            return View(nota);
        }













        // GET: Notas/Edit/5
        public ActionResult Edit(int id)
        {
            var nota = _notaService.GetNotaById(id);
            if (nota == null)
            {
                return HttpNotFound();
            }
            return View(nota);
        }

        // POST: Notas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Notas nota)
        {
            if (ModelState.IsValid)
            {
                _notaService.UpdateNota(nota);
                return RedirectToAction("Index");
            }
            return View(nota);
        }

        // GET: Notas/Delete/5
        public ActionResult Delete(int id)
        {
            var nota = _notaService.GetNotaById(id);
            if (nota == null)
            {
                return HttpNotFound();
            }
            return View(nota);
        }

        // POST: Notas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _notaService.DeleteNota(id);
            return RedirectToAction("Index");
        }
    }
}
