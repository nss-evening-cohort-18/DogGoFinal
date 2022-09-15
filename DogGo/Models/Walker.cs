﻿using System.ComponentModel.DataAnnotations;

namespace DogGo.Models;

public class Walker
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int NeighborhoodId { get; set; }
    [Display(Name = "Avatar")]
    public string ImageUrl { get; set; }
    public Neighborhood Neighborhood { get; set; } = new Neighborhood();
}
