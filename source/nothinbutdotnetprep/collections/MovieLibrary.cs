using System;
using System.Collections.Generic;

namespace nothinbutdotnetprep.collections
{
    public class MovieLibrary
    {
        IList<Movie> movies;

        public MovieLibrary(IList<Movie> list_of_movies)
        {
            this.movies = list_of_movies;
        }

        public IEnumerable<Movie> all_movies()
        {
            foreach (var movie in movies)
                yield return movie;

        }

        public void add(Movie movie)
        {
            if(!movies.Contains(movie))
                movies.Add(movie);
        }

        public IEnumerable<Movie> sort_all_movies_by_title_descending()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_movies_published_by_pixar()
        {
            foreach (Movie movie in movies)
            {
                if (movie.production_studio.Equals(ProductionStudio.Pixar))
                {
                    yield return movie;
                }
            }
        }

        public IEnumerable<Movie> all_movies_published_by_pixar_or_disney()
        {
            foreach (Movie movie in movies)
            {
                if (movie.production_studio.Equals(ProductionStudio.Pixar) || movie.production_studio.Equals(ProductionStudio.Disney))
                {
                    yield return movie;
                }
            }
        }

        public IEnumerable<Movie> sort_all_movies_by_title_ascending()
        {
            List<Movie> movie_list = new List<Movie>(movies);
            movie_list.Sort();
            return movie_list;

        }

        public IEnumerable<Movie> sort_all_movies_by_movie_studio_and_year_published()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_movies_not_published_by_pixar()
        {
            foreach(Movie movie in movies)
            {
                if(!movie.production_studio.Equals(ProductionStudio.Pixar))
                {
                    yield return movie;
                }
            }
        }

        public IEnumerable<Movie> all_movies_published_after(int year)
        {
            foreach (Movie movie in movies)
            {
                if (movie.date_published.Year > year)
                {
                    yield return movie;
                }
            }
        }

        public IEnumerable<Movie> all_movies_published_between_years(int startingYear, int endingYear)
        {
            foreach (Movie movie in movies)
            {
                if (movie.date_published.Year > startingYear && movie.date_published.Year < endingYear)
                {
                    yield return movie;
                }
            }
        }

        public IEnumerable<Movie> all_kid_movies()
        {
            return movies_by_genre(Genre.kids);
        }

        public IEnumerable<Movie> all_action_movies()
        {
            return movies_by_genre(Genre.action);
        }

        public IEnumerable<Movie> movies_by_genre(Genre genre)
        {
            foreach (Movie movie in movies)
            {
                if (movie.genre.Equals(genre))
                {
                    yield return movie;
                }
            }
        } 

        
        public IEnumerable<Movie> sort_all_movies_by_date_published_descending()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> sort_all_movies_by_date_published_ascending()
        {
            throw new NotImplementedException();
        }
    }
}