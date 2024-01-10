using RestAPIProject.Model;

namespace RestAPIProject.Repository
{
    public interface IMovieRepositoy
    {
        void AddMovie(Movie movie);
        List<Movie> GetAllMovie();
        List<Movie> GetMoviesByName(string name);
        List<Movie> GetMoviesByActor(string actor);
        List<Movie> GetMoviesByYear(int year);
        List<Movie> GetMoviesByDirector(string director);

    }
}
