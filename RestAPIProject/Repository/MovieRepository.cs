using RestAPIProject.Model;
using System.IO;

namespace RestAPIProject.Repository
{
    public class MovieRepository : IMovieRepositoy
    {
        public List<Movie> movies = new List<Movie>()
        {
            new Movie(){MovieId=123, MovieName="Kaadhal",Lang="Tamil",Year=2000, Actor="Surya",Director="Hari" },
            new Movie(){MovieId=124, MovieName="Jailer",Lang="Tamil",Year=2023, Actor="Rajinikanth",Director="Nelson" },
            new Movie(){MovieId=125, MovieName="Don",Lang="Tamil",Year=2022, Actor="SK",Director="Sibi" }
        };
        public void AddMovie(Movie movie)
        {
            try
            {
                movies.Add(movie);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Movie> GetAllMovie()
        {
            try
            {
                return movies;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Movie> GetMoviesByActor(string actor)
        {
            try
            {
              List<Movie> moviebyactor = new List<Movie>();
                foreach(var movie in movies)
                {
                    if(movie.Actor == actor)
                        moviebyactor.Add(movie);
                }
                return moviebyactor;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Movie> GetMoviesByDirector(string director)
        {
            try
            {
                List<Movie> moviebydir = new List<Movie>();
                foreach (var movie in movies)
                {
                    if (movie.Director == director)
                        moviebydir.Add(movie);
                }
                return moviebydir;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Movie> GetMoviesByName(string name)
        {
            try
            {
                List<Movie> moviebyname = new List<Movie>();
                foreach (var movie in movies)
                {
                    if (movie.MovieName == name)
                        moviebyname.Add(movie);
                }
                return moviebyname;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Movie> GetMoviesByYear(int year)
        {
            try
            {
                List<Movie> moviebyyear = new List<Movie>();
                foreach (var movie in movies)
                {
                    if (movie.Year == year)
                    {
                        moviebyyear.Add(movie);
                    }
                    else
                    {

                    }
                }
                return moviebyyear;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
