using System.ComponentModel.DataAnnotations;
using System;

namespace shipp.Models
{
  public class Folder
  {
    [Key]
    public int id { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public int year { get; set; }
    public DateTime createdAt { get; set; } = System.DateTime.UtcNow;
  }
}