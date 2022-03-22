using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movieflix_api.Models
{
  public class Movie
  {
    public Movie()
    {
      Title = string.Empty;
      Length = string.Empty;
      Director = string.Empty;
      Genre = string.Empty;
      ImageUrl = string.Empty;
    }

    public int Id { get; set; }
    public string Title { get; set; }
    public int ReleaseYear { get; set; }
    public string Length { get; set; }
    public string Director { get; set; }
    public string Genre { get; set; }
    public string ImageUrl { get; set; }
  }
}