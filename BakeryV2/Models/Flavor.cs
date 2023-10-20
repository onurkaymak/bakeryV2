using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BakeryV2.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }

    [Required(ErrorMessage = "The treat's name can't be empty!")] // validation attribute for Name.
    public string Name { get; set; }
    public List<TreatFlavor> JoinEntities { get; } // collection navigation property.
  }
}