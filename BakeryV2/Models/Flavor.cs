using System.Collections.Generic;

namespace BakeryV2.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    public string Name { get; set; }
    public List<TreatFlavor> JoinEntities { get; } // collection navigation property.
  }
}