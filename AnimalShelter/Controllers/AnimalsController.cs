using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AnimalShelter.Controllers
{
  public class AnimalsController : Controller
  {
    private readonly AnimalShelterContext _db;
    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Animal> model = _db.Animals
        .Include(animal => animal.Shelter)
        .ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      ViewBag.ShelterId = new SelectList(_db.Shelters, "ShelterId", "Name");
      return View();
    }
    [HttpPost]
    public ActionResult Create (Animal animal)
    {
      if (animal.ShelterId == 0)
      {
        return RedirectToAction("Index");
      }
      _db.Animals.Add(animal);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      Animal thisAnimal = _db.Animals
        .Include(animal => animal.Shelter)
        .FirstOrDefault(animal => animal.AnimalId == id);
        return View(thisAnimal);
    }
    public ActionResult Edit(int id)
    {
      Animal thisAnimal = _db.Animals
        .FirstOrDefault(animal => animal.AnimalId == id);
      ViewBag.ShelterId = new SelectList(_db.Shelters, "ShelterId", "Name");
      return View(thisAnimal);
    }
    [HttpPost]
    public ActionResult Edit(Animal animal)
    {
      _db.Animals.Update(animal);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Delete(int id)
    {
      Animal thisAnimal = _db.Animals
        .FirstOrDefault(animal => animal.AnimalId == id);
      return View(thisAnimal);
    }
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Animal thisAnimal = _db.Animals
        .FirstOrDefault(animal => animal.AnimalId == id);
      _db.Animals.Remove(thisAnimal);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}