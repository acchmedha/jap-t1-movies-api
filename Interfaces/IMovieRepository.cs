using JAP_Task_1_MoviesApi.Helpers;
using JAP_Task_1_MoviesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JAP_Task_1_MoviesApi.Interfaces
{
    public interface IMovieRepository
    {
        void Update(Movie movie);
        Task<bool> SaveAllAsync();
        Task<PagedList<Movie>> GetMoviesAsync(MovieParams movieParams);
        Task<Movie> GetMovieByIdAsync(int id);
        Task<Movie> GetMovieByTitleAsync(string title);
    }
}
