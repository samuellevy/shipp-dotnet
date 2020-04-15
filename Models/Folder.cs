using System.ComponentModel.DataAnnotations;

namespace shipp.Models
{
  public class Folder
  {
    [Key]
    public int id { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public int year { get; set; }
    // public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
  }
}