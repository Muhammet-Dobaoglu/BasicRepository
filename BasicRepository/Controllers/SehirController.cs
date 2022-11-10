using BasicRepository.Data;
using BasicRepository.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BasicRepository.Controllers
{
    public class SehirController : Controller
    {
        private readonly Repository<Sehir> _rep;
        //newleme işlemi
        public SehirController(Repository<Sehir> rep)
        {
            _rep = rep;
        }
        //başka yerde kullanmayalım diye

        public IActionResult List()
        {

            return View(_rep.Liste());
        }
        public IActionResult Create()
        {
           Sehir s = new Sehir();
            return View("Crud", s);
        }
        [HttpPost]
        public IActionResult Create(Sehir s)
        {
            _rep.Create(s);
            _rep.Save();
            return RedirectToAction("List");

        }
        public IActionResult Edit(int Id)
        {
           Sehir s = _rep.Find(Id);
            return View("Crud", s);
        }
        [HttpPost]
        public IActionResult Edit(Sehir s)
        {
            _rep.Update(s);
            _rep.Save();
            return RedirectToAction("List");

        }
        public IActionResult Delete(int Id)
        {
            Sehir s= _rep.Find(Id);
            return View("Crud", s);
        }
        [HttpPost]
        public IActionResult Delete(Sehir s)
        {
            _rep.Delete(s);
            _rep.Save();
            return RedirectToAction("List");

        }
    }
}
