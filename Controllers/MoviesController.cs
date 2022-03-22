using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using movieflix_api.Data;
using movieflix_api.Models;

namespace movieflix_api.Controllers
{
  [ApiController]
  [Route("api/v1/movies")] //Url till Endpoint(resursen = movies)
  public class MoviesController : ControllerBase
  {
    [HttpGet()]
    public async Task<ActionResult<IEnumerable<Movie>>> ListMovies()
    {
      var movies = await LoadData.LoadMovies();

      return Ok(movies);
    }

    [HttpGet("{title}")]
    public ActionResult<Movie> GetMovie(string title)
    {
      var movie = new Movie { Id = 1, Title = "Batman Begins" };
      return Ok(movie);
    }
  }
}