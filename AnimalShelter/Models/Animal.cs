using System.Collections.Generic;
using System;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public string Breed { get; set; }
    public DateTime DateAdmitted { get; set; }
    public int ShelterId { get; set; }
    public Shelter Shelter { get; set; }
  }
}