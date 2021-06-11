using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {

        private static List<Movie> movies = new List<Movie>()
        {
            new Movie() { id = Guid.NewGuid(), name = "Titanic", genre = 'Drama' },
            new Movie() { id = Guid.NewGuid(), name = "Pearl Harbor", genre = 'Istoric' },
            new Movie() { id = Guid.NewGuid(), name = "Cars", genre = 'Cartoon' },
        };

        [HttpGet]
        public Movie[] Get()
        {
            return movies.ToArray();
        }

        [HttpPost]
        public void Post([FromBody] Movie movie)
        {
            if (movie.id == Guid.Empty)
                movie.id = Guid.NewGuid();

            movies.Add(movie);
        }

        [HttpPut]
        public void Put([FromBody] Movie movie)
        {
            Movie currentMovie = movies.FirstOrDefault(m => m.id == movie.id);
            currentMovie.name = movie.name;
            currentMovie.duration = movie.duration;
        }

        [HttpDelete]
        public void Delete(Guid id)
        {
            movies.RemoveAll(movie => movie.id == id);
        }
    }
}