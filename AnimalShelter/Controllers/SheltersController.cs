using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AnimalShelter.Controllers
{
  public class SheltersController : Controller
  {
    private readonly AnimalShelterContext _db;
    public SheltersController(AnimalShelterContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Shelter> model = _db.Shelters.ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public ActionResult Create (Shelter shelter)
    {
      _db.Shelters.Add(shelter);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      Shelter thisShelter = _db.Shelters
        .Include(shelter => shelter.Animals)
        .FirstOrDefault(shelter => shelter.ShelterId == id);
      return View(thisShelter);
    }
    public ActionResult Edit(int id)
    {
      Shelter thisShelter = _db.Shelters.FirstOrDefault(shelter => shelter.ShelterId == id);
      return View(thisShelter);
    }
    [HttpPost]
    public ActionResult Edit(Shelter shelter)
    {
      _db.Shelters.Update(shelter);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Delete(int id)
    {
      Shelter thisShelter = _db.Shelters.FirstOrDefault(shelter => shelter.ShelterId == id);
      return View(thisShelter);
    }
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Shelter thisShelter = _db.Shelters
        .FirstOrDefault(shelter => shelter.ShelterId == id);
        _db.Shelters.Remove(thisShelter);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
  }
}