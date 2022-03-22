using System.Text.Json;
using movieflix_api.Models;

namespace movieflix_api.Data
{
  public class LoadData
  {
    public static async Task<IEnumerable<Movie>> LoadMovies()
    {

      var options = new JsonSerializerOptions
      {
        PropertyNameCaseInsensitive = true
      };

      var data = await File.ReadAllTextAsync("Data/movies.json");
      var movies = JsonSerializer.Deserialize<List<Movie>>(data, options);

      if (movies is not null)
      {
        return movies;
      }

      return new List<Movie>();

    }
  }
}