using System.ComponentModel.DataAnnotations;

namespace shipp.Models
{
  public class Folder
  {
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Year { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
  }
}