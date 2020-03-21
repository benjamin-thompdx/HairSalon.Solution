using System.ComponentModel.DataAnnotations;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }

    public string Name { get; set; }

    public string Phone_Number { get; set; }

    public string Email { get; set; }

    [Required(ErrorMessage = "Stylist must be specified")]
    public int StylistId { get; set; }

    public virtual Stylist Stylist { get; set; }
  }
}