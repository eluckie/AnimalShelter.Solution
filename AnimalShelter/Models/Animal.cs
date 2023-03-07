using System.Collections.Generic;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Breed { get; set; }
    public string Name { get; set; }
    public datetime DateAdmitted { get; set; }
    public string Type { get; set; }
  }
}