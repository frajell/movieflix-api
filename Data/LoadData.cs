using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using movieflix_api.Models;

namespace movieflix_api.Data
{
    public class LoadData
    {

        public static async Task LoadMovies(DataContext context)
        {

            if (await context.Movies.AnyAsync())
            {
                return;
            }

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var data = await File.ReadAllTextAsync("Data/movies.json");
            var movies = JsonSerializer.Deserialize<List<Movie>>(data, options);

            if (movies is not null)
            {
                await context.AddRangeAsync(movies);
                await context.SaveChangesAsync();
            }



        }
    }
}