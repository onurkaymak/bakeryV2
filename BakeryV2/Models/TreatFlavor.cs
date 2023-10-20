namespace BakeryV2.Models
{
  public class TreatFlavor // Join Entity
  {
    public int TreatFlavorId { get; set; }
    public int TreatId { get; set; }
    public Treat Treat { get; set; } // reference navigation property
    public int FlavorId { get; set; }
    public Flavor Flavor { get; set; } // reference navigation property
  }
}