using System;
using System.Collections.Generic;
using nothinbutdotnetprep.utility;
using nothinbutdotnetprep.utility.filtering;

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
            return movies.one_at_a_time();
        }

        public void add(Movie movie)
        {
            if (already_contains(movie)) return;

            movies.Add(movie);
        }

        bool already_contains(Movie movie)
        {
            return movies.Contains(movie);
        }

        public IEnumerable<Movie> all_movies_matching(Condition<Movie> criteria)
        {
            return movies.all_items_matching(criteria);
        }



        public IEnumerable<Movie> all_movies_published_by_pixar_or_disney()
        {
            return
                all_movies_matching(
                    movie =>
                        movie.production_studio == ProductionStudio.Pixar ||
                            movie.production_studio == ProductionStudio.Disney);
        }

        public IEnumerable<Movie> all_movies_published_after(int year)
        {
            foreach (var movie in this.movies)
            {
                if (movie.date_published.Year > year)
                    yield return movie;
            }
        }

        public IEnumerable<Movie> all_movies_published_between_years(int startingYear, int endingYear)
        {
            foreach (var movie in this.movies)
            {
                if (movie.date_published.Year >= startingYear && movie.date_published.Year <= endingYear)
                    yield return movie;
            }
        }

        public IEnumerable<Movie> sort_all_movies_by_title_descending()
        {
            var sorted_movie_list = new List<Movie>(movies);
            return sorted_movie_list;
        }

        public IEnumerable<Movie> all_action_movies()
        {
            foreach (var movie in this.movies)
            {
                if (movie.genre == Genre.action)
                    yield return movie;
            }
        }

        public IEnumerable<Movie> all_kid_movies()
        {
            foreach (var movie in this.movies)
            {
                if (movie.genre == Genre.kids)
                    yield return movie;
            }
        }

        public IEnumerable<Movie> all_movies_not_published_by_pixar()
        {
            foreach (var movie in this.movies)
            {
                if (movie.production_studio != ProductionStudio.Pixar)
                    yield return movie;
            }
        }

        public IEnumerable<Movie> sort_all_movies_by_title_ascending()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> sort_all_movies_by_movie_studio_and_year_published()
        {
            throw new NotImplementedException();
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