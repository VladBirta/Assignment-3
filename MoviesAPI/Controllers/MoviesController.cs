using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {

        private static List<Movie> movies = new List<Movie>()
        {
            new Movie() { ID = Guid.NewGuid(), Name = "WW2", Genre = "History"},
            new Movie() { ID = Guid.NewGuid(), Name = "Bohemian Rhapsody", Genre = "Musical"},
            new Movie() { ID = Guid.NewGuid(), Name = "Horrible Bosses", Genre = "Comedy"},
            new Movie() { ID = Guid.NewGuid(), Name = "Little Man", Genre = "Action"}
        };

        [HttpGet]
        public Movie[] Get()
        {
            return movies.ToArray();
        }

        [HttpPost]
        public void Post([FromBody] Movie movie)
        {
            if (movie.ID == Guid.Empty)
                movie.ID = Guid.NewGuid();

            movies.Add(movie);
        }

        [HttpPut]
        public void Put([FromBody] Movie movie)
        {
            Movie currentMovie = movies.FirstOrDefault(m => m.ID == movie.ID);
            currentMovie.Name = movie.Name;
            currentMovie.Genre = movie.Genre;

        }

        [HttpDelete]
        public void Delete(Guid id)
        {
            movies.RemoveAll(movie => movie.ID == id);
        }
    }

}
