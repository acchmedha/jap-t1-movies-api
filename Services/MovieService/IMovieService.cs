using JAP_Task_1_MoviesApi.Helpers;
using JAP_Task_1_MoviesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_Task_1_MoviesApi.Services.MovieService
{
    public interface IMovieService
    {
        Task<bool> SaveAllAsync();
        Task<PagedList<Movie>> GetMoviesAsync(MovieParams movieParams, string search);
        Task<Movie> GetMovieByIdAsync(int id);
        Task<Movie> GetMovieByTitleAsync(string title);
        Task UpdateMovieAsync(Movie movie);
        bool MovieExists(int id);
    }
}
