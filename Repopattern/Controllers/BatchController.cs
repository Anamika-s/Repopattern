using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repopattern.IRepo;
using Repopattern.Models;
using Repopattern.Repo;

namespace Repopattern.Controllers
{
    public class BatchController : Controller
    {
        IBatchRepo _repo;
        public BatchController(IBatchRepo repo)
        {
            _repo = repo;
        }
        // GET: BatchController
        public ActionResult Index()
        {
            return View(_repo.GetBatches());
        }

        // GET: BatchController/Details/5
        public ActionResult Details(int id)
        {
            return View(_repo.GetBatchById(id));
        }

        // GET: BatchController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: BatchController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Batch batch)
        {
            try
            {

                _repo.AddBatch(batch); 
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BatchController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_repo.GetBatchById(id));
        }

        // POST: BatchController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Batch batch)
        {
            try
            {
                _repo.UpdateBatch(id, batch);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BatchController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_repo.GetBatchById(id));
        }

        // POST: BatchController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _repo.DeleteBatch(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
