using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movieflix_api.Data;
using movieflix_api.Models;

namespace movieflix_api.Controllers
{
    [ApiController]
    [Route("api/v1/movies")] //Url till Endpoint(resursen = movies)
    public class MoviesController : ControllerBase
    {
        private readonly DataContext _context;
        public MoviesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<Movie>>> ListMovies()
        {
            //hämta filmer från databasen i Azure
            var movies = await _context.Movies.ToListAsync();
            //retunera listan med filmer till den som vill ha dem
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