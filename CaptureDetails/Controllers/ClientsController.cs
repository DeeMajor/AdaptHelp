using CaptureDetails.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CaptureDetails.Services;

namespace CaptureDetails.Controllers
{
    public class ClientsController : Controller
    {
        private WriteFile _writeFile;

        public ClientsController(WriteFile writefile)
        {
            _writeFile = writefile;
        }

        // GET: ClientsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ClientsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClientsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Client client)
        {
            try
            {
                string results = _writeFile.WriteToFile(client);

                return RedirectToAction("Index", "Home", new {message = results});
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home", new { message =  ex.Message});
            }
        }

        // GET: ClientsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientsController/Edit/5
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

        // GET: ClientsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientsController/Delete/5
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
