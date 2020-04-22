using System;
using System.ComponentModel.DataAnnotations;

namespace shipp.Models
{
  public class Sheet
  {
    [Key]
    public int id { get; set; }
    public string title { get; set; }
    public DateTime initialDate { get; set; }
    public DateTime finalDate { get; set; }
    public int folderId { get; set; }
    public Folder folder { get; set; }
  }
}