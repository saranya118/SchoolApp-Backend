using RestAPIProject.Model;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestAPIProject.Repository;

namespace RestAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepositoy movieRepository;

        public MovieController(IMovieRepositoy movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        [HttpGet,Route("GetAllMovie")]
        
        public IActionResult GetAllMovie()
        {
            try
            {
                List<Movie> movies = movieRepository.GetAllMovie();
                return StatusCode(200, movies);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

        [HttpPost,Route("AddMovie")]

        public IActionResult AddMovie(Movie movie)
        {
            try
            {
                movieRepository.AddMovie(movie);
                return StatusCode(200, movie);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet,Route("GetMoviesByName/{name}")]

        public IActionResult GetMoviesByName(string name) 
        {
            try
            {
                return StatusCode(200, movieRepository.GetMoviesByName(name));
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

        [HttpGet, Route("GetMoviesByActor/{actor}")]

        public IActionResult GetMoviesByActor(string actor)
        {
            try
            {
                return StatusCode(200, movieRepository.GetMoviesByActor(actor));
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

        [HttpGet, Route("GetMoviesByYear/{year}")]

        public IActionResult GetMoviesByYear(int year)
        {
            try
            {
                return StatusCode(200, movieRepository.GetMoviesByYear(year));
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

        [HttpGet, Route("GetMoviesByDirector/{director}")]

        public IActionResult GGetMoviesByDirector(string director)
        {
            try
            {
                return StatusCode(200, movieRepository.GetMoviesByDirector(director));
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }


    }
}
