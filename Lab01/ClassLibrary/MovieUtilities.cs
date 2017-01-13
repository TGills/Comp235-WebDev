using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    public class MovieUtilities
    {
        public List<Movie> SelectAll()
        {
            MovieData md = new MovieData();
            return md.getMovies();
        }
        public void UpdateMovie(int id, string title, string director, string description)
        {
            Movie MovieToUpdate = new Movie(id, title, director, description);
            MovieData md = new MovieData();
            md.MovieUpdate(MovieToUpdate);
        }

        public void getMovieByID(int id)
        {
           //int selectMovie = new Movie(id);
            MovieData md = new MovieData();
            md.getMoviesByID(id);
          


        }









    }
}
